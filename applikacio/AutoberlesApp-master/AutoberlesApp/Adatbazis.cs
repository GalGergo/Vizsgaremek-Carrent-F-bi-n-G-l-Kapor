using System;
using MySql.Data.MySqlClient;

namespace AutoberlesApp
{
    class Adatbazis
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;
        public MySqlDataReader Dr;

        public Adatbazis(string lekerdezes)
        {
            string connstring = "Server=localhost;Database=carrent;Uid=root;Pwd=;";
            conn = new MySqlConnection(connstring);
            conn.Open();
            cmd = new MySqlCommand(lekerdezes, conn);
            Dr = cmd.ExecuteReader();
        }

        public void lezaras()
        {
            Dr.Close();
            conn.Close();
        }
    }
}