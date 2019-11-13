using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace praktika
{
  class DataBase
    {
        public SQLiteConnection myConnection;

        public DataBase()
        {
            myConnection = new SQLiteConnection("Data Source=ProjektinisDb.db");
            if (File.Exists("./ProjektinisDB.db"))

            {
                SQLiteConnection.CreateFile("ProjektinisDB.db");
            }
        }
    }


}
