
namespace abrany
{
    partial class kezdolap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.udv = new System.Windows.Forms.Label();
            this.kerem_ad = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Button();
            this.BeFelh = new System.Windows.Forms.TextBox();
            this.BeJelsz = new System.Windows.Forms.TextBox();
            this.BeAzon = new System.Windows.Forms.TextBox();
            this.bejelent_btn = new System.Windows.Forms.Button();
            this.elfelejtett = new System.Windows.Forms.Button();
            this.id_kep = new System.Windows.Forms.PictureBox();
            this.password_kep = new System.Windows.Forms.PictureBox();
            this.felh_kep = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.id_kep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_kep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.felh_kep)).BeginInit();
            this.SuspendLayout();
            // 
            // udv
            // 
            this.udv.AutoSize = true;
            this.udv.BackColor = System.Drawing.Color.PowderBlue;
            this.udv.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.udv.ForeColor = System.Drawing.SystemColors.MenuText;
            this.udv.Location = new System.Drawing.Point(271, 41);
            this.udv.Name = "udv";
            this.udv.Size = new System.Drawing.Size(194, 42);
            this.udv.TabIndex = 0;
            this.udv.Text = "Üdvözlöm!";
            // 
            // kerem_ad
            // 
            this.kerem_ad.AutoSize = true;
            this.kerem_ad.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kerem_ad.ForeColor = System.Drawing.SystemColors.MenuText;
            this.kerem_ad.Location = new System.Drawing.Point(111, 94);
            this.kerem_ad.Name = "kerem_ad";
            this.kerem_ad.Size = new System.Drawing.Size(571, 24);
            this.kerem_ad.TabIndex = 1;
            this.kerem_ad.Text = "Kérem adja meg az azonosításhoz szükséges adatokat!";
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.SystemColors.Info;
            this.X.Cursor = System.Windows.Forms.Cursors.Hand;
            this.X.FlatAppearance.BorderSize = 0;
            this.X.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.X.Location = new System.Drawing.Point(12, 12);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(27, 31);
            this.X.TabIndex = 2;
            this.X.Text = "X";
            this.X.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.X.UseVisualStyleBackColor = false;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // BeFelh
            // 
            this.BeFelh.Location = new System.Drawing.Point(241, 148);
            this.BeFelh.Name = "BeFelh";
            this.BeFelh.Size = new System.Drawing.Size(272, 20);
            this.BeFelh.TabIndex = 3;
            this.BeFelh.TextChanged += new System.EventHandler(this.BeFelh_TextChanged);
            // 
            // BeJelsz
            // 
            this.BeJelsz.Location = new System.Drawing.Point(241, 198);
            this.BeJelsz.Name = "BeJelsz";
            this.BeJelsz.PasswordChar = '*';
            this.BeJelsz.Size = new System.Drawing.Size(272, 20);
            this.BeJelsz.TabIndex = 4;
            this.BeJelsz.TextChanged += new System.EventHandler(this.BeJelsz_TextChanged);
            // 
            // BeAzon
            // 
            this.BeAzon.Location = new System.Drawing.Point(241, 247);
            this.BeAzon.Name = "BeAzon";
            this.BeAzon.Size = new System.Drawing.Size(272, 20);
            this.BeAzon.TabIndex = 5;
            this.BeAzon.TextChanged += new System.EventHandler(this.BeAzon_TextChanged);
            // 
            // bejelent_btn
            // 
            this.bejelent_btn.BackColor = System.Drawing.Color.Aquamarine;
            this.bejelent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bejelent_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bejelent_btn.Location = new System.Drawing.Point(241, 301);
            this.bejelent_btn.Margin = new System.Windows.Forms.Padding(0);
            this.bejelent_btn.Name = "bejelent_btn";
            this.bejelent_btn.Size = new System.Drawing.Size(102, 30);
            this.bejelent_btn.TabIndex = 6;
            this.bejelent_btn.Text = "Bejelentkezés";
            this.bejelent_btn.UseVisualStyleBackColor = false;
            this.bejelent_btn.Click += new System.EventHandler(this.bejelent_btn_Click);
            // 
            // elfelejtett
            // 
            this.elfelejtett.BackColor = System.Drawing.Color.LightCyan;
            this.elfelejtett.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.elfelejtett.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.elfelejtett.Location = new System.Drawing.Point(389, 301);
            this.elfelejtett.Name = "elfelejtett";
            this.elfelejtett.Size = new System.Drawing.Size(124, 30);
            this.elfelejtett.TabIndex = 7;
            this.elfelejtett.Text = "Reset";
            this.elfelejtett.UseVisualStyleBackColor = false;
            this.elfelejtett.Click += new System.EventHandler(this.elfelejtett_Click);
            // 
            // id_kep
            // 
            this.id_kep.Image = global::abrany.Properties.Resources.id;
            this.id_kep.Location = new System.Drawing.Point(211, 243);
            this.id_kep.Name = "id_kep";
            this.id_kep.Size = new System.Drawing.Size(24, 24);
            this.id_kep.TabIndex = 10;
            this.id_kep.TabStop = false;
            this.id_kep.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // password_kep
            // 
            this.password_kep.Image = global::abrany.Properties.Resources.password_icon_kesz;
            this.password_kep.Location = new System.Drawing.Point(211, 194);
            this.password_kep.Name = "password_kep";
            this.password_kep.Size = new System.Drawing.Size(24, 24);
            this.password_kep.TabIndex = 9;
            this.password_kep.TabStop = false;
            // 
            // felh_kep
            // 
            this.felh_kep.Image = global::abrany.Properties.Resources.user_icon_kesz;
            this.felh_kep.Location = new System.Drawing.Point(211, 144);
            this.felh_kep.Name = "felh_kep";
            this.felh_kep.Size = new System.Drawing.Size(24, 24);
            this.felh_kep.TabIndex = 8;
            this.felh_kep.TabStop = false;
            // 
            // kezdolap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.id_kep);
            this.Controls.Add(this.password_kep);
            this.Controls.Add(this.felh_kep);
            this.Controls.Add(this.elfelejtett);
            this.Controls.Add(this.bejelent_btn);
            this.Controls.Add(this.BeAzon);
            this.Controls.Add(this.BeJelsz);
            this.Controls.Add(this.BeFelh);
            this.Controls.Add(this.X);
            this.Controls.Add(this.kerem_ad);
            this.Controls.Add(this.udv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kezdolap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kezdőlap";
            this.Load += new System.EventHandler(this.kezdolap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.id_kep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_kep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.felh_kep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label udv;
        private System.Windows.Forms.Label kerem_ad;
        private System.Windows.Forms.TextBox BeFelh;
        private System.Windows.Forms.TextBox BeJelsz;
        private System.Windows.Forms.TextBox BeAzon;
        private System.Windows.Forms.Button bejelent_btn;
        private System.Windows.Forms.Button elfelejtett;
        private System.Windows.Forms.PictureBox felh_kep;
        private System.Windows.Forms.PictureBox password_kep;
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.PictureBox id_kep;
    }
}

