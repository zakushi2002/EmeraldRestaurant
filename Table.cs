using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmeraldRestaurant
{
    class Table
    {
        MY_DB mydb = new MY_DB();
        SqlCommand command;
        public bool insert(string id, string name, int quantity)
        {
            command = new SqlCommand("INSERT INTO [Table] (tableid,tablename, quantitycus, status)" +
                " VALUES (@id, @name, @quantitycus, @status)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Char).Value = id.Trim();
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name.Trim();
            command.Parameters.Add("@quantitycus", SqlDbType.Int).Value = quantity;
            command.Parameters.Add("@status", SqlDbType.VarChar).Value = "0";
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
        public bool update(string id, string name, int quantity)
        {
            command = new SqlCommand("UPDATE [Table] SET tablename=@name, quantitycus =@quantity WHERE tableid =@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Char).Value = id.Trim();
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name.Trim();
            command.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;
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
        public bool update(string id,string status)
        {
            command = new SqlCommand("UPDATE [Table] SET status=@sta WHERE tableid =@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Char).Value = id.Trim();
            command.Parameters.Add("@sta", SqlDbType.VarChar).Value = status;
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
        public bool delete(string id)
        {
            command = new SqlCommand("DELETE FROM [Table] WHERE tableid = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Char).Value = id.Trim();
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
        public DataTable showTable()
        {
            SqlCommand command = new SqlCommand("SELECT tableid AS [Table ID], tablename AS [Name], quantitycus AS [Quantity Customer], [status] AS [Status]  FROM [Table]", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool checkID(string id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [Table] WHERE tableid=@id", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Char).Value = id.Trim();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                //neu phat hien co 1 dong ton tai trung ten
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }

        }
    }
}
