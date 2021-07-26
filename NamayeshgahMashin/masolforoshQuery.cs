using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace NamayeshgahMashin
{
  public  class masolforoshQuery
    {
      string connect = "server=.;database=db_NamayeshgahMashin;Integrated Security=true";
        public DataTable Allmasolforosh()
        {
            string query = "select * from tblMasolforosh";
            SqlConnection con = new SqlConnection(connect);
            SqlDataAdapter sqlData = new SqlDataAdapter(query, con);
            DataTable table = new DataTable();
            sqlData.Fill(table);
            return table;
        }
        public void insert(string commandtext,Masolforosh masolforosh)
        {
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand(commandtext, con);
            cmd.Parameters.AddWithValue("@idmasolforosh", masolforosh.idmasolforosh);
            cmd.Parameters.AddWithValue("@firstname", masolforosh.firstname);
            cmd.Parameters.AddWithValue("@lastname", masolforosh.lastname);
            cmd.Parameters.AddWithValue("@mobile", masolforosh.mobile);
            cmd.Parameters.AddWithValue("@adress", masolforosh.address);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void delete(string commandtext,Masolforosh masolforosh)
        {
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand(commandtext, con);
            cmd.Parameters.AddWithValue("@idmasolforosh", masolforosh.idmasolforosh);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void edit(string commandtext, Masolforosh masolforosh)
        {
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand(commandtext, con);
            cmd.Parameters.AddWithValue("@idmasolforosh", masolforosh.idmasolforosh);
            cmd.Parameters.AddWithValue("@firstname", masolforosh.firstname);
            cmd.Parameters.AddWithValue("@lastname", masolforosh.lastname);
            cmd.Parameters.AddWithValue("@mobile", masolforosh.mobile);
            cmd.Parameters.AddWithValue("@adress", masolforosh.address);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
