using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    class databaseHandler
    {
        MySqlConnection connection;
        string tablename = "autok";
        public databaseHandler()
        {
            string username = "root";
            string password = "";
            string host = "localhost";
            string dbname = "Trabant";
          
            string connectdtring = $"username = {username};password = {password}; host = {host};database = {dbname}";
            connection = new MySqlConnection(connectdtring);
        }
        public void readaAll()
        {
            try
            {
                connection.Open();
                string querry = $"select * from {tablename}";
                MySqlCommand commnd = new MySqlCommand(querry, connection);
                MySqlDataReader read = commnd.ExecuteReader();
                while (read.Read())         
                {   
                    int id = read.GetInt32(read.GetOrdinal("id"));
                    string make = read.GetString(read.GetOrdinal("make"));
                    string model = read.GetString(read.GetOrdinal("model"));
                    string color = read.GetString(read.GetOrdinal("color"));
                    int year = read.GetInt32(read.GetOrdinal("year"));
                    int power = read.GetInt32(read.GetOrdinal("power"));
                    car onecar = new car();
                    onecar.id = id;
                    onecar.make = make;
                    onecar.model = model;
                    onecar.color = color;
                    onecar.year = year;
                    onecar.hp = power;
                    onecar.id = id;
                }
                read.Close();
                commnd.Dispose();
                connection.Close();
                MessageBox.Show("siker");
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message,"error:");
            }
        }
    }
}
