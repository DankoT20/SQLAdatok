
namespace abrany
{
    partial class bejelentkezve
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.keresendo_nev = new System.Windows.Forms.Label();
            this.bal_szin = new System.Windows.Forms.Panel();
            this.x2 = new System.Windows.Forms.Button();
            this.friss_btn = new System.Windows.Forms.Button();
            this.kereses = new System.Windows.Forms.Button();
            this.keresendoNev = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.keresesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bal_szin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keresesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // keresendo_nev
            // 
            this.keresendo_nev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.keresendo_nev.CausesValidation = false;
            this.keresendo_nev.Enabled = false;
            this.keresendo_nev.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.keresendo_nev.Location = new System.Drawing.Point(3, 58);
            this.keresendo_nev.Name = "keresendo_nev";
            this.keresendo_nev.Size = new System.Drawing.Size(250, 96);
            this.keresendo_nev.TabIndex = 0;
            this.keresendo_nev.Text = "Kérem adja meg a keresendő nevet!";
            this.keresendo_nev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.keresendo_nev.Click += new System.EventHandler(this.keresendo_nev_Click);
            // 
            // bal_szin
            // 
            this.bal_szin.BackColor = System.Drawing.Color.PowderBlue;
            this.bal_szin.Controls.Add(this.x2);
            this.bal_szin.Controls.Add(this.friss_btn);
            this.bal_szin.Controls.Add(this.kereses);
            this.bal_szin.Controls.Add(this.keresendoNev);
            this.bal_szin.Controls.Add(this.keresendo_nev);
            this.bal_szin.Location = new System.Drawing.Point(1, 1);
            this.bal_szin.Name = "bal_szin";
            this.bal_szin.Size = new System.Drawing.Size(257, 449);
            this.bal_szin.TabIndex = 1;
            // 
            // x2
            // 
            this.x2.BackColor = System.Drawing.SystemColors.Info;
            this.x2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.x2.FlatAppearance.BorderSize = 0;
            this.x2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.x2.Location = new System.Drawing.Point(3, 3);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(27, 31);
            this.x2.TabIndex = 5;
            this.x2.Text = "X";
            this.x2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.x2.UseVisualStyleBackColor = false;
            this.x2.Click += new System.EventHandler(this.X_Click);
            // 
            // friss_btn
            // 
            this.friss_btn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.friss_btn.Location = new System.Drawing.Point(3, 423);
            this.friss_btn.Name = "friss_btn";
            this.friss_btn.Size = new System.Drawing.Size(75, 23);
            this.friss_btn.TabIndex = 4;
            this.friss_btn.Text = "Frissítés";
            this.friss_btn.UseVisualStyleBackColor = false;
            this.friss_btn.Click += new System.EventHandler(this.friss_btn_Click);
            // 
            // kereses
            // 
            this.kereses.BackColor = System.Drawing.Color.Aquamarine;
            this.kereses.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kereses.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kereses.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kereses.Location = new System.Drawing.Point(88, 177);
            this.kereses.Name = "kereses";
            this.kereses.Size = new System.Drawing.Size(80, 23);
            this.kereses.TabIndex = 2;
            this.kereses.Text = "Keresés";
            this.kereses.UseVisualStyleBackColor = false;
            this.kereses.Click += new System.EventHandler(this.kereses_Click);
            // 
            // keresendoNev
            // 
            this.keresendoNev.Location = new System.Drawing.Point(50, 151);
            this.keresendoNev.Name = "keresendoNev";
            this.keresendoNev.Size = new System.Drawing.Size(157, 20);
            this.keresendoNev.TabIndex = 1;
            this.keresendoNev.TextChanged += new System.EventHandler(this.keresendoNev_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.OldLace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(260, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(541, 449);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // keresesBindingSource
            // 
            this.keresesBindingSource.DataSource = typeof(abrany.SQLkereses);
            // 
            // bejelentkezve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bal_szin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bejelentkezve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.bejelentkezve_Load);
            this.bal_szin.ResumeLayout(false);
            this.bal_szin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keresesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label keresendo_nev;
        private System.Windows.Forms.Panel bal_szin;
        private System.Windows.Forms.TextBox keresendoNev;
        private System.Windows.Forms.Button kereses;
        private System.Windows.Forms.BindingSource keresesBindingSource;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button friss_btn;
        private System.Windows.Forms.Button x2;
    }
}