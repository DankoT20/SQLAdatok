using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Threading;

namespace abrany
{
    class bejelentkezes
    {
        //pP5mw2utSrlxROlj , kliens1
        public static string Kapcsolat = "datasource=localhost;port=3306;database=adatok;username=root;password=";
        public static MySqlConnection Csatlakozas = new MySqlConnection(Kapcsolat);
       public static string BekertFelh;
        public static string BekertJelszo ;
        public static string BekertNev ;
        public static string BekertID ;
        public static string SQLFelh;
         public static string SQLJelsz;
    }
}
