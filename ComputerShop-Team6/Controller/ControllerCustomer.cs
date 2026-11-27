using System;
using System.Data;
using System.Data.SqlClient;

namespace ComputerShop_Team6.Controller
{
    internal class ControllerCustomer : Model.ModelCustomer
    {
        //Insert Customer
        public void InsertCustomer()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = DbConnection.GetSqlConnection();
                cmd.CommandText = "InsertCustomer";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerName", SqlDbType.NVarChar, 100).Value = CustomerName;
                cmd.Parameters.Add("@Phone", SqlDbType.NVarChar, 50).Value = (object)Phone ?? DBNull.Value;
                cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 250).Value = (object)Address ?? DBNull.Value;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 100).Value = (object)Email ?? DBNull.Value;

                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }
        //Update Customer
        public void UpdateCustomer()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = DbConnection.GetSqlConnection();
                cmd.CommandText = "UpdateCustomer";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerId", SqlDbType.Int).Value = CustomerID;
                cmd.Parameters.Add("@CustomerName", SqlDbType.NVarChar, 100).Value = CustomerName;
                cmd.Parameters.Add("@Phone", SqlDbType.NVarChar, 50).Value = (object)Phone ?? DBNull.Value;
                cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 250).Value = (object)Address ?? DBNull.Value;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 100).Value = (object)Email ?? DBNull.Value;

                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }
        //Delete Customer
        public void DeleteCustomer()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = DbConnection.GetSqlConnection();
                cmd.CommandText = "DeleteCustomer";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerId", SqlDbType.Int).Value = CustomerID;

                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }
        //View Data
        public DataTable dt = new DataTable();
        public DataSet ds = new DataSet();
        public SqlDataAdapter adapter = new SqlDataAdapter();

        public void ViewData()
        {
            string sql = "select * from tblCustomer;";
            SqlCommand cmd = new SqlCommand(sql, DbConnection.GetSqlConnection());
            adapter.SelectCommand = cmd;
            ds.Clear();
            adapter.Fill(ds);
            dt = ds.Tables[0];
        }
    }
}