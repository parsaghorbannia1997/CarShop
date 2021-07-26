using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace NamayeshgahMashin
{
  public  class foroshMadhinQuery
    {
        string connect = "server=.;database=db_NamayeshgahMashin;Integrated Security=true";
        public DataTable AllforoshMashin()
        {
            SqlConnection con = new SqlConnection(connect);
            string query = "select * from tblForoshmashin";
            SqlDataAdapter sqlData = new SqlDataAdapter(query, con);
            DataTable table = new DataTable();
            sqlData.Fill(table);
            return table;
        }
        public void insert(string commandtext,foroshMashin forosh)
        {
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand(commandtext, con);
            cmd.Parameters.AddWithValue("@IdForoshmashin", forosh.IdForoshmashin);
            cmd.Parameters.AddWithValue("@IdMasolForosh", forosh.IdMasolForosh);
            cmd.Parameters.AddWithValue("@IdMoshtari", forosh.IdMoshtari);
            cmd.Parameters.AddWithValue("@IdMashin", forosh.IdMashin);
            cmd.Parameters.AddWithValue("@Ghaimat", forosh.Ghaimat);
            cmd.Parameters.AddWithValue("@Tarikhforosh", forosh.Tarikhforosh);
            cmd.Parameters.AddWithValue("@Tozihat", forosh.Tozihat);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void edit(string commandtext,foroshMashin forosh)
        {
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand(commandtext, con);
            cmd.Parameters.AddWithValue("@IdForoshmashin", forosh.IdForoshmashin);
            cmd.Parameters.AddWithValue("@IdMasolForosh", forosh.IdMasolForosh);
            cmd.Parameters.AddWithValue("@IdMoshtari", forosh.IdMoshtari);
            cmd.Parameters.AddWithValue("@IdMashin", forosh.IdMashin);
            cmd.Parameters.AddWithValue("@Ghaimat", forosh.Ghaimat);
            cmd.Parameters.AddWithValue("@Tarikhforosh", forosh.Tarikhforosh);
            cmd.Parameters.AddWithValue("@Tozihat", forosh.Tozihat);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void delete(string commandtext,foroshMashin forosh)
        {
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand(commandtext, con);
            cmd.Parameters.AddWithValue("@IdForoshmashin", forosh.IdForoshmashin);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
