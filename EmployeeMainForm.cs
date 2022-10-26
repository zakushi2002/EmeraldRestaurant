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
    public partial class Employee_Main_Form : Form
    {
        public Employee_Main_Form()
        {
            InitializeComponent();
        }
        SqlCommand command;
        MY_DB mydb = new MY_DB();
        Employee employee = new Employee();
        public static int C1;
        public static int C2;
        private void labelLogOut_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void labelEditInfo_Click(object sender, EventArgs e)
        {
            EditEmployeeInfoForm edit = new EditEmployeeInfoForm();
            edit.ShowDialog();
        }
        public void getImageAndFullName()
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                command = new SqlCommand("SELECT * FROM Employee WHERE eemail = @mail", mydb.getConnection);
                command.Parameters.Add("@mail", SqlDbType.VarChar).Value = Global.GlobalEmail.Trim();
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    string fname = (string)table.Rows[0]["efirstname"];
                    string lname = (string)table.Rows[0]["elastname"];
                    labelHello.Text = "Hello " + fname.Trim() + " " + lname.Trim();
                    try
                    {
                        byte[] pic = (byte[])table.Rows[0]["eimage"];
                        MemoryStream picture = new MemoryStream(pic);
                        pictureImage.Image = Image.FromStream(picture);
                    }
                    catch
                    {
                        pictureImage.Image = pictureImage.ErrorImage;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void labelRefresh_Click(object sender, EventArgs e)
        {
            getImageAndFullName();
        }

        private void Employee_Main_Form_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
            labelDate.Text = DateTime.Now.ToLongDateString();
            getImageAndFullName();

            showSalary();
        }
        void showSalary()
        {
            
            int HourInt = Convert.ToInt32(DateTime.Now.Hour.ToString());
            int MinuteInt = Convert.ToInt32(DateTime.Now.Minute.ToString());
            if (HourInt >= 22 && MinuteInt >= 5)
            {
                int yy = Convert.ToInt32(DateTime.Now.Year.ToString());
                int MM = Convert.ToInt32(DateTime.Now.Month.ToString());
                int dd = Convert.ToInt32(DateTime.Now.Day.ToString());
                DateTime dt = new DateTime(yy, MM, dd);
                string thu = dt.DayOfWeek.ToString().Trim();

                SqlCommand command = new SqlCommand("SELECT totalSalaryOf"+thu+ " FROM [Salary] WHERE email = '"+Global.GlobalEmail.Trim()+"'", mydb.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                MessageBox.Show("Your salary today is: " + table.Rows[0][0].ToString(), "Salary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public int CheckDay()       // Check Thứ Now để lấy cột của thứ Now để lấy ca ra và tính Time đúng của ca làm.
        {
            int cot = 0;
            int yy = Convert.ToInt32(DateTime.Now.Year.ToString());
            int MM = Convert.ToInt32(DateTime.Now.Month.ToString());
            int dd = Convert.ToInt32(DateTime.Now.Day.ToString());
            DateTime dt = new DateTime(yy, MM, dd);
            string thu = dt.DayOfWeek.ToString().Trim();
            if (thu == "MonDay")
                cot = 1;
            if (thu == "Tuesday")
                cot = 2;
            if (thu == "Wednesday")
                cot = 3;
            if (thu == "Thursday")
                cot = 4;
            if (thu == "Friday")
                cot = 5;
            if (thu == "Saturday")
                cot = 6;
            if (thu == "Sunday")
                cot = 7;
            return cot;
        }
        Salary salary = new Salary();
        private void buttonStart_Click(object sender, EventArgs e)
        {
            string mail = Global.GlobalEmail.Trim();
            command = new SqlCommand("SELECT * FROM Shift WHERE email = '" + Global.GlobalEmail.Trim() + "'", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);



            
            string test = table.Rows[0][CheckDay()].ToString().Trim();   // Lấy số mã hóa ca ra, nếu số 1 là làm ca 1 và 2
            int HourInt = Convert.ToInt32(DateTime.Now.Hour.ToString());
            if (test == "1" || test == "-1")
            {
                //Khong co ca toi_ca 3
                if (radioButtonNight.Checked == true)
                {
                    MessageBox.Show("Not your shift", "Start To Work");
                }
                //Check gio ca 1
                if (radioButtonMorning.Checked == true)
                {
                    if (HourInt >= 7 && HourInt < 11)
                    {
                        salary.updateStartCa1(mail, Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss")));
                        MessageBox.Show("Start working time", "Start Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        buttonStart.Enabled = false;
                        buttonFinish.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Not shift start time", "Start To Work");
                    }                        
                }
                //Check gio ca 2
                if (radioButtonNoon.Checked == true)
                {
                    if (HourInt >= 11 && HourInt < 15)
                    {
                        salary.updateStartCa2(mail, Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss")));
                        MessageBox.Show("Start working time", "Start Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        buttonStart.Enabled = false;
                        buttonFinish.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Not shift start time", "Start To Work");
                    }                        
                }
            }
            if (test == "2" || test == "-2")
            {
                //Khong co ca trua_ca 2
                if (radioButtonNoon.Checked == true)
                    MessageBox.Show("Not your shift", "Start To Work");
                //Check gio ca 1
                if (radioButtonMorning.Checked == true)
                {
                    if (HourInt >= 7 && HourInt < 11)
                    {
                        salary.updateStartCa1(mail, Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss")));
                        MessageBox.Show("Start working time", "Start Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        buttonStart.Enabled = false;
                        buttonFinish.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Not shift start time", "Start To Work");
                    }
                }
                //Check gio ca 3
                if (radioButtonNight.Checked == true)
                {
                    if (HourInt >= 18 && HourInt < 22)
                    {
                        salary.updateStartCa3(mail, Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss")));
                        MessageBox.Show("Start working time", "Start Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        buttonStart.Enabled = false;
                        buttonFinish.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Not shift start time", "Start To Work");
                    }
                }
            }
            if (test == "3" || test == "-3")
            {
                //Khong co ca sang_ca 1
                if (radioButtonMorning.Checked == true)
                {
                    MessageBox.Show("Not your shift", "Start To Work");
                }
                //Check gio ca 2
                if (radioButtonNoon.Checked == true)
                {
                    if (HourInt >= 11 && HourInt < 15)
                    {
                        salary.updateStartCa2(mail, Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss")));
                        MessageBox.Show("Start working time", "Start Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        buttonStart.Enabled = false;
                        buttonFinish.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Not shift start time", "Start To Work");
                    }
                }

                //Check gio ca 3
                if (radioButtonNight.Checked == true)
                {
                    if (HourInt >= 18 && HourInt < 22)
                    {
                        salary.updateStartCa3(mail, Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss")));
                        MessageBox.Show("Start working time", "Start Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        buttonStart.Enabled = false;
                        buttonFinish.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Not shift start time", "Start To Work");
                    }
                }
                
            }
            if (test == "0")
            {
                //Check gio ca 1
                if (radioButtonMorning.Checked == true)
                {
                    if (HourInt >= 7 && HourInt < 11)
                    {
                        salary.updateStartCa1(mail, Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss")));
                        MessageBox.Show("Start working time", "Start Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        buttonStart.Enabled = false;
                        buttonFinish.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Not shift start time", "Start To Work");
                    }
                }

                //Check gio ca 2
                if (radioButtonNoon.Checked == true)
                {
                    if (HourInt >= 11 && HourInt < 15)
                    {
                        salary.updateStartCa2(mail, Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss")));
                        MessageBox.Show("Start working time", "Start Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        buttonStart.Enabled = false;
                        buttonFinish.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Not shift start time", "Start To Work");
                    }
                }

                //Check gio ca 3
                if (radioButtonNight.Checked == true)
                {
                    if (HourInt >= 18 && HourInt < 22)
                    {
                        salary.updateStartCa3(mail, Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss")));
                        MessageBox.Show("Start working time", "Start To Work", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        buttonStart.Enabled = false;
                        buttonFinish.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Not shift start time", "Start To Work");
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            string mail = Global.GlobalEmail.Trim();
            command = new SqlCommand("SELECT * FROM Shift WHERE email = '" + Global.GlobalEmail.Trim() + "'", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            // Tạo Table check để kiểm tra đã có Time Start chưa, nếu chưa thì không thể Stop được
            SqlCommand commandcheck = new SqlCommand("SELECT * FROM [Check] WHERE email = '" + mail + "'", mydb.getConnection);
            SqlDataAdapter adaptercheck = new SqlDataAdapter(commandcheck);
            DataTable tablecheck = new DataTable();
            adaptercheck.Fill(tablecheck);
            if(tablecheck.Rows.Count<1)
            {

            }
            else
            {
                string test = table.Rows[0][CheckDay()].ToString().Trim();   // Lấy số mã hóa ca ra, nếu số 1 là làm ca 1 và 2
                int HourInt = Convert.ToInt32(DateTime.Now.Hour.ToString());
                if (test == "1" || test == "-1")
                {
                    //Khong co ca toi_ca 3
                    if (radioButtonNight.Checked == true)
                    {
                        MessageBox.Show("Not your shift", "Finish Work");
                    }
                    //Check gio ca 1
                    if (radioButtonMorning.Checked == true)
                    {
                        if (tablecheck.Rows[0]["startshifta"].ToString().Trim() == "")
                        {
                            MessageBox.Show("You haven't entered the shift so you can't finish the shift", "Finish Work", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (HourInt >= 7)
                            {
                                salary.updateEndCa1(mail, Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss")));
                                MessageBox.Show("End of shift", "Finish Work", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                buttonStart.Enabled = true;
                                buttonFinish.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("Not the end time of your shift", "Finish Work");
                            }
                        }

                    }
                    //Check gio ca 2
                    if (radioButtonNoon.Checked == true)
                    {
                        if (tablecheck.Rows[0]["startshiftb"].ToString().Trim() == "")
                        {
                            MessageBox.Show("You haven't entered the shift so you can't finish the shift", "Finish Work", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (HourInt >= 11)
                            {
                                salary.updateEndCa2(mail, Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss")));
                                MessageBox.Show("End of shift", "Finish Work", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                buttonStart.Enabled = true;
                                buttonFinish.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("Not the end time of your shift", "Finish Work");
                            }
                        }
                    }
                }
                if (test == "2" || test == "-2")
                {
                    //Khong co ca trua_ca 2
                    if (radioButtonNoon.Checked == true)
                        MessageBox.Show("Not your shift", "Finish Work");
                    //Check gio ca 1
                    if (radioButtonMorning.Checked == true)
                    {
                        if (tablecheck.Rows[0]["startshifta"].ToString().Trim() == "")
                        {
                            MessageBox.Show("You haven't entered the shift so you can't finish the shift", "Finish Work", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (HourInt >= 7)
                            {
                                salary.updateEndCa1(mail, Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss")));
                                MessageBox.Show("End of shift", "Finish Work", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                buttonStart.Enabled = true;
                                buttonFinish.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("Not the end time of your shift", "Finish Work");
                            }
                        }

                    }
                    //Check gio ca 3
                    if (radioButtonNight.Checked == true)
                    {
                        try
                        {
                            if (tablecheck.Rows[0]["startshiftc"].ToString().Trim() == "")
                            {
                                MessageBox.Show("You haven't entered the shift so you can't finish the shift", "Finish Work", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (HourInt >= 18)
                                {
                                    salary.updateEndCa3(mail, Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss")));
                                    MessageBox.Show("End of shift", "Finish Work", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    buttonStart.Enabled = true;
                                    buttonFinish.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Not the end time of your shift", "Finish Work");
                                }
                            }
                        }
                        catch
                        {

                        }

                    }
                }
                if (test == "3" || test == "-3")
                {
                    //Khong co ca sang_ca 1
                    if (radioButtonMorning.Checked == true)
                    {
                        MessageBox.Show("Not your shift", "Finish Work");
                    }
                    //Check gio ca 2
                    if (radioButtonNoon.Checked == true)
                    {
                        if (tablecheck.Rows[0]["startshiftb"].ToString().Trim() == "")
                        {
                            MessageBox.Show("You haven't entered the shift so you can't finish the shift", "Finish Work", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (HourInt >= 11)
                            {
                                salary.updateEndCa2(mail, Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss")));
                                MessageBox.Show("End of shift", "Finish Work", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                buttonStart.Enabled = true;
                                buttonFinish.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("Not the end time of your shift", "Finish Work");
                            }
                        }
                    }

                    //Check gio ca 3
                    if (radioButtonNight.Checked == true)
                    {
                        if (tablecheck.Rows[0]["startshiftc"].ToString().Trim() == "")
                        {
                            MessageBox.Show("You haven't entered the shift so you can't finish the shift", "Finish Work", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (HourInt >= 18)
                            {
                                salary.updateEndCa3(mail, Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss")));
                                MessageBox.Show("End of shift", "Finish Work", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                buttonStart.Enabled = true;
                                buttonFinish.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("Not the end time of your shift", "Finish Work");
                            }
                        }
                    }
                }
                if (test == "0")
                {
                    //Check gio ca 1
                    if (radioButtonMorning.Checked == true)
                    {
                        if (tablecheck.Rows[0]["startshifta"].ToString().Trim() == "")
                        {
                            MessageBox.Show("You haven't entered the shift so you can't finish the shift", "Finish Work", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (HourInt >= 7)
                            {
                                salary.updateEndCa1(mail, Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss")));
                                MessageBox.Show("End of shift", "Finish Work", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                buttonStart.Enabled = true;
                                buttonFinish.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("Not the end time of your shift", "Finish Work");
                            }
                        }
                    }

                    //Check gio ca 2
                    if (radioButtonNoon.Checked == true)
                    {
                        if (tablecheck.Rows[0]["startshiftb"].ToString().Trim() == "")
                        {
                            MessageBox.Show("You haven't entered the shift so you can't finish the shift", "Finish Work", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (HourInt >= 11)
                            {
                                salary.updateEndCa2(mail, Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss")));
                                MessageBox.Show("End of shift", "Finish Work", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                buttonStart.Enabled = true;
                                buttonFinish.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("Not the end time of your shift", "Finish Work");
                            }
                        }
                    }

                    //Check gio ca 3
                    if (radioButtonNoon.Checked == true)
                    {
                        if (tablecheck.Rows[0]["startshiftc"].ToString().Trim() == "")
                        {
                            MessageBox.Show("You haven't entered the shift so you can't finish the shift", "Finish Work", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (HourInt >= 18)
                            {
                                salary.updateEndCa3(mail, Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss")));
                                MessageBox.Show("End of shift", "Finish Work", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                buttonStart.Enabled = true;
                                buttonFinish.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("Not the end time of your shift", "Finish Work");
                            }
                        }
                    }
                }
            }
            
        }

        public void ShowM(DataTable m, int c1)
        {
            labelCaM.Text = "Employees Who Can Change Shifts: " + c1;
            comboBoxCaM.DataSource = m;
            comboBoxCaM.DisplayMember = "email";
            comboBoxCaM.ValueMember = "email";
        }
        public void ShowN(DataTable n, int c2)
        {
            labelCaN.Text = "Employees Who Can Change Shifts: " + c2;
            comboBoxCaN.DataSource = n;
            comboBoxCaN.DisplayMember = "email";
            comboBoxCaN.ValueMember = "email";
        }
        private void tabPageShiftList_Click(object sender, EventArgs e)
        {
            string mail = Global.GlobalEmail.Trim();
            int yy = Convert.ToInt32(DateTime.Now.Year.ToString());
            int MM = Convert.ToInt32(DateTime.Now.Month.ToString());
            int dd = Convert.ToInt32(DateTime.Now.Day.ToString());
            DateTime dt = new DateTime(yy, MM, dd);
            string dayOfWeek = dt.DayOfWeek.ToString().Trim();

            // Check xem có lời mời làm hộ nào không.
            SqlCommand commandCa = new SqlCommand("SELECT email AS [Email], T2 AS [Monday], T3 AS [Tuesday], T4 AS [Wednesday], T5 AS [Thursday], T6 AS [Friday], T7 AS [Saturday], CN AS [Sunday] FROM [Shift] WHERE email = '" + mail + "'", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(commandCa);
            DataTable tableCa = new DataTable();
            adapter.Fill(tableCa);
            string keyDay = "day";
            if (dayOfWeek == "Monday")
            {
                keyDay = "T2";
                if (Convert.ToInt32(tableCa.Rows[0][dayOfWeek].ToString().Trim()) < 0)
                {
                    if ((MessageBox.Show("You Get 1 Offer to Change Shift.\nSo Today You Work All 3 Shifts.\nDo you agree?", "Change Shifts", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        salary.changeShift(mail, keyDay);
                        //salary.changeShiftNULL(Global.GlobalWhoSentTheInvitation, keyDay);
                    }
                }
            }
            if (dayOfWeek == "Tuesday")
            {
                keyDay = "T3";
                if (Convert.ToInt32(tableCa.Rows[0][dayOfWeek].ToString().Trim()) < 0)
                {
                    if ((MessageBox.Show("You Get 1 Offer to Change Shift.\nSo Today You Work All 3 Shifts.\nDo you agree?", "Change Shifts", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        salary.changeShift(mail, keyDay);
                    }
                }
            }
            if (dayOfWeek == "Wednesday")
            {
                keyDay = "T4";
                if (Convert.ToInt32(tableCa.Rows[0][dayOfWeek].ToString().Trim()) < 0)
                {
                    if ((MessageBox.Show("You Get 1 Offer to Change Shift.\nSo Today You Work All 3 Shifts.\nDo you agree?", "Change Shifts", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        salary.changeShift(mail, keyDay);
                    }
                }
            }
            if (dayOfWeek == "Thursday")
            {
                keyDay = "T5";
                if (Convert.ToInt32(tableCa.Rows[0][dayOfWeek].ToString().Trim()) < 0)
                {
                    if ((MessageBox.Show("You Get 1 Offer to Change Shift.\nSo Today You Work All 3 Shifts.\nDo you agree?", "Change Shifts", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        salary.changeShift(mail, keyDay);
                    }
                }
            }
            if (dayOfWeek == "Friday")
            {
                keyDay = "T6";
                if (Convert.ToInt32(tableCa.Rows[0][dayOfWeek].ToString().Trim()) < 0)
                {
                    if ((MessageBox.Show("You Get 1 Offer to Change Shift.\nSo Today You Work All 3 Shifts.\nDo you agree?", "Change Shifts", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        salary.changeShift(mail, keyDay);
                    }
                }
            }
            if (dayOfWeek == "Saturday")
            {
                keyDay = "T7";
                if (Convert.ToInt32(tableCa.Rows[0][dayOfWeek].ToString().Trim()) < 0)
                {
                    if ((MessageBox.Show("You Get 1 Offer to Change Shift.\nSo Today You Work All 3 Shifts.\nDo you agree?", "Change Shifts", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        salary.changeShift(mail, keyDay);
                    }
                }
            }
            if (dayOfWeek == "Sunday")
            {
                keyDay = "CN";
                if (Convert.ToInt32(tableCa.Rows[0][dayOfWeek].ToString().Trim()) < 0)
                {
                    if ((MessageBox.Show("You Get 1 Offer to Change Shift.\nSo Today You Work All 3 Shifts.\nDo you agree?", "Change Shifts", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        salary.changeShift(mail, keyDay);
                    }
                }
            }
            loadShift(mail);
        }
        void loadShift(string mail)
        {
            SqlCommand commandCaNew = new SqlCommand("SELECT email AS [Email], T2 AS [Monday], T3 AS [Tuesday], T4 AS [Wednesday], T5 AS [Thursday], T6 AS [Friday], T7 AS [Saturday], CN AS [Sunday] FROM [Shift] WHERE email = '" + mail.Trim() + "'", mydb.getConnection);
            SqlDataAdapter adapterNew = new SqlDataAdapter(commandCaNew);
            DataTable tableCaNew = new DataTable();
            adapterNew.Fill(tableCaNew);
            dataGridViewShiftList.DataSource = tableCaNew;
            dataGridViewShiftList.AllowUserToAddRows = false;
            for (int i = 0; i < tableCaNew.Rows.Count; i++)
            {
                for (int j = 1; j < tableCaNew.Columns.Count; j++)
                {
                    if (Convert.ToInt32(tableCaNew.Rows[i][j].ToString().Trim()) == 3 || Convert.ToInt32(tableCaNew.Rows[i][j].ToString().Trim()) == -3)
                    {
                        dataGridViewShiftList.Rows[i].Cells[j].Value = "Ca 2 & Ca 3";
                    }
                    else if (Convert.ToInt32(tableCaNew.Rows[i][j].ToString().Trim()) == 2 || Convert.ToInt32(tableCaNew.Rows[i][j].ToString().Trim()) == -2)
                    {
                        dataGridViewShiftList.Rows[i].Cells[j].Value = "Ca 1 & Ca 3";
                    }
                    else if (Convert.ToInt32(tableCaNew.Rows[i][j].ToString().Trim()) == 1 || Convert.ToInt32(tableCaNew.Rows[i][j].ToString().Trim()) == -1)
                    {
                        dataGridViewShiftList.Rows[i].Cells[j].Value = "Ca 1 & Ca 2";
                    }
                    else if (Convert.ToInt32(tableCaNew.Rows[i][j].ToString().Trim()) == 0)
                    {
                        dataGridViewShiftList.Rows[i].Cells[j].Value = "Ca 1 & Ca 2 & Ca 3";
                    }
                }
            }
        }

        private void employeeWhoCanChangeButton_Click(object sender, EventArgs e)
        {
            comboBoxCaM.Enabled = true;
            comboBoxCaN.Enabled = true;


            string mail = Global.GlobalEmail.Trim();
            int yy = Convert.ToInt32(DateTime.Now.Year.ToString());
            int MM = Convert.ToInt32(DateTime.Now.Month.ToString());
            int dd = Convert.ToInt32(DateTime.Now.Day.ToString());
            DateTime dt = new DateTime(yy, MM, dd);
            string dayOfWeek = dt.DayOfWeek.ToString().Trim();



            SqlCommand commandCa = new SqlCommand("SELECT email AS [Email], T2 AS [Monday], T3 AS [Tuesday], T4 AS [Wednesday], T5 AS [Thursday], T6 AS [Friday], T7 AS [Saturday], CN AS [Sunday] FROM [Shift] WHERE email = '" + mail + "'", mydb.getConnection);
            SqlDataAdapter adapterCa = new SqlDataAdapter(commandCa);
            DataTable tableCa = new DataTable();
            adapterCa.Fill(tableCa);


            string keyDay = "day";
            if (dayOfWeek == "Monday")
            {
                keyDay = "T2";
                if (Convert.ToInt32(tableCa.Rows[0][dayOfWeek]) == 1)
                {
                    ShowM(employee.employeeWhoCanChange(mail, keyDay, 1), 1);
                    C1 = 1;
                    ShowN(employee.employeeWhoCanChange(mail, keyDay, 2), 2);
                    C2 = 2;
                }
                else if (Convert.ToInt32(tableCa.Rows[0][dayOfWeek]) == 2)
                {
                    ShowM(employee.employeeWhoCanChange(mail, keyDay, 1), 1);
                    C1 = 1;
                    ShowN(employee.employeeWhoCanChange(mail, keyDay, 3), 3);
                    C2 = 3;
                }
                else if (Convert.ToInt32(tableCa.Rows[0][dayOfWeek]) == 3)
                {
                    ShowM(employee.employeeWhoCanChange(mail, keyDay, 2), 2);
                    C1 = 2;
                    ShowN(employee.employeeWhoCanChange(mail, keyDay, 3), 3);
                    C2 = 3;
                }
            }
            if (dayOfWeek == "Tuesday")
            {
                keyDay = "T3";
                if (Convert.ToInt32(tableCa.Rows[0][dayOfWeek]) == 1)
                {
                    ShowM(employee.employeeWhoCanChange(mail, keyDay, 1), 1);
                    C1 = 1;
                    ShowN(employee.employeeWhoCanChange(mail, keyDay, 2), 2);
                    C2 = 2;
                }
                else if (Convert.ToInt32(tableCa.Rows[0][dayOfWeek]) == 2)
                {
                    ShowM(employee.employeeWhoCanChange(mail, keyDay, 1), 1);
                    C1 = 1;
                    ShowN(employee.employeeWhoCanChange(mail, keyDay, 3), 3);
                    C2 = 3;
                }
                else if (Convert.ToInt32(tableCa.Rows[0][dayOfWeek]) == 3)
                {
                    ShowM(employee.employeeWhoCanChange(mail, keyDay, 2), 2);
                    C1 = 2;
                    ShowN(employee.employeeWhoCanChange(mail, keyDay, 3), 3);
                    C2 = 3;
                }
            }
            if (dayOfWeek == "Wednesday")
            {
                keyDay = "T4";
                if (Convert.ToInt32(tableCa.Rows[0][dayOfWeek]) == 1)
                {
                    ShowM(employee.employeeWhoCanChange(mail, keyDay, 1), 1);
                    C1 = 1;
                    ShowN(employee.employeeWhoCanChange(mail, keyDay, 2), 2);
                    C2 = 2;
                }
                else if (Convert.ToInt32(tableCa.Rows[0][dayOfWeek]) == 2)
                {
                    ShowM(employee.employeeWhoCanChange(mail, keyDay, 1), 1);
                    C1 = 1;
                    ShowN(employee.employeeWhoCanChange(mail, keyDay, 3), 3);
                    C2 = 3;
                }
                else if (Convert.ToInt32(tableCa.Rows[0][dayOfWeek]) == 3)
                {
                    ShowM(employee.employeeWhoCanChange(mail, keyDay, 2), 2);
                    C1 = 2;
                    ShowN(employee.employeeWhoCanChange(mail, keyDay, 3), 3);
                    C2 = 3;
                }
            }
            if (dayOfWeek == "Thursday")
            {
                keyDay = "T5";
                if (Convert.ToInt32(tableCa.Rows[0][dayOfWeek]) == 1)
                {
                    ShowM(employee.employeeWhoCanChange(mail, keyDay, 1), 1);
                    C1 = 1;
                    ShowN(employee.employeeWhoCanChange(mail, keyDay, 2), 2);
                    C2 = 2;
                }
                else if (Convert.ToInt32(tableCa.Rows[0][dayOfWeek]) == 2)
                {
                    ShowM(employee.employeeWhoCanChange(mail, keyDay, 1), 1);
                    C1 = 1;
                    ShowN(employee.employeeWhoCanChange(mail, keyDay, 3), 3);
                    C2 = 3;
                }
                else if (Convert.ToInt32(tableCa.Rows[0][dayOfWeek]) == 3)
                {
                    ShowM(employee.employeeWhoCanChange(mail, keyDay, 2), 2);
                    C1 = 2;
                    ShowN(employee.employeeWhoCanChange(mail, keyDay, 3), 3);
                    C2 = 3;
                }
            }
            if (dayOfWeek == "Friday")
            {
                keyDay = "T6";
                if (Convert.ToInt32(tableCa.Rows[0][dayOfWeek]) == 1)
                {
                    ShowM(employee.employeeWhoCanChange(mail, keyDay, 1), 1);
                    C1 = 1;
                    ShowN(employee.employeeWhoCanChange(mail, keyDay, 2), 2);
                    C2 = 2;
                }
                else if (Convert.ToInt32(tableCa.Rows[0][dayOfWeek]) == 2)
                {
                    ShowM(employee.employeeWhoCanChange(mail, keyDay, 1), 1);
                    C1 = 1;
                    ShowN(employee.employeeWhoCanChange(mail, keyDay, 3), 3);
                    C2 = 3;
                }
                else if (Convert.ToInt32(tableCa.Rows[0][dayOfWeek]) == 3)
                {
                    ShowM(employee.employeeWhoCanChange(mail, keyDay, 2), 2);
                    C1 = 2;
                    ShowN(employee.employeeWhoCanChange(mail, keyDay, 3), 3);
                    C2 = 3;
                }
                else 
                {
                    MessageBox.Show("ERROR");
                }
            }
            if (dayOfWeek == "Saturday")
            {
                keyDay = "T7";
                if (Convert.ToInt32(tableCa.Rows[0][dayOfWeek]) == 1)
                {
                    ShowM(employee.employeeWhoCanChange(mail, keyDay, 1), 1);
                    C1 = 1;
                    ShowN(employee.employeeWhoCanChange(mail, keyDay, 2), 2);
                    C2 = 2;
                }
                else if (Convert.ToInt32(tableCa.Rows[0][dayOfWeek]) == 2)
                {
                    ShowM(employee.employeeWhoCanChange(mail, keyDay, 1), 1);
                    C1 = 1;
                    ShowN(employee.employeeWhoCanChange(mail, keyDay, 3), 3);
                    C2 = 3;
                }
                else if (Convert.ToInt32(tableCa.Rows[0][dayOfWeek]) == 3)
                {
                    ShowM(employee.employeeWhoCanChange(mail, keyDay, 2), 2);
                    C1 = 2;
                    ShowN(employee.employeeWhoCanChange(mail, keyDay, 3), 3);
                    C2 = 3;
                }
            }
            if (dayOfWeek == "Sunday")
            {
                keyDay = "CN";
                if (Convert.ToInt32(tableCa.Rows[0][dayOfWeek]) == 1)
                {
                    ShowM(employee.employeeWhoCanChange(mail, keyDay, 1), 1);
                    C1 = 1;
                    ShowN(employee.employeeWhoCanChange(mail, keyDay, 2), 2);
                    C2 = 2;
                }
                else if (Convert.ToInt32(tableCa.Rows[0][dayOfWeek]) == 2)
                {
                    ShowM(employee.employeeWhoCanChange(mail, keyDay, 1), 1);
                    C1 = 1;
                    ShowN(employee.employeeWhoCanChange(mail, keyDay, 3), 3);
                    C2 = 3;
                }
                else if (Convert.ToInt32(tableCa.Rows[0][dayOfWeek]) == 3)
                {
                    ShowM(employee.employeeWhoCanChange(mail, keyDay, 2), 2);
                    C1 = 2;
                    ShowN(employee.employeeWhoCanChange(mail, keyDay, 3), 3);
                    C2 = 3;
                }
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            int yy = Convert.ToInt32(DateTime.Now.Year.ToString());
            int MM = Convert.ToInt32(DateTime.Now.Month.ToString());
            int dd = Convert.ToInt32(DateTime.Now.Day.ToString());
            DateTime dt = new DateTime(yy, MM, dd);
            string dayOfWeek = dt.DayOfWeek.ToString().Trim();
            string keyDay = "day";
            if (dayOfWeek == "Monday")
            {
                keyDay = "T2";
                try
                {
                    if(salary.inviteChangeShift(comboBoxCaM.SelectedValue.ToString().Trim(), keyDay, -1 * C1) && salary.inviteChangeShift(comboBoxCaN.SelectedValue.ToString().Trim(), keyDay, -1 * C2))
                    {
                        MessageBox.Show("Invitation sent successfully!", "Change Shift");
                    }
                    else if(salary.inviteChangeShift(comboBoxCaM.SelectedValue.ToString().Trim(), keyDay, -1 * C1))
                    {
                        MessageBox.Show("Send 1 successful invitation, 1 failed invitation!", "Change Shift");
                    }
                    else if (salary.inviteChangeShift(comboBoxCaN.SelectedValue.ToString().Trim(), keyDay, -1 * C2))
                    {
                        MessageBox.Show("Send 1 successful invitation, 1 failed invitation!", "Change Shift");
                    }
                    else
                    {
                        MessageBox.Show("Invitation failed!", "Change Shift");
                    }
                    //Global.SetGlobalWhoSentTheInvitation(comboBoxCaN.SelectedValue.ToString().Trim());
                }
                catch
                {
                    MessageBox.Show("There are no employees available!", "Change Shift");
                }
            }
            if (dayOfWeek == "Tuesday")
            {
                keyDay = "T3";
                try
                {
                    if (salary.inviteChangeShift(comboBoxCaM.SelectedValue.ToString().Trim(), keyDay, -1 * C1) && salary.inviteChangeShift(comboBoxCaN.SelectedValue.ToString().Trim(), keyDay, -1 * C2))
                    {
                        MessageBox.Show("Invitation sent successfully!", "Change Shift");
                    }
                    else if (salary.inviteChangeShift(comboBoxCaM.SelectedValue.ToString().Trim(), keyDay, -1 * C1))
                    {
                        MessageBox.Show("Send 1 successful invitation, 1 failed invitation!", "Change Shift");
                    }
                    else if (salary.inviteChangeShift(comboBoxCaN.SelectedValue.ToString().Trim(), keyDay, -1 * C2))
                    {
                        MessageBox.Show("Send 1 successful invitation, 1 failed invitation!", "Change Shift");
                    }
                    else
                    {
                        MessageBox.Show("Invitation failed!", "Change Shift");
                    }
                    //Global.SetGlobalWhoSentTheInvitation(comboBoxCaN.SelectedValue.ToString().Trim());
                }
                catch
                {
                    MessageBox.Show("There are no employees available!", "Change Shift");
                }
            }
            if (dayOfWeek == "Wednesday")
            {
                keyDay = "T4";
                try
                {
                    if (salary.inviteChangeShift(comboBoxCaM.SelectedValue.ToString().Trim(), keyDay, -1 * C1) && salary.inviteChangeShift(comboBoxCaN.SelectedValue.ToString().Trim(), keyDay, -1 * C2))
                    {
                        MessageBox.Show("Invitation sent successfully!", "Change Shift");
                    }
                    else if (salary.inviteChangeShift(comboBoxCaM.SelectedValue.ToString().Trim(), keyDay, -1 * C1))
                    {
                        MessageBox.Show("Send 1 successful invitation, 1 failed invitation!", "Change Shift");
                    }
                    else if (salary.inviteChangeShift(comboBoxCaN.SelectedValue.ToString().Trim(), keyDay, -1 * C2))
                    {
                        MessageBox.Show("Send 1 successful invitation, 1 failed invitation!", "Change Shift");
                    }
                    else
                    {
                        MessageBox.Show("Invitation failed!", "Change Shift");
                    }
                    //Global.SetGlobalWhoSentTheInvitation(comboBoxCaN.SelectedValue.ToString().Trim());
                }
                catch
                {
                    MessageBox.Show("There are no employees available!", "Change Shift");
                }
            }
            if (dayOfWeek == "Thursday")
            {
                keyDay = "T5";
                try
                {
                    if (salary.inviteChangeShift(comboBoxCaM.SelectedValue.ToString().Trim(), keyDay, -1 * C1) && salary.inviteChangeShift(comboBoxCaN.SelectedValue.ToString().Trim(), keyDay, -1 * C2))
                    {
                        MessageBox.Show("Invitation sent successfully!", "Change Shift");
                    }
                    else if (salary.inviteChangeShift(comboBoxCaM.SelectedValue.ToString().Trim(), keyDay, -1 * C1))
                    {
                        MessageBox.Show("Send 1 successful invitation, 1 failed invitation!", "Change Shift");
                    }
                    else if (salary.inviteChangeShift(comboBoxCaN.SelectedValue.ToString().Trim(), keyDay, -1 * C2))
                    {
                        MessageBox.Show("Send 1 successful invitation, 1 failed invitation!", "Change Shift");
                    }
                    else
                    {
                        MessageBox.Show("Invitation failed!", "Change Shift");
                    }
                    //Global.SetGlobalWhoSentTheInvitation(comboBoxCaN.SelectedValue.ToString().Trim());
                }
                catch
                {
                    MessageBox.Show("There are no employees available!", "Change Shift");
                }
            }
            if (dayOfWeek == "Friday")
            {
                keyDay = "T6";
                try
                {
                    if (salary.inviteChangeShift(comboBoxCaM.SelectedValue.ToString().Trim(), keyDay, -1 * C1) && salary.inviteChangeShift(comboBoxCaN.SelectedValue.ToString().Trim(), keyDay, -1 * C2))
                    {
                        MessageBox.Show("Invitation sent successfully!", "Change Shift");
                    }
                    else if (salary.inviteChangeShift(comboBoxCaM.SelectedValue.ToString().Trim(), keyDay, -1 * C1))
                    {
                        MessageBox.Show("Send 1 successful invitation, 1 failed invitation!", "Change Shift");
                    }
                    else if (salary.inviteChangeShift(comboBoxCaN.SelectedValue.ToString().Trim(), keyDay, -1 * C2))
                    {
                        MessageBox.Show("Send 1 successful invitation, 1 failed invitation!", "Change Shift");
                    }
                    else
                    {
                        MessageBox.Show("Invitation failed!", "Change Shift");
                    }
                    //Global.SetGlobalWhoSentTheInvitation(comboBoxCaN.SelectedValue.ToString().Trim());
                }
                catch
                {
                    MessageBox.Show("There are no employees available!", "Change Shift");
                }
            }
            if (dayOfWeek == "Saturday")
            {
                keyDay = "T7";
                try
                {
                    if (salary.inviteChangeShift(comboBoxCaM.SelectedValue.ToString().Trim(), keyDay, -1 * C1) && salary.inviteChangeShift(comboBoxCaN.SelectedValue.ToString().Trim(), keyDay, -1 * C2))
                    {
                        MessageBox.Show("Invitation sent successfully!", "Change Shift");
                    }
                    else if (salary.inviteChangeShift(comboBoxCaM.SelectedValue.ToString().Trim(), keyDay, -1 * C1))
                    {
                        MessageBox.Show("Send 1 successful invitation, 1 failed invitation!", "Change Shift");
                    }
                    else if (salary.inviteChangeShift(comboBoxCaN.SelectedValue.ToString().Trim(), keyDay, -1 * C2))
                    {
                        MessageBox.Show("Send 1 successful invitation, 1 failed invitation!", "Change Shift");
                    }
                    else
                    {
                        MessageBox.Show("Invitation failed!", "Change Shift");
                    }
                    //Global.SetGlobalWhoSentTheInvitation(comboBoxCaN.SelectedValue.ToString().Trim());
                }
                catch
                {
                    MessageBox.Show("There are no employees available!", "Change Shift");
                }
            }
            if (dayOfWeek == "Sunday")
            {
                keyDay = "CN";
                try
                {
                    if (salary.inviteChangeShift(comboBoxCaM.SelectedValue.ToString().Trim(), keyDay, -1 * C1) && salary.inviteChangeShift(comboBoxCaN.SelectedValue.ToString().Trim(), keyDay, -1 * C2))
                    {
                        MessageBox.Show("Invitation sent successfully!", "Change Shift");
                    }
                    else if (salary.inviteChangeShift(comboBoxCaM.SelectedValue.ToString().Trim(), keyDay, -1 * C1))
                    {
                        MessageBox.Show("Send 1 successful invitation, 1 failed invitation!", "Change Shift");
                    }
                    else if (salary.inviteChangeShift(comboBoxCaN.SelectedValue.ToString().Trim(), keyDay, -1 * C2))
                    {
                        MessageBox.Show("Send 1 successful invitation, 1 failed invitation!", "Change Shift");
                    }
                    else
                    {
                        MessageBox.Show("Invitation failed!", "Change Shift");
                    }
                    //Global.SetGlobalWhoSentTheInvitation(comboBoxCaN.SelectedValue.ToString().Trim());
                }
                catch
                {
                    MessageBox.Show("There are no employees available!", "Change Shift");
                }
            }
        }
    }
}
