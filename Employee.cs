using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmeraldRestaurant
{
    class Employee
    {
        MY_DB mydb = new MY_DB();
        SqlCommand command;
        //Kiem tra Email da ton tai chua(Kiem tra nhan vien da duoc them vao chua de duoc quyen tao tai khoan)
        public bool checkEmail(string mail)
        {
            command = new SqlCommand("SELECT eemail FROM Employee WHERE eemail =@mail", mydb.getConnection);
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = mail.Trim();
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                //neu phat hien co 1 dong ton tai trung ten
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        //Kiem tra da tao tai khoan truoc do chua neu chua pass word se NULL
        public bool checkExistEmployeeAccount(string mail)
        {
            command = new SqlCommand("SELECT epassword FROM Employee WHERE eemail =@mail", mydb.getConnection);
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = mail.Trim();
            mydb.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            if (!reader.IsDBNull(0))
            {
                //neu phat hien co 1 dong ton tai trung ten
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        //Quan ly them nhan vien moi nhung khong kich hoat tai khoan (Tai khoan trang thai bi khoa_Can kich hoat tai khoan tai Login Form)
        public bool insert(string firstname, string lastname, DateTime birthdate, string gender, string phone, string email, string address, MemoryStream image, byte active)
        {
            command = new SqlCommand("INSERT INTO Employee (efirstname, elastname, ebirthdate, egender, ephone, eemail,eaddress, eimage, eactive)" +
                " VALUES (@first, @last, @birth, @sex, @phone,@mail,@address, @pic, @active)", mydb.getConnection);
            command.Parameters.Add("@first", SqlDbType.VarChar).Value = firstname.Trim();
            command.Parameters.Add("@last", SqlDbType.VarChar).Value = lastname.Trim();
            command.Parameters.Add("@birth", SqlDbType.Date).Value = birthdate;
            command.Parameters.Add("@sex", SqlDbType.VarChar).Value = gender.Trim();
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone.Trim();
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email.Trim();
            command.Parameters.Add("@address", SqlDbType.VarChar).Value = address.Trim();
            command.Parameters.Add("@pic", SqlDbType.Image).Value = image.ToArray();
            command.Parameters.Add("@active", SqlDbType.Bit).Value = active;
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
        //Nhan vien chinh sua thong tin ca nhan cua minh
        public bool update(string firstname, string lastname, DateTime birthdate, string gender, string phone, string address, MemoryStream image, string email)
        {
            SqlCommand command = new SqlCommand("UPDATE Employee SET efirstname=@first, elastname=@last, ebirthdate=@birth, egender=@sex, ephone=@phone, eaddress=@address, eimage=@pic WHERE eemail=@mail", mydb.getConnection);
            command.Parameters.Add("@first", SqlDbType.VarChar).Value = firstname.Trim();
            command.Parameters.Add("@last", SqlDbType.VarChar).Value = lastname.Trim();
            command.Parameters.Add("@birth", SqlDbType.Date).Value = birthdate;
            command.Parameters.Add("@sex", SqlDbType.VarChar).Value = gender.Trim();
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone.Trim();
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email.Trim();
            command.Parameters.Add("@address", SqlDbType.VarChar).Value = address.Trim();
            command.Parameters.Add("@pic", SqlDbType.Image).Value = image.ToArray();

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
        //Kich hoat tai khoan khi truoc do nhan vien moi da duoc them
        public bool update(string password, byte active, string email)
        {
            SqlCommand command = new SqlCommand("UPDATE Employee SET epassword=@pass, eactive=@active WHERE eemail=@mail", mydb.getConnection);
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password.Trim();
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email.Trim();
            command.Parameters.Add("@active", SqlDbType.Bit).Value = active;
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
        //Khoa tai khoan nhan vien
        public bool update(byte active, string email)
        {
            SqlCommand command = new SqlCommand("UPDATE Employee SET eactive=@active WHERE eemail=@mail", mydb.getConnection);
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email.Trim();
            command.Parameters.Add("@active", SqlDbType.Bit).Value = active;
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
        //Nhan vien quen mat khau
        public bool update(string password, string email)
        {
            SqlCommand command = new SqlCommand("UPDATE Employee SET epassword=@pass WHERE eemail=@mail", mydb.getConnection);
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password.Trim();
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
        //Xoa nhan vien theo email
        public bool delete(string email)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Employee WHERE eemail=@mail", mydb.getConnection);
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
        public DataTable getImage(string email)
        {
            command = new SqlCommand("SELECT eimage FROM Employee WHERE eemail=@mail",mydb.getConnection);
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email.Trim();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool insertShift(string email, int T2, int T3, int T4, int T5, int T6, int T7, int CN)
        {
            command = new SqlCommand("INSERT INTO Shift (T2, T3, T4, T5, T6, T7, CN,email) VALUES (@t2,@t3,@t4,@t5,@t6,@t7,@cn,@mail)", mydb.getConnection);
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@t2", SqlDbType.Int).Value = T2;
            command.Parameters.Add("@t3", SqlDbType.Int).Value = T3;
            command.Parameters.Add("@t4", SqlDbType.Int).Value = T4;
            command.Parameters.Add("@t5", SqlDbType.Int).Value = T5;
            command.Parameters.Add("@t6", SqlDbType.Int).Value = T6;
            command.Parameters.Add("@t7", SqlDbType.Int).Value = T7;
            command.Parameters.Add("@cn", SqlDbType.Int).Value = CN;
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
        public bool updateSplitShift(string email, int T2, int T3, int T4, int T5, int T6, int T7, int CN)
        {
            command = new SqlCommand("UPDATE Shift SET T2=@t2, T3=@t3, T4=@t4, T5=@t5, T6=@t6, T7=@t7, CN=@cn WHERE email =@mail", mydb.getConnection);
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@t2", SqlDbType.Int).Value = T2;
            command.Parameters.Add("@t3", SqlDbType.Int).Value = T3;
            command.Parameters.Add("@t4", SqlDbType.Int).Value = T4;
            command.Parameters.Add("@t5", SqlDbType.Int).Value = T5;
            command.Parameters.Add("@t6", SqlDbType.Int).Value = T6;
            command.Parameters.Add("@t7", SqlDbType.Int).Value = T7;
            command.Parameters.Add("@cn", SqlDbType.Int).Value = CN;
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
        public DataTable employeeWhoCanChange(string email, string dayOfWeek, int typeShift)
        {
            SqlCommand command = new SqlCommand("SELECT email FROM [Shift]  WHERE " + dayOfWeek.Trim() + " = @type AND email<> @mail", mydb.getConnection);
            command.Parameters.Add("@type", SqlDbType.Int).Value = typeShift;
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email.Trim();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable employeeList()
        {
            SqlCommand command = new SqlCommand("SELECT CONCAT(efirstname,' ', elastname) AS [Full Name], eemail, eimage FROM Employee", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
