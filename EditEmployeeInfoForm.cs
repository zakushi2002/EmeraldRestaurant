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
    public partial class EditEmployeeInfoForm : Form
    {
        public EditEmployeeInfoForm()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        Employee employee = new Employee();
        int verif()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT epassword FROM Employee WHERE eemail =@mail", mydb.getConnection);
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = Global.GlobalEmail;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (txtBoxFname.Text.Trim() == ""
                || txtBoxLname.Text.Trim() == ""
                || txtBoxAddress.Text.Trim() == ""
                || txtBoxPhone.Text.Trim() == ""
                || txtBoxPassword.Text.Trim() == "")
            {
                return 0;
            }
            else if (PictureBoxImage.Image == null)
            {
                return 2;
            }
            else if (txtBoxPassword.Text.Trim() != table.Rows[0][0].ToString().Trim())
            {
                return 3;
            }
            else
            {
                return 1;
            }

        }
        void loadPersonalInformation()
        {
            string email = Global.GlobalEmail.Trim();
            txtBoxEmail.Text = email;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM Employee WHERE eemail =@mail", mydb.getConnection);
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                string fname = (string)table.Rows[0]["efirstname"];
                string lname = (string)table.Rows[0]["elastname"];
                txtBoxFname.Text = fname.Trim();
                txtBoxLname.Text = lname.Trim();
                DateTimePicker1.Value = (DateTime)table.Rows[0]["ebirthdate"];
                if (table.Rows[0]["egender"].ToString().Trim() == "Male")
                {
                    RadioButtonMale.Checked = true;
                }
                else
                {
                    RadioButtonFemale.Checked = true;
                }
                txtBoxPhone.Text = table.Rows[0]["ephone"].ToString().Trim();
                txtBoxAddress.Text = table.Rows[0]["eaddress"].ToString().Trim();
                try
                {
                    byte[] pic = (byte[])table.Rows[0]["eimage"];
                    MemoryStream picture = new MemoryStream(pic);
                    PictureBoxImage.Image = Image.FromStream(picture);
                }
                catch
                {
                    PictureBoxImage.Image = PictureBoxImage.ErrorImage;
                }
            }
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            int born_year = DateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            if (verif() == 0)
            {
                MessageBox.Show("Please fill in all the information!", "Edit Employee Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (((this_year - born_year) < 18) || ((this_year - born_year) > 60))
            {
                MessageBox.Show("The Employee Age Must Be Between 18 and 60 year", "Edit Employee Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (verif() == 2)
            {
                MessageBox.Show("Please add a picture of yourself for identification!", "Edit Employee Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (verif() == 3)
            {
                MessageBox.Show("Incorrect password!\nPlease re-enter your password!", "Edit Employee Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    string email = Global.GlobalEmail.Trim();
                    string firstname = txtBoxFname.Text.Trim();
                    string lastname = txtBoxLname.Text.Trim();
                    DateTime birthdate = DateTimePicker1.Value;
                    string gender = "Female";
                    if (RadioButtonMale.Checked)
                    {
                        gender = "Male";
                    }
                    string phone = txtBoxPhone.Text.Trim();
                    string address = txtBoxAddress.Text.Trim();
                    MemoryStream image = new MemoryStream();
                    PictureBoxImage.Image.Save(image, PictureBoxImage.Image.RawFormat);
                    if (employee.update(firstname, lastname, birthdate, gender.Trim(), phone, address, image, email))
                    {
                        MessageBox.Show("Your Information Is Edited", "Edit Employee Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Employee Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Employee Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void EditEmployeeInfoForm_Load(object sender, EventArgs e)
        {
            loadPersonalInformation();
        }

        private void changeImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBoxFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtBoxLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
