using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmeraldRestaurant
{
    public class MY_DB
    {
        //Duong dan ket noi voi database
        SqlConnection con = new SqlConnection(@"Data Source=MSI;Initial Catalog=EmeraldRestaurant;Integrated Security=True");
        //Ket noi database(Goi ra ngay sau cau lenh SQL)
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }
        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }
        }
        public void closeConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Close();
            }
        }
    }
}
