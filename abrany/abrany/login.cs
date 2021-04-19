using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace abrany
{
    
   public class login
    {
        static string azonositas = "SELECT * FROM adatok.felh_sys WHERE azonosito='" + bejelentkezes.BekertID + "';";
           
     public     static void log()
        {
      
            
            MySqlCommand SQLAzonositoParancs = new MySqlCommand(azonositas, bejelentkezes.Csatlakozas);
            MySqlDataReader SQLAzonositoOlvaso;
            bejelentkezes.Csatlakozas.Open();
            SQLAzonositoOlvaso = SQLAzonositoParancs.ExecuteReader();
           
            while (SQLAzonositoOlvaso.Read())
            {
                bejelentkezes.SQLFelh = SQLAzonositoOlvaso.GetString(0);
                bejelentkezes.SQLJelsz = SQLAzonositoOlvaso.GetString(1);
            }
            bejelentkezes.Csatlakozas.Close();
          
           
            if (string.IsNullOrEmpty(bejelentkezes.BekertFelh)|| string.IsNullOrEmpty(bejelentkezes.BekertJelszo)|| string.IsNullOrEmpty(bejelentkezes.BekertID))
            {
               
                MessageBox.Show("Kérem adja meg a helyes adatokat!");
            }
            if (!string.IsNullOrEmpty(bejelentkezes.BekertFelh)&& !string.IsNullOrEmpty(bejelentkezes.BekertJelszo)&& !string.IsNullOrEmpty(bejelentkezes.BekertID)&& bejelentkezes.BekertFelh == bejelentkezes.SQLFelh && bejelentkezes.BekertJelszo == bejelentkezes.SQLJelsz)
              {
                 
               var bejelentkez = new bejelentkezve();
                bejelentkez.Show();

               }
             else
              {
              var kezdo = new kezdolap();
              kezdo.Show();
              MessageBox.Show("Rossz adatokat adott meg, a bejelentkezés sikertelen!");
               
             }
            
            
        }
        
}
}
