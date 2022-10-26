using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmeraldRestaurant
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        MY_DB db = new MY_DB();
        SqlCommand command;
        bool verif()
        {
            if (txtBoxEmail.Text.Trim() == "" || txtBoxPassword.Text.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            if (!verif())
            {
                MessageBox.Show("Please enter your email and password!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (radioManagerButton.Checked == false && radioEmployeeButton.Checked == false)
            {
                MessageBox.Show("Please select the permission to login!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (radioEmployeeButton.Checked)
                    {
                        command = new SqlCommand("SELECT * FROM Employee WHERE eemail = @mail AND eactive = 0",db.getConnection);
                        command.Parameters.Add("@mail", SqlDbType.VarChar).Value = txtBoxEmail.Text.Trim();
                        command.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtBoxPassword.Text.Trim();
                        adapter.SelectCommand = command;
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show("Your account is not activated.\nPlease activate your account to login!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                       
                        }
                        else
                        {
                            command = new SqlCommand("SELECT * FROM Employee WHERE eemail = @mail AND epassword = @pass AND eactive = 1", db.getConnection);
                            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = txtBoxEmail.Text.Trim();
                            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtBoxPassword.Text.Trim();
                            adapter.SelectCommand = command;
                            adapter.Fill(table);
                            if (table.Rows.Count > 0)
                            {
                                string email = table.Rows[0][7].ToString().Trim();
                                Global.SetGlobalEmail(email);
                                //if()
                                DialogResult = DialogResult.OK;
                            }
                            else
                            {
                                MessageBox.Show("Please check Email or Password again!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }                            
                        }
                    }
                    else if (radioManagerButton.Checked)
                    {
                        command = new SqlCommand("SELECT * FROM Manager WHERE memail = @mail AND mpassword = @pass", db.getConnection);
                        command.Parameters.Add("@mail", SqlDbType.VarChar).Value = txtBoxEmail.Text.Trim();
                        command.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtBoxPassword.Text.Trim();
                        adapter.SelectCommand = command;
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            string email = table.Rows[0][7].ToString().Trim();
                            Global.SetGlobalEmail(email);
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("Please check Email or Password again!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void newaccountButton_Click(object sender, EventArgs e)
        {
            Hide();
            ActivateNewAccountForm activateNewAccountForm = new ActivateNewAccountForm();
            activateNewAccountForm.ShowDialog();
        }

        private void forgotButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Do you want to exit?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (exit == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void txtBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
