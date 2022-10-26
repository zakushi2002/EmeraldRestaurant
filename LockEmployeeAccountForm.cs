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
    public partial class LockEmployeeAccountForm : Form
    {
        public LockEmployeeAccountForm()
        {
            InitializeComponent();
        }
        Employee employee = new Employee();
        MY_DB mydb = new MY_DB();
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT efirstname, elastname, eimage FROM Employee WHERE eemail =@mail", mydb.getConnection);
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = txtBoxEmail.Text.Trim();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                txtBoxFname.Text = table.Rows[0]["efirstname"].ToString().Trim() + " " + table.Rows[0]["elastname"].ToString().Trim();
                try
                {
                    byte[] pic = (byte[])table.Rows[0]["eimage"];
                    MemoryStream picture = new MemoryStream(pic);
                    pictureBoxImage.Image = Image.FromStream(picture);
                }
                catch
                {
                    pictureBoxImage.Image = pictureBoxImage.ErrorImage;
                }
            }
        }

        private void LockAccountbutton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            try
            {
                
                SqlCommand command = new SqlCommand("SELECT * FROM Employee WHERE eemail =@mail", mydb.getConnection);
                command.Parameters.Add("@mail", SqlDbType.VarChar).Value = txtBoxEmail.Text.Trim();
                adapter.SelectCommand = command;
                adapter.Fill(table);
            }
            catch
            {
                table.Rows.Clear();
            }
            
            if (txtBoxEmail.Text.Trim()=="")
            {
                MessageBox.Show("Please enter the email of the employee you want to block the account!", "Lock Employee Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (table.Rows.Count<1)
            {
                MessageBox.Show("This email does not belong to any employees!", "Lock Employee Account", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to lock this account?", "Lock Employee Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (employee.update(0, txtBoxEmail.Text.Trim()))
                        {
                            MessageBox.Show("Successfully locked " + txtBoxFname.Text.Trim() + "'s account!", "Lock Employee Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error", "Lock Employee Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }                                            
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lock Employee Account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
