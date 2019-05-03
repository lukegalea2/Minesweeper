using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Minesweeper_test
{
    public class UserInput
    {
        public Grid getInput()
        {
           
            int m = 0;
            int n = 0;
           
            Console.WriteLine("Input Number of Rows: ");
            m = int.Parse(Console.ReadLine());

            Console.WriteLine("Input Number of Colomns: ");
             n = int.Parse(Console.ReadLine());

            Grid g = new Grid(m, n);

            return g;

            string connectionString = @"server=DESKTOP-TCAVO60\\SQLEXPRESS; userid=DESKTOP-TCAVO60\\Dell;password =;database=Minesweeper";

            MySqlConnection connection = null;

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO Entries (GameRows, GameColoumns) VALUES (@row, @coloumn)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@row", m);
                cmd.Parameters.AddWithValue("@coloumn", n);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

        }
    }
}
