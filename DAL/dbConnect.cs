using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
   public class dbConnect
    {
        private SqlConnection conn;
        public dbConnect()
        {
            conn = new SqlConnection("Data Source=LAPTOP-QK799FFN\\SQLEXPRESS;Initial Catalog=QLKS; Integrated Security = True;");
        }
        public DataTable getDataTable(String strSQL)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);
            conn.Open();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable getData(string procName,SqlParameter[] para)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = procName;
            cmd.CommandType = CommandType.StoredProcedure;
            if(para!=null)
                cmd.Parameters.AddRange(para);
            cmd.Connection =conn;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            conn.Open();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public int ExcuteSQl(string strSQL)
        {
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            int row = cmd.ExecuteNonQuery();
            conn.Close();
            return row;
        }
        public int ExcuteSQL(string procName , SqlParameter[] para)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = procName;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                if (para != null)
                    cmd.Parameters.AddRange(para);
                conn.Open();
                int row = cmd.ExecuteNonQuery();
                return row;
            }
            catch (Exception ex)
            {
                return 0; // Hoặc giá trị khác để biểu thị lỗi
            }
            finally
            {
                conn.Close();
            }
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = procName;
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Connection = conn;
            //if (para != null)
            //    cmd.Parameters.AddRange(para);
            //conn.Open();
            //int row = cmd.ExecuteNonQuery();
            //conn.Close();
            //return row;
        }
        public int GetParamsExcuteSQL(string procName, SqlParameter[] para)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = procName;
            cmd.CommandType = CommandType.StoredProcedure;
            if (para != null)
                cmd.Parameters.AddRange(para);
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            conn.Open();
            da.Fill(dt);
            conn.Close();
            int id = 0;
            foreach(DataRow row in dt.Rows)
            {
                id = Convert.ToInt32( row[0].ToString());
            }
            return id;

        }
    }
}
