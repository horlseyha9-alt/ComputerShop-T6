using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace ComputerShop_Team6.Controller
{
    internal class ControllerSupplier : Model.ModelSupplier
    {
        // Insert Supplier
        public void InsertSupplier()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = DbConnection.GetSqlConnection();
                cmd.CommandText = "InsertSupplier";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 100).Value = CompanyName;
                cmd.Parameters.Add("@SupplierName", SqlDbType.NVarChar, 100).Value = SupplierName;
                cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = DOB;
                cmd.Parameters.Add("@POB", SqlDbType.NVarChar, 255).Value = (object)POB ?? DBNull.Value;
                cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 255).Value = (object)Address ?? DBNull.Value;
                cmd.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar, 50).Value = PhoneNumber;
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
            string sql = "select * from tblSupplier;";   // ប្តូរទៅ V_Supplier បើអ្នកមាន View
            SqlCommand cmd = new SqlCommand(sql, DbConnection.GetSqlConnection());
            adapter.SelectCommand = cmd;
            ds.Clear();
            adapter.Fill(ds);
            dt = ds.Tables[0];
        }
        //Update Supplier
        public void UpdateSupplier()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = DbConnection.GetSqlConnection();
                cmd.CommandText = "UpdateSupplier";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierId", SqlDbType.Int).Value = SupplierID;
                cmd.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 100).Value = CompanyName;
                cmd.Parameters.Add("@SupplierName", SqlDbType.NVarChar, 100).Value = SupplierName;
                cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = DOB;
                cmd.Parameters.Add("@POB", SqlDbType.NVarChar, 255).Value = (object)POB ?? DBNull.Value;
                cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 255).Value = (object)Address ?? DBNull.Value;
                cmd.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar, 50).Value = PhoneNumber;

                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }
        //Delete Supplier
        public void DeleteSupplier()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = DbConnection.GetSqlConnection();
                cmd.CommandText = "DeleteSupplier";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@SupplierId", SqlDbType.Int).Value = SupplierID;

                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }

    }
}