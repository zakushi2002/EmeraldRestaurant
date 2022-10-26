using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmeraldRestaurant
{
    public partial class ActivateNewAccountForm : Form
    {
        public ActivateNewAccountForm()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        Employee employee = new Employee();
        string veritificationCode;
        public static string toEmail;
        private void sendEmailButton_Click(object sender, EventArgs e)
        {
            if (employee.checkEmail(txtBoxEmail.Text.Trim()))
            {
                string fromEmail, pass, messageBody;
                Random rand = new Random();
                veritificationCode = (rand.Next(999999)).ToString();
                MailMessage mailMessage = new MailMessage();
                toEmail = txtBoxEmail.Text.ToString();
                fromEmail = "toannht.12c5bc.1920@gmail.com";
                pass = "bame18082002";
                messageBody = "You are requesting account activation. Your verification code: " + veritificationCode + ". Please do not give the verification code to anyone to protect the account.";
                mailMessage.To.Add(toEmail);
                mailMessage.From = new MailAddress(fromEmail);
                mailMessage.Body = messageBody;
                mailMessage.Subject = "Verification Code For Account Activation";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(fromEmail, pass);
                try
                {
                    smtp.Send(mailMessage);
                    MessageBox.Show("Verification Code Sent Successfully", "Activate New Account");
                    txtBoxEmail.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Email does not match any accounts.\nPlease enter the correct email address you registered with!", "Activate New Account");
            }
        }

        private void activateButton_Click(object sender, EventArgs e)
        {
            if (txtBoxEmail.Text.Trim()==""||txtBoxVertificationCode.Text.Trim()==""|| txtBoxPassword.Text.Trim() == "" || txtBoxConfirmPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in all the information!", "Activate New Account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (veritificationCode == txtBoxVertificationCode.Text.Trim())
            {
                toEmail = txtBoxEmail.Text.Trim();
                if (txtBoxPassword.Text.Trim() != txtBoxConfirmPassword.Text.Trim())
                {
                    MessageBox.Show("Passwords are not the same.", "Activate New Account");
                }
                else
                {
                    if (employee.update(txtBoxConfirmPassword.Text.Trim(), 1, toEmail))
                    {
                        MessageBox.Show("Account activation successful!", "Activate New Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Restart();
                    }
                    else
                    {
                        MessageBox.Show("Account activation failed!", "Activate New Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("The verification code is incorrect. Please re-enter!", "Activate New Account");
            }
        }

        private void txtBoxConfirmPassword_Validated(object sender, EventArgs e)
        {
            if (txtBoxVertificationCode.Text.Trim() == veritificationCode)
            {
                activateButton.Enabled = true;
            }
            else
            {
                activateButton.Enabled = false;
            }
        }

        private void labelLoginIn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void txtBoxVertificationCode_Validated(object sender, EventArgs e)
        {
            try
            {
                DataTable getImageEmployee = employee.getImage(txtBoxEmail.Text.Trim());
                byte[] pic = (byte[])getImageEmployee.Rows[0][0];
                MemoryStream picture = new MemoryStream(pic);
                PictureBoxImage.Image = Image.FromStream(picture);
            }
            catch
            {
                PictureBoxImage.Image = PictureBoxImage.ErrorImage;
            }
        }

        private void txtBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
