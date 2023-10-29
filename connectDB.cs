using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaiBong
{
    public class connectDB
    {
        string strConnect = @"Data Source=Laptop\sqlexpress;Initial Catalog=QLGiaiBongDa;Integrated Security=True";
        SqlConnection sqlConnect = null;


        //mo ket noi
        private void Connect()
        {
            sqlConnect = new SqlConnection(strConnect);
            if (sqlConnect.State != ConnectionState.Open)
            {
                sqlConnect.Open();
            }
        }

        //dong ket noi
        private void Disconnect()
        {
            if (sqlConnect.State != ConnectionState.Closed)
            {
                sqlConnect.Close();
            }
            sqlConnect.Dispose();
        }

        //ham thuc thi cau lenh Select
        public DataTable DocBang(string sql)
        {
            DataTable dtBang = new DataTable();
            Connect();
            SqlDataAdapter sqldataAdapter = new SqlDataAdapter(sql, sqlConnect);
            sqldataAdapter.Fill(dtBang);
            Disconnect();
            return dtBang;
        }

        //ham thuc hien insert, update, delete
        public void CapNhatDuLieu(string sql)
        {
            Connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnect;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            Disconnect();
        }


    }
}
