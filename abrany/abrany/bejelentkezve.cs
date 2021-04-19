using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace abrany
{
    public partial class bejelentkezve : Form
    {
        public bejelentkezve()
        {
            InitializeComponent();
        }

        private void keresendo_nev_Click(object sender, EventArgs e)
        {

        }

        private void bejelentkezve_Load(object sender, EventArgs e)
        {

        }

        private void keresendoNev_TextChanged(object sender, EventArgs e)
        {
            bejelentkezes.BekertNev = keresendoNev.Text;
        }

        private void kereses_Click(object sender, EventArgs e)
        {
             string SQLDBcom = "SELECT * FROM adatok.adat WHERE Név='" + bejelentkezes.BekertNev + "';";
            
            MySqlCommand SQLDBParancs = new MySqlCommand(SQLDBcom, bejelentkezes.Csatlakozas);
            bejelentkezes.Csatlakozas.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(SQLDBParancs);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           
            dataGridView1.Columns[1].DefaultCellStyle.BackColor = Color.Red;

             bejelentkezes.Csatlakozas.Close();
           
          
            
        }

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void XBejelent_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

     private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private static void hid()
        {
            
        }
        private void friss_btn_Click(object sender, EventArgs e)
        {
            frissites.aut_friss();
        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
