using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmeraldRestaurant
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            loadapp();
            //Application.Run(new KitchenForm());
        }
        public static void loadapp()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm loginForm = new LoginForm();

            loginForm.ShowDialog();
            if (loginForm.DialogResult == DialogResult.OK && loginForm.radioEmployeeButton.Checked)
            {
                //LoadingHRForm loadingHRForm = new LoadingHRForm();
                Employee_Main_Form employee_Main_Form = new Employee_Main_Form();
                loginForm.Close();
                Application.Run(employee_Main_Form);
            }
            else if (loginForm.DialogResult == DialogResult.OK && loginForm.radioManagerButton.Checked)
            {
                //LoadingStudentForm loadingStudentForm = new LoadingStudentForm();
                ManagerMainForm manager_Main_Form = new ManagerMainForm();
                loginForm.Close();
                Application.Run(manager_Main_Form);
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
