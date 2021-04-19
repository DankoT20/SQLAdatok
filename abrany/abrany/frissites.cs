using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Threading;
namespace abrany
{
   public  class frissites
    {
       public static void aut_friss()
        {
            try
            {

                string nap = "";
                nap = DateTime.Now.ToString("yyy.MM.dd");
                
                List<string> Sorszamok = new List<string>();
                Sorszamok.Clear();

                string lekerdezes = "SELECT `Sorszám` FROM `adat` WHERE `Vég`='" + nap + "';";
                MySqlCommand sorszamlekerdezes = new MySqlCommand(lekerdezes, bejelentkezes.Csatlakozas);
                MySqlDataReader lekerdezesOlvaso;
                bejelentkezes.Csatlakozas.Open();
                lekerdezesOlvaso = sorszamlekerdezes.ExecuteReader();

                while (lekerdezesOlvaso.Read())
                {
                    Sorszamok.Add(lekerdezesOlvaso.GetString(0));
                }
                bejelentkezes.Csatlakozas.Close();
                List<string> parancsok = new List<string>();

                for (int i = 0; i < Sorszamok.Count; i++)
                {
                    parancsok.Add("delete from adatok.adat where Sorszám = '" + Sorszamok[i] + "'; ");
                   
                }

                for (int i = 0; i < Sorszamok.Count; i++)
                {
                    for (int j = 0; j < parancsok.Count; j++)
                    {
                        MySqlCommand KAR = new MySqlCommand(parancsok[j], bejelentkezes.Csatlakozas);
                        MySqlDataReader KarOlvaso;
                        bejelentkezes.Csatlakozas.Open();
                        KarOlvaso = KAR.ExecuteReader();
                        /*while (KarOlvaso.Read())
                        {
                        }*/

                        bejelentkezes.Csatlakozas.Close();
                    }
                }

                parancsok.Clear();
            }
            catch (Exception)
            {
              
            }

        }
    }
}
