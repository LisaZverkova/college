using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    class DataBase
    {
        SqlConnection sqlConnection;
        public DataBase(string servername,string basename) 
        {
                sqlConnection = new SqlConnection($"Data Source={servername}; Initial Catalog={basename}; Integrated Security=True");
        }
        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
               sqlConnection.Open();
            }
        }
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
