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
    class Manager
    {
        MY_DB mydb = new MY_DB();
        SqlCommand command;
        //Kiem tra Email da ton tai chua(Kiem tra nhan vien da duoc them vao chua de duoc quyen tao tai khoan)
        public bool checkEmail(string mail)
        {
            command = new SqlCommand("SELECT memail FROM Manager WHERE memail =@mail", mydb.getConnection);
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
            command = new SqlCommand("SELECT mpassword FROM Manager WHERE memail =@mail", mydb.getConnection);
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
        //Quan ly them quan ly moi nhung khong kich hoat tai khoan (Tai khoan trang thai bi khoa_Can kich hoat tai khoan tai Login Form)
        public bool insert(string firstname, string lastname, DateTime birthdate, string gender, string phone,string email, string address, MemoryStream image, byte active)
        {
            command = new SqlCommand("INSERT INTO Manager (mfirstname, mlastname, mbirthdate, mgender, mphone, memail,maddress, mimage, mactive)" +
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
        //Quan ly chinh sua thong tin ca nhan cua minh
        public bool update(string firstname, string lastname, DateTime birthdate, string gender, string phone, string address, MemoryStream image, string email)
        {
            SqlCommand command = new SqlCommand("UPDATE Manager SET mfirstname=N'"+firstname.Trim()+"', mlastname=N'"+lastname.Trim()+"', mbirthdate=@birth, mgender=@sex, mphone=@phone,maddress=N'"+address.Trim()+"', mimage=@pic WHERE memail=@mail", mydb.getConnection);
            //command.Parameters.Add("@first", SqlDbType.VarChar).Value = firstname.Trim();
            //command.Parameters.Add("@last", SqlDbType.VarChar).Value = lastname.Trim();
            command.Parameters.Add("@birth", SqlDbType.Date).Value = birthdate;
            command.Parameters.Add("@sex", SqlDbType.NVarChar).Value = gender.Trim();
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone.Trim();
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email.Trim();
            //command.Parameters.Add("@address", SqlDbType.VarChar).Value = address.Trim();
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
        //Kich hoat tai khoan khi truoc do quan ly moi da duoc them
        public bool update(string password,byte active,string email)
        {
            SqlCommand command = new SqlCommand("UPDATE Manager SET mpassword=@pass, mactive=@active WHERE memail=@mail", mydb.getConnection);
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
        //Quan ly quen mat khau
        public bool update(string password, string email)
        {
            SqlCommand command = new SqlCommand("UPDATE Manager SET mpassword=@pass WHERE memail=@mail", mydb.getConnection);
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
        //Xoa quan ly theo email
        public bool delete(string email)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Manager WHERE memail=@mail", mydb.getConnection);
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
        public DataTable employeeList()
        {
            SqlCommand command = new SqlCommand("SELECT CONCAT(efirstname,' ',elastname) AS[Full Name], ebirthdate AS[Birthdate], egender AS[Gender], eemail AS[Email], eaddress AS[Address], eimage AS[Image]  FROM Employee UNION ALL SELECT CONCAT(mfirstname, ' ', mlastname) AS[Full Name], mbirthdate AS[Birthdate], mgender AS[Gender], memail AS[Email], maddress AS[Address], mimage AS[Image] FROM Manager", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable employeeSearch(string search)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM (SELECT CONCAT(efirstname,' ',elastname) AS[Full Name], ebirthdate AS[Birthdate], egender AS[Gender], eemail AS[Email], eaddress AS[Address], eimage AS[Image]  FROM Employee UNION ALL SELECT CONCAT(mfirstname, ' ', mlastname) AS[Full Name], mbirthdate AS[Birthdate], mgender AS[Gender], memail AS[Email], maddress AS[Address], mimage AS[Image] FROM Manager) AS [Search] WHERE CONCAT([Full Name],[Email]) LIKE '%"+search.Trim()+"%' ", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

    }
}
