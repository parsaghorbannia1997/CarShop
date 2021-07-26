using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace NamayeshgahMashin
{
  public  class moshtariQuery
    {
        string connect ="server=.;database=db_NamayeshgahMashin;Integrated Security=true";
        public DataTable Allmoshtari()
        {
            SqlConnection con = new SqlConnection(connect);
            string query = "select * from tblMoshtari";
            SqlDataAdapter sqlData = new SqlDataAdapter(query, con);
            DataTable table = new DataTable();
            sqlData.Fill(table);
            return table;
        }
        public void insert(string commandtext,Moshtari moshtari)
        {
            SqlConnection con= new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand(commandtext, con);
            cmd.Parameters.AddWithValue("@idmoshtari", moshtari.idmoshtari);
            cmd.Parameters.AddWithValue("@firstname", moshtari.firstname);
            cmd.Parameters.AddWithValue("@lastname", moshtari.lastname);
            cmd.Parameters.AddWithValue("@mobile", moshtari.mobile);
            cmd.Parameters.AddWithValue("@address", moshtari.address);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void edit(string commandtext,Moshtari moshtari)
        {

            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand(commandtext, con);
             cmd.Parameters.AddWithValue("@idmoshtari", moshtari.idmoshtari);
            cmd.Parameters.AddWithValue("@firstname", moshtari.firstname);
            cmd.Parameters.AddWithValue("@lastname", moshtari.lastname);
            cmd.Parameters.AddWithValue("@mobile", moshtari.mobile);
            cmd.Parameters.AddWithValue("@address", moshtari.address);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void delete(string commandtext,Moshtari moshtari)
        {
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand(commandtext.ToString(), con);
            cmd.Parameters.AddWithValue("@idmoshtari", moshtari.idmoshtari);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
