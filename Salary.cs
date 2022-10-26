using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmeraldRestaurant
{
    class Salary
    {
        MY_DB mydb = new MY_DB();
        SqlCommand command;
        //Them ID luong vao bang luong khi check in lan dau
        public bool insert(string mail)
        {
            command = new SqlCommand("INSERT INTO Salary (email) VALUES (@mail)", mydb.getConnection);
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = mail;
            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool update(string mail, string dayOfWeek,double salary)
        {
            command = new SqlCommand("UPDATE Salary SET totalSalaryOf"+dayOfWeek.Trim()+" = @salary WHERE email = @mail", mydb.getConnection);
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = mail;
            command.Parameters.Add("@salary", SqlDbType.Float).Value = salary;
            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool insertCheck(string mail)
        {
            command = new SqlCommand("INSERT INTO [Check] (email) VALUES (@mail)", mydb.getConnection);
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = mail;
            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool updateDefaultDateNow(string email, string columnName) 
        { 
            SqlCommand command = new SqlCommand("UPDATE [Check] SET "+columnName.Trim()+ " = @a WHERE email=@mail", mydb.getConnection);
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@a", SqlDbType.DateTime).Value = DateTime.Now;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool updateStartCa1(string email, DateTime time)
        {
            SqlCommand command = new SqlCommand("UPDATE [Check] SET startshifta=@a WHERE email=@mail", mydb.getConnection);
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@a", SqlDbType.DateTime).Value = time;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool updateStartCa2(string email, DateTime time)
        {
            SqlCommand command = new SqlCommand("UPDATE [Check] SET startshiftb=@b WHERE email=@mail", mydb.getConnection);
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@b", SqlDbType.DateTime).Value = time;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool updateStartCa3(string email, DateTime time)
        {
            SqlCommand command = new SqlCommand("UPDATE [Check] SET startshiftc=@c WHERE email=@mail", mydb.getConnection);
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@c", SqlDbType.DateTime).Value = time;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool updateEndCa1(string email, DateTime time)
        {
            SqlCommand command = new SqlCommand("UPDATE [Check] SET endshifta=@a WHERE email=@mail", mydb.getConnection);
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@a", SqlDbType.DateTime).Value = time;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool updateEndCa2(string email, DateTime time)
        {
            SqlCommand command = new SqlCommand("UPDATE [Check] SET endshiftb=@b WHERE email=@mail", mydb.getConnection);
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@b", SqlDbType.DateTime).Value = time;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool updateEndCa3(string email, DateTime time)
        {
            SqlCommand command = new SqlCommand("UPDATE [Check] SET endshiftc=@c WHERE email=@mail", mydb.getConnection);
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@c", SqlDbType.DateTime).Value = time;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        //Qua ngay moi phai reset check
        public bool resetCheck(string email)
        {
            SqlCommand command = new SqlCommand("UPDATE [Check] SET startshifta=null, startshiftb=null, startshiftc=null,endshifta=null, endshiftb=null, endshiftc=null WHERE email=@mail", mydb.getConnection);
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        //3 ca
        public bool changeShift(string email, string dayOfWeek)
        {
            SqlCommand command = new SqlCommand("UPDATE [Shift] SET " + dayOfWeek.Trim() + " = '0' WHERE email=@mail", mydb.getConnection);
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool changeShiftNULL(string email, string dayOfWeek)
        {
            SqlCommand command = new SqlCommand("UPDATE [Shift] SET " + dayOfWeek.Trim() + " = null WHERE email=@mail", mydb.getConnection);
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        //Moi lam thay
        public bool inviteChangeShift(string email, string dayOfWeek, int change)
        {
            SqlCommand command = new SqlCommand("UPDATE [Shift] SET " + dayOfWeek.Trim() + " = @change WHERE email=@mail", mydb.getConnection);
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@change", SqlDbType.Int).Value = change;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public DataTable showWeekSalary()
        {
            SqlCommand command = new SqlCommand("SELECT CONCAT(Employee.efirstname,' ',Employee.elastname) AS [Full Name],totalSalaryOfMonday AS [Salary Of Monday],totalSalaryOfTuesday AS [Salary Of Tuesday],totalSalaryOfWednesday AS [Salary Of Wednesday] ,totalSalaryOfThursday AS [Salary Of Thursday],totalSalaryOfFriday AS [Salary Of Friday],totalSalaryOfSaturday AS [Salary Of Saturday],totalSalaryOfSunday AS [Salary Of Sunday] FROM [Salary] JOIN Employee ON Salary.email = Employee.eemail", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool deleteShift(string email)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [Shift] WHERE email=@mail", mydb.getConnection);
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email.Trim();
            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool deleteSalary(string email)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [Salary] WHERE email=@mail", mydb.getConnection);
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email.Trim();
            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool deleteCheck(string email)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [Check] WHERE email=@mail", mydb.getConnection);
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email.Trim();
            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool resetSalaryForWeek(string email)
        {
            SqlCommand command = new SqlCommand("UPDATE [Salary] SET totalSalaryOfMonday = null, totalSalaryOfTuesday= null,totalSalaryOfWednesday=null, totalSalaryOfThursday=null,totalSalaryOfFriday=null,totalSalaryOfSaturday=null,totalSalaryOfSunday=null WHERE email=@mail", mydb.getConnection);
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email.Trim();
            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
    }
}
