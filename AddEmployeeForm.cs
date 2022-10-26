using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmeraldRestaurant
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }
        Salary salary = new Salary();
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        int verif()
        {
            if ((txtBoxFname.Text.Trim() == "")
                || (txtBoxLname.Text.Trim() == "")
                || (txtBoxAddress.Text.Trim() == "")
                || (txtBoxPhone.Text.Trim() == "")
                || (txtBoxEmail.Text.Trim() == ""))
            {
                return 0;
            }
            else if(RadioButtonMale.Checked.Equals(false) && RadioButtonFemale.Checked.Equals(false))
            {
                return 2;
            }
            else if(PictureBoxEmpImage.Image == null)
            {
                return 3;
            }
            else
            {
                return 1;
            }
        }
        Employee employee = new Employee();
        Manager manager = new Manager();
        private void addButton_Click(object sender, EventArgs e)
        {
            int born_year = dateTimePicker.Value.Year;
            int this_year = DateTime.Now.Year;
            string mail = txtBoxEmail.Text.Trim();
            if (verif() == 0)
            {
                MessageBox.Show("Please fill in all the information!", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (employee.checkEmail(mail) || manager.checkEmail(mail))
            {
                MessageBox.Show("Email already exists.Please enter another email!", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!txtBoxEmail.Text.Contains('@') || !txtBoxEmail.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (verif() == 2)
            {
                MessageBox.Show("Please choose gender!", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (verif() == 3)
            {
                MessageBox.Show("Please add a picture of yourself for identification!", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    string fname = txtBoxFname.Text.Trim();
                    string lname = txtBoxLname.Text.Trim();
                    DateTime bdate = dateTimePicker.Value;
                    string phone = txtBoxPhone.Text.Trim();
                    string adrs = txtBoxAddress.Text.Trim();
                    string gender = "Male";
                    if (RadioButtonFemale.Checked)
                    {
                        gender = "Female";
                    }
                    MemoryStream pic = new MemoryStream();
                    PictureBoxEmpImage.Image.Save(pic, PictureBoxEmpImage.Image.RawFormat);
                    if (employee.insert(fname, lname, bdate, gender, phone, mail, adrs, pic, 1))
                    {
                        if (salary.insert(mail))
                        {
                            if (employee.insertShift(mail, 1, 2, 3, 1, 2, 3, 1))
                            {
                                if (salary.insertCheck(mail))
                                {
                                    MessageBox.Show("A New Employee Added", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }                                
                            }
                        }                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void uploadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxEmpImage.Image = Image.FromFile(opf.FileName);
            }
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

        private void txtBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
