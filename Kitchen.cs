using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmeraldRestaurant
{
    class Kitchen
    {
        MY_DB mydb = new MY_DB();
        SqlCommand command;
        public bool insertIngredient(string id, string name, int quantity)
        {
            command = new SqlCommand("INSERT INTO Kitchen (ingredientID,ingredientName, quantity)" +
                " VALUES (@id, @name, @quantity)", mydb.getConnection);
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
        public bool updateIngredient(string id,string name, int quantity)
        {
            command = new SqlCommand("UPDATE Kitchen SET ingredientName=@name, quantity =@quantity WHERE ingredientID =@id", mydb.getConnection);
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
        public bool deleteIngredient(string id)
        {
            command = new SqlCommand("DELETE FROM Kitchen WHERE ingredientID = @id", mydb.getConnection);
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
        public DataTable showIngredient()
        {
            SqlCommand command = new SqlCommand("SELECT ingredientID as [ID], ingredientName as [Name], quantity [Quantity] FROM Kitchen", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool checkID(string id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Kitchen WHERE ingredientID=@id", mydb.getConnection);

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
        public bool checkName(string name)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Kitchen WHERE ingredientName=@name", mydb.getConnection);

            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name.Trim();
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
