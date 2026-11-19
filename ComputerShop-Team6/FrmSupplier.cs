using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShop_Team6.Controller
{
    internal class ControllerSupplier : Model.ModelSupplier
    {
        //Insert Supplier
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
                    cmd.Connection.Open();

                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        } // ← បិទ InsertSupplier

        //View Data
        public DataTable dt = new DataTable();
        public DataSet ds = new DataSet();
        public SqlDataAdapter adapter = new SqlDataAdapter();

        public void ViewData()
        {
            string sql = "select * from V_Supplier;";
            SqlCommand cmd = new SqlCommand(sql, DbConnection.GetSqlConnection());
            adapter.SelectCommand = cmd;
            ds.Clear();
            adapter.Fill(ds);
            dt = ds.Tables[0];
        }

    } // ← បិទ class
} // ← បិទ namespace