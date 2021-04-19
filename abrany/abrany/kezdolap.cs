using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace abrany
{

    public partial class kezdolap : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );
       
            
        
        public kezdolap()
        {
           /* this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));*/
            InitializeComponent();
        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bejelent_btn_Click(object sender, EventArgs e)
        {                
            this.Hide();
           login.log();
            
        }

        private void BeFelh_TextChanged(object sender, EventArgs e)
        {
            
            bejelentkezes.BekertFelh = BeFelh.Text;
        }

        private void BeJelsz_TextChanged(object sender, EventArgs e)
        {

          
           bejelentkezes.BekertJelszo = BeJelsz.Text;
        }

        private void BeAzon_TextChanged(object sender, EventArgs e)
        {
      
           bejelentkezes.BekertID = BeAzon.Text;
        }

        private void elfelejtett_Click(object sender, EventArgs e)
        {

         
            BeFelh.ResetText();
            
            BeAzon.ResetText();

            BeJelsz.ResetText();

        }

        public void kezdolap_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
