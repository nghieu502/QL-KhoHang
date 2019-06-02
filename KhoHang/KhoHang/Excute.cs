using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhoHang
{
    class Excute
    {
        private static Excute instance;
        private string connstr = @"Data Source=.\SQLEXPRESS;Initial Catalog=KhoHang;Integrated Security=True";

        public static Excute Instance
        {
            get
            {
                if (instance == null) instance = new Excute();
                return Excute.instance;
            }

            set
            {
                Excute.instance = value;
            }
        }

        public DataTable query(string command)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                try
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(command, conn);
                    SqlDataAdapter adap = new SqlDataAdapter(comm);
                    adap.Fill(data);
                    conn.Close();
                }
                catch { }
            }
            return data;
        }
        public int nonquery(string command)
        {
            int data = 0;
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                try
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(command, conn);
                    data = comm.ExecuteNonQuery();
                    conn.Close();
                }
                catch { }
            }
            return data;
        }
    }
}
