using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace praktika
{
    class SQL
    {
        string SQL_CONNECTION_STRING = @"Data Source=C:\Users\Rokas\source\repos\praktika\praktika\bin\Debug\a.db;Version=3;";


        public void CreateTable()
        {
            using (var con = new SQLiteConnection(SQL_CONNECTION_STRING))
            {
                con.Open();

                using (var cmd = new SQLiteCommand(con))
                {

                    cmd.CommandText = @"CREATE TABLE ClientOrder(ClientID INTEGER , WOrder TEXT)";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"CREATE TABLE tbl_shop (Name TEXT,Image TEXT,Type TEXT,Price INTEGER,About TEXT)";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"CREATE TABLE User(Username TEXT , Password TEXT)";
                    cmd.ExecuteNonQuery();
                }
            }
        }
        void Insert()
        {
            using (var con = new SQLiteConnection(SQL_CONNECTION_STRING))
            {
                con.Open();

                using (var cmd = new SQLiteCommand(con))
                {

                    cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Audi',52642)";
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public bool userExists(string Username, string Password)
        {
            bool result = false;


            using (var con = new SQLiteConnection(SQL_CONNECTION_STRING))
            {
                con.Open();

                using (var cmd = new SQLiteCommand(con))
                {
                    cmd.CommandText = string.Format("SELECT * FROM User WHERE Username='{0}' AND Password='{1}'", Username, Password);

                    using (SQLiteDataReader sqlite_datareader = cmd.ExecuteReader())
                    {
                        while (sqlite_datareader.Read())
                            if (sqlite_datareader.GetString(0) == Username && sqlite_datareader.GetString(1) == Password)
                                result = true;
                            else
                                result = false;
                    }
                }
                return result;
            }
        }
    }
}
