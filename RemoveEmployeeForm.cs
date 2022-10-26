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
    public partial class RemoveEmployeeForm : Form
    {
        public RemoveEmployeeForm()
        {
            InitializeComponent();
        }
        Employee employee= new Employee();
        MY_DB mydb = new MY_DB();
        void loadData()
        {
            comboBoxEmail.DataSource = employee.employeeList();
            comboBoxEmail.DisplayMember = "Full Name";
            comboBoxEmail.ValueMember = "eemail";
            
        }
        private void RemoveEmployeeForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        Salary salary =new Salary();
        private void removeButton_Click(object sender, EventArgs e)
        {
            string mail =comboBoxEmail.SelectedValue.ToString().Trim();
            if (employee.delete(mail))
            {
                if (salary.deleteSalary(mail))
                {
                    if (salary.deleteShift(mail))
                    {
                        if (salary.deleteCheck(mail))
                        {
                            MessageBox.Show("This Employee Is Removed", "Remove Employee");
                            loadData();
                        }
                    }
                }
                
            }
        }

        private void comboBoxEmail_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT eimage FROM Employee WHERE eemail = @mail", mydb.getConnection);
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = comboBoxEmail.SelectedValue.ToString().Trim();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                byte[] pic = (byte[])table.Rows[0]["eimage"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBoxEmployee.Image = Image.FromStream(picture);
            }
            else
            {
                pictureBoxEmployee.Image = pictureBoxEmployee.ErrorImage;
            }
        }
    }
}
