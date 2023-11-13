using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DataKaryawan
{
    class Koneksi
    {
        string constr = "Server=localhost;Database=belajar1;Uid=root;Pwd=;";
        MySqlConnection con;

        public void openConnection()
        {
            con = new MySqlConnection(constr);
            con.Open();
        }

        public void closeConnection()
        {
            con.Close();
        }

        public void executeQuery(string query)
        {
            MySqlCommand command = new MySqlCommand(query, con);
            command.ExecuteNonQuery();
        }

        public object ShowData(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, constr);
            DataSet data = new DataSet();

            adapter.Fill(data);
            object bebas = data.Tables[0];
            return bebas;
        }

    }
}
