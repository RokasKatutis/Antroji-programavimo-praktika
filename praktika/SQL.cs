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

                    cmd.CommandText = @"CREATE TABLE ClientOrder(Name TEXT, Surname TEXT, Phone INT, Adress TEXT, WOrder TEXT)";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"CREATE TABLE tbl_shop (Name TEXT,Image TEXT,Type TEXT,Price INTEGER,About TEXT)";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"CREATE TABLE User(Username TEXT , Password TEXT)";
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

        public List<Product> GetProducts()
        {
            List<Product> p = new List<Product>();
            using (var con = new SQLiteConnection(SQL_CONNECTION_STRING))
            {
                con.Open();

                using (var cmd = new SQLiteCommand(con))
                {
                    cmd.CommandText = string.Format("SELECT * FROM tbl_shop");

                    using (SQLiteDataReader sqlite_datareader = cmd.ExecuteReader())
                    {
                        while (sqlite_datareader.Read())
                        {
                            Product _Product = new Product();
                            _Product.SetName(sqlite_datareader.GetString(0));
                            _Product.SetPhoto(sqlite_datareader.GetString(1));
                            _Product.SetTipas(sqlite_datareader.GetString(2));
                            _Product.SetPrice(sqlite_datareader.GetInt32(3));
                            _Product.SetDescription(sqlite_datareader.GetString(4));

                            p.Add(_Product);
                        }


                    }
                }
                return p;
            }
        }
        #region insert
        public void InsertUser(string Username, string Password)
        {
            using (var con = new SQLiteConnection(SQL_CONNECTION_STRING))
            {
                con.Open();

                using (var cmd = new SQLiteCommand(con))
                {

                    cmd.CommandText = string.Format("INSERT INTO User(Username, Password) VALUES('{0}','{1}')", Username, Password);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void InsertProduct(string Pavadinimas, int Tipas, string Nuotrauka, int Kaina, string Aprasymas)
        {
            string tipas = "";
            if (Tipas == 0)
                tipas = "Speakers";
            else if (Tipas == 1)
                tipas = "Microphone";
            else if (Tipas == 2)
                tipas = "Headphones";

            using (var con = new SQLiteConnection(SQL_CONNECTION_STRING))
            {
                con.Open();

                using (var cmd = new SQLiteCommand(con))
                {

                    cmd.CommandText = string.Format("INSERT INTO tbl_shop(Name,Image,Type,Price,About) VALUES('{0}','{1}','{2}','{3}','{4}')", Pavadinimas, Nuotrauka, tipas, Kaina, Aprasymas);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void InsertOrder(string Name, string Surname, string Phone, string Address, List<Basket> B)
        {
            string orderString = "";

            for (int i = 0; i < B.Count; i++)
                orderString += B[i].getID().ToString() + "|";

            orderString = orderString.Remove(orderString.Length - 1);


            using (var con = new SQLiteConnection(SQL_CONNECTION_STRING))
            {
                con.Open();

                using (var cmd = new SQLiteCommand(con))
                {
                    cmd.CommandText = string.Format("INSERT INTO ClientOrder(Name,Surname,Phone,Adress,WOrder) VALUES('{0}','{1}','{2}','{3}','{4}')", Name, Surname, Phone, Address, orderString);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        #endregion
    }
}
