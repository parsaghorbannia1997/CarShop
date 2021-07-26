using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace NamayeshgahMashin
{
   public class mashinQuery
    {
        string connect = "server=.;database=db_NamayeshgahMashin;Integrated Security=true";
        public DataTable Allmashin()
        {
            SqlConnection con = new SqlConnection(connect);
            string query = "select * from tblMashin";
            SqlDataAdapter sqlData = new SqlDataAdapter(query, con);
            DataTable table = new DataTable();
            sqlData.Fill(table);
            return table;
        }
        public void insert(string commandtext,Mashin mashin)
        {
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand(commandtext, con);
            cmd.Parameters.AddWithValue("@idmashin", mashin.idmashin);
            cmd.Parameters.AddWithValue("@nameMashin", mashin.nameMashin);
            cmd.Parameters.AddWithValue("@rangMashin", mashin.rangMashin);
            cmd.Parameters.AddWithValue("@karkhaneMashin", mashin.karkhaneMashin);
            cmd.Parameters.AddWithValue("@mahaletolid", mashin.mahaletolid);
            cmd.Parameters.AddWithValue("@tozihat", mashin.tozihat);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void delete(string commandtext,Mashin mashin)
        {
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand(commandtext, con);
            cmd.Parameters.AddWithValue("@idmashin", mashin.idmashin);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void edit(string commandtext,Mashin mashin)
        {
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand(commandtext, con);
            cmd.Parameters.AddWithValue("@idmashin", mashin.idmashin);
            cmd.Parameters.AddWithValue("@nameMashin", mashin.nameMashin);
            cmd.Parameters.AddWithValue("@rangMashin", mashin.rangMashin);
            cmd.Parameters.AddWithValue("@karkhaneMashin", mashin.karkhaneMashin);
            cmd.Parameters.AddWithValue("@mahaletolid", mashin.mahaletolid);
            cmd.Parameters.AddWithValue("@tozihat", mashin.tozihat);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

       
      
    }
}
