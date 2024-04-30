using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL
{
    public class AppDbContext
    {

        readonly string _connectionString = "Server=WIN-0F0TGHD6FSA\\SQLEXPRESS; Database=AdonetTask;Trusted_connection=true; Integrated security=true";
        SqlConnection sqlConnection;
        public AppDbContext()
        {
            sqlConnection = new SqlConnection(_connectionString);
        }

        public int NonQuery(string command)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            int result = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return result;



        }
    }
}

