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
    public partial class SplitShiftForm : Form
    {
        public SplitShiftForm()
        {
            InitializeComponent();
        }
        Employee employee = new Employee();
        MY_DB mydb = new MY_DB();
        private void splitShiftsbutton_Click(object sender, EventArgs e)
        {
            SqlCommand commandCa = new SqlCommand("SELECT Employee.eemail AS [Email], T2 AS [Monday], T3 AS [Tuesday], T4 AS [Wednesday], T5 AS [Thursday], T6 AS [Friday], T7 AS [Saturday], CN AS [Sunday] FROM [Shift] RIGHT JOIN Employee ON [Shift].email = Employee.eemail", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(commandCa);
            DataTable tableCa = new DataTable();
            adapter.Fill(tableCa);
            int n;
            Random rd = new Random();
            n = rd.Next(1, 4);
            for (int i = 0; i < tableCa.Rows.Count; i++)
            {
                for (int j = 1; j < tableCa.Columns.Count; j++)
                {
                    tableCa.Rows[i][j] = n;
                    n++;
                    if (n == 4)
                    {
                        n = 1;
                    }
                }
                employee.updateSplitShift(tableCa.Rows[i][0].ToString().Trim(), 
                    Convert.ToInt32(tableCa.Rows[i][1].ToString().Trim()), 
                    Convert.ToInt32(tableCa.Rows[i][2].ToString().Trim()), 
                    Convert.ToInt32(tableCa.Rows[i][3].ToString().Trim()), 
                    Convert.ToInt32(tableCa.Rows[i][4].ToString().Trim()), 
                    Convert.ToInt32(tableCa.Rows[i][5].ToString().Trim()), 
                    Convert.ToInt32(tableCa.Rows[i][6].ToString().Trim()), 
                    Convert.ToInt32(tableCa.Rows[i][7].ToString().Trim()));
            }
            dataGridViewSplitShift.DataSource = tableCa;
            for (int i = 0; i < tableCa.Rows.Count; i++)
            {
                for (int j = 1; j < tableCa.Columns.Count; j++)
                {
                    if (Convert.ToInt32(tableCa.Rows[i][j].ToString().Trim()) == 1)
                    {
                        dataGridViewSplitShift.Rows[i].Cells[j].Value = "Ca 1, Ca 2";
                    }
                    else if (Convert.ToInt32(tableCa.Rows[i][j].ToString().Trim()) == 2)
                    {
                        dataGridViewSplitShift.Rows[i].Cells[j].Value = "Ca 1, Ca 3";
                    }
                    else if (Convert.ToInt32(tableCa.Rows[i][j].ToString().Trim()) == 3)
                    {
                        dataGridViewSplitShift.Rows[i].Cells[j].Value = "Ca 2, Ca 3";
                    }
                }
            }
            dataGridViewSplitShift.AllowUserToAddRows = false;
            MessageBox.Show("Successfully split shifts for employees!");
        }
    }
}
