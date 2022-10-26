using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmeraldRestaurant
{
    public partial class ManagerMainForm : Form
    {
        public ManagerMainForm()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        SqlCommand command;
        Manager manager = new Manager();
        private void labelLogOut_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        void loadGrid()
        {
            dataGridViewListEmployee.ReadOnly = true;
            // xu ly hinh anh, code co tham khao msdn
            DataGridViewImageColumn picCol = new DataGridViewImageColumn(); // doi tuong lam viec voi dang picture cua datagridview
            dataGridViewListEmployee.RowTemplate.Height = 80; // dong nay tham khao tren MSDN ngay 10/03/2019, co gian de pic dep, dang tim auto-size
            dataGridViewListEmployee.DataSource = manager.employeeList();
            picCol = (DataGridViewImageColumn)dataGridViewListEmployee.Columns[5];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewListEmployee.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridViewListEmployee.AllowUserToAddRows = false;
            labelTotalEmp.Text = "Total Employee: " + dataGridViewListEmployee.RowCount;
        }
        private void Manager_Main_Form_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
            labelDate.Text = DateTime.Now.ToLongDateString();
            getImageAndFullName();
            loadGrid();
            loadData();
        }
        public void getImageAndFullName()
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                command = new SqlCommand("SELECT * FROM Manager WHERE memail = @mail", mydb.getConnection);
                command.Parameters.Add("@mail", SqlDbType.VarChar).Value = Global.GlobalEmail.Trim();
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    string fname = (string)table.Rows[0]["mfirstname"];
                    string lname = (string)table.Rows[0]["mlastname"];
                    labelHello.Text = "Hello " + fname.Trim() + " " + lname.Trim();
                    try
                    {
                        byte[] pic = (byte[])table.Rows[0]["mimage"];
                        MemoryStream picture = new MemoryStream(pic);
                        pictureImage.Image = Image.FromStream(picture);
                    }
                    catch
                    {
                        pictureImage.Image = pictureImage.ErrorImage;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        private void labelEditInfo_Click(object sender, EventArgs e)
        {
            EditManagerInfoForm form = new EditManagerInfoForm();
            form.ShowDialog();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddEmployeeForm form = new AddEmployeeForm();
            form.ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditEmployeeInfoForm form = new EditEmployeeInfoForm();
            form.ShowDialog();
        }

        private void labelRefresh_Click(object sender, EventArgs e)
        {
            getImageAndFullName();
        }

        private void labelChangePass_Click(object sender, EventArgs e)
        {

        }

        private void lockAccountButton_Click(object sender, EventArgs e)
        {
            LockEmployeeAccountForm lockEmployeeAccountForm = new LockEmployeeAccountForm();
            lockEmployeeAccountForm.ShowDialog();
        }

        private void buttonChiaCa_Click(object sender, EventArgs e)
        {
            SplitShiftForm splitShiftForm = new SplitShiftForm();
            splitShiftForm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        
        void calculateSalary()
        {
            /*command = new SqlCommand("SELECT * FROM [Shift]", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);*/

            int yy = Convert.ToInt32(DateTime.Now.Year.ToString());
            int MM = Convert.ToInt32(DateTime.Now.Month.ToString());
            int dd = Convert.ToInt32(DateTime.Now.Day.ToString());
            DateTime dt = new DateTime(yy, MM, dd);
            string dayOfWeek = dt.DayOfWeek.ToString().Trim();

            SqlCommand commandCheck = new SqlCommand("SELECT * FROM [Check]", mydb.getConnection);
            SqlDataAdapter adapterCheck = new SqlDataAdapter(commandCheck);
            DataTable tableCheck = new DataTable();
            adapterCheck.Fill(tableCheck);
            /*for (int i = 0; i < tableCheck.Rows.Count; i++)
            {
                
            }*/
            foreach(DataRow rowNull in tableCheck.Rows)
            {
                for (int j = 1; j < tableCheck.Columns.Count - 1; j++)
                {
                    if (rowNull.IsNull(j))
                    {
                        string mailne = (string)rowNull["email"];
                        salary.updateDefaultDateNow(mailne, tableCheck.Columns[j].ColumnName.Trim());
                    }
                }
            }
            foreach (DataRow rowCheck in tableCheck.Rows)
            {
                
                DateTime s1 = (DateTime)rowCheck["startshifta"];
                DateTime e1 = (DateTime)(rowCheck["endshifta"]);
                DateTime s2 = (DateTime)(rowCheck["startshiftb"]);
                DateTime e2 = (DateTime)(rowCheck["endshiftb"]);
                DateTime s3 = (DateTime)(rowCheck["startshiftc"]);
                DateTime e3 = (DateTime)(rowCheck["endshiftc"]);
                
                TimeSpan t1 = s1.Subtract(e1);
                TimeSpan t2 = s2.Subtract(e2);
                TimeSpan t3 = s3.Subtract(e3);
                double workhoura = Convert.ToDouble(t1.TotalHours.ToString());
                double workhourb = Convert.ToDouble(t2.TotalHours.ToString());
                double workhourc = Convert.ToDouble(t3.TotalHours.ToString());
                
                double totalWorkHour = workhoura + workhourb + workhourc;
                if (totalWorkHour >= 8)
                {
                    salary.update(rowCheck["email"].ToString().Trim(), dayOfWeek, totalWorkHour * 50000);
                }
                else
                {
                    double money = totalWorkHour * 50000 - 100000 * (8 - totalWorkHour);
                    if (money < 0)
                    {
                        salary.update(rowCheck["email"].ToString().Trim(), dayOfWeek, 0);
                    }
                    else
                    {
                        salary.update(rowCheck["email"].ToString().Trim(), dayOfWeek, totalWorkHour * 50000 - 100000 * (8 - totalWorkHour));
                    }
                    
                }
            }
        }
        private void calculateSalaryButton_Click(object sender, EventArgs e)
        {
            int HourInt = Convert.ToInt32(DateTime.Now.Hour.ToString());
            //int MinuteInt = Convert.ToInt32(DateTime.Now.Minute.ToString());
            if(HourInt<22)
            {
                MessageBox.Show("Not now can calculate the employee's salary!", "Calculate Employee Salary", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                calculateSalary();
                dataGridViewCalculateSalary.DataSource = salary.showWeekSalary();
            }
        }
        Salary salary = new Salary();
        private void resetTimeForEmployee_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT email FROM [Check]", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                salary.resetCheck(table.Rows[i][0].ToString().Trim());
            }
            MessageBox.Show("Reset Working Time For New Day", "Reset Time");            
        }

        private void resetSalaryButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT email FROM [Check]", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                salary.resetSalaryForWeek(table.Rows[i][0].ToString().Trim());
            }
            MessageBox.Show("Reset Salary For New Week","Reset Salary");
            dataGridViewCalculateSalary.DataSource = salary.showWeekSalary();

        }

        private void textBoxDinnerTableID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }


        private void textBoxDinnerQuantityCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            dataGridViewListEmployee.ReadOnly = true;
            // xu ly hinh anh, code co tham khao msdn
            DataGridViewImageColumn picCol = new DataGridViewImageColumn(); // doi tuong lam viec voi dang picture cua datagridview
            dataGridViewListEmployee.RowTemplate.Height = 80; // dong nay tham khao tren MSDN ngay 10/03/2019, co gian de pic dep, dang tim auto-size
            dataGridViewListEmployee.DataSource = manager.employeeSearch(txtBoxSearch.Text.Trim());
            picCol = (DataGridViewImageColumn)dataGridViewListEmployee.Columns[5];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewListEmployee.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridViewListEmployee.AllowUserToAddRows = false;
            labelTotalEmp.Text = "Total Employee: " + dataGridViewListEmployee.RowCount;
            
        }

        private void addDinnerTableButton_Click(object sender, EventArgs e)
        {
            string id = textBoxDinnerTableID.Text.Trim();
            string name = textBoxDinnerTableName.Text.Trim();

            if (verif()==false)
            {
                MessageBox.Show("Please fill in all the information!", "Manage Table", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (table.checkID(id)==false)
            {
                MessageBox.Show("Table ID Existed!", "Manage Table", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    int quantity = Convert.ToInt32(textBoxDinnerQuantityCustomer.Text.Trim());
                    if (table.insert(id, name, quantity))
                    {
                        MessageBox.Show("Successfully added new Table!", "Manage Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                }
                catch
                {
                    MessageBox.Show("Adding new Table failed!", "Manage Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        Table table = new Table();
        bool verif()
        {
            if (textBoxDinnerTableID.Text.Trim() == "" || textBoxDinnerTableName.Text.Trim() == "" || textBoxDinnerQuantityCustomer.Text.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void editDinnerTableButton_Click(object sender, EventArgs e)
        {
            string id = textBoxDinnerTableID.Text.Trim();
            string name = textBoxDinnerTableName.Text.Trim();

            if (!verif())
            {
                MessageBox.Show("Please fill in all the information!", "Manage Table", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (table.checkID(id)==true)
            {
                MessageBox.Show("Table ID does not exist!", "Manage Table", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    int quantity = Convert.ToInt32(textBoxDinnerQuantityCustomer.Text.Trim());
                    if (table.update(id, name, quantity))
                    {
                        MessageBox.Show("Successfully edited Table!", "Manage Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                }
                catch
                {
                    MessageBox.Show("Editing Table failed!", "Manage Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void removeDinnerTableButton_Click(object sender, EventArgs e)
        {
            string id = textBoxDinnerTableID.Text.Trim();
            if (textBoxDinnerTableID.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in all the information!", "Manage Table", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (table.checkID(id)==true)
            {
                MessageBox.Show("Ingredient ID does not exist!!", "Manage Table", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (table.delete(id))
                    {
                        MessageBox.Show("Successfully deleted Table!", "Manage Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                }
                catch
                {
                    MessageBox.Show("Deleting Table failed!", "Manage Tablet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            string id = textBoxDinnerTableID.Text.Trim();
            if (id=="")
            {
                MessageBox.Show("Please fill in all the information!", "Manage Table", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (table.checkID(id) == true)
            {
                MessageBox.Show("Table ID does not exist!", "Manage Table", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    int quantity = Convert.ToInt32(textBoxDinnerQuantityCustomer.Text.Trim());
                    if (table.update(id,"1"))
                    {
                        MessageBox.Show("Successfully edited Table!", "Manage Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                }
                catch
                {
                    MessageBox.Show("Editing Table failed!", "Manage Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelTableButton_Click(object sender, EventArgs e)
        {
            string id = textBoxDinnerTableID.Text.Trim();
            if (id == "")
            {
                MessageBox.Show("Please fill in all the information!", "Manage Table", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (table.checkID(id) == true)
            {
                MessageBox.Show("Table ID does not exist!", "Manage Table", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    int quantity = Convert.ToInt32(textBoxDinnerQuantityCustomer.Text.Trim());
                    if (table.update(id, "0"))
                    {
                        MessageBox.Show("Successfully edited Table!", "Manage Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                }
                catch
                {
                    MessageBox.Show("Editing Table failed!", "Manage Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        void loadData()
        {
            dataGridViewTable.DataSource = table.showTable();
            for (int i = 0; i < dataGridViewTable.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewTable.Columns.Count; j++)
                {
                    if (j == 3)
                    {
                        if ((string)dataGridViewTable.Rows[i].Cells[3].Value == "1")
                        {
                            dataGridViewTable.Rows[i].Cells[j].Value = "Booked";
                        }
                        else
                        {
                            dataGridViewTable.Rows[i].Cells[j].Value = "None";
                        }
                    }
                }

            }
            textBoxDinnerQuantityCustomer.Clear();
            textBoxDinnerTableID.Clear();
            textBoxDinnerTableName.Clear();
        }

        private void dataGridViewListTable_Click(object sender, EventArgs e)
        {
            textBoxDinnerTableID.Text = dataGridViewTable.CurrentRow.Cells[0].Value.ToString().Trim();
            textBoxDinnerTableName.Text = dataGridViewTable.CurrentRow.Cells[1].Value.ToString().Trim();
            textBoxDinnerQuantityCustomer.Text = dataGridViewTable.CurrentRow.Cells[2].Value.ToString().Trim();            
        }

        private void kitchenButton_Click(object sender, EventArgs e)
        {
            KitchenForm kitchenForm = new KitchenForm();
            kitchenForm.ShowDialog();
        }
    }
}
