using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    internal class function
    {
        private SqlConnection _connection;
        private string connectionString = "Server=DESKTOP-68U66QP\\MSSQLSERVER01;Initial Catalog=QCafe;Integrated Security=True";
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            return con;
        }
        public DataSet getData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            
        }
        public SqlCommand getInstance()
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = _connection;
            return command;
        }
        public void closeInstance()
        {
            _connection.Close();
        }
    }
}
