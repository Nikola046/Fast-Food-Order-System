using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodOrderSystem
{
    internal class Function
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string constr;

        public Function()
        {
            constr = @"Data Source=NN;Initial Catalog=FastFood;Integrated Security=True";
            con=new SqlConnection(constr);
            cmd=new SqlCommand();
            cmd.Connection = con;
        }

        public DataTable GetData(string querry)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(querry, constr);
            sda.Fill(dt);
            return dt;
        }

        public int setData (string Querry)
        {
            int cnt=0;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            cmd.CommandText=Querry;
            cnt=cmd.ExecuteNonQuery();
            con.Close();
            return cnt;
        }
    }
} 
