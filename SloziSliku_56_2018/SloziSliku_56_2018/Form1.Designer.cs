
namespace SloziSliku_56_2018
{
    partial class Form1
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
            this.btn_ucitajSliku = new System.Windows.Forms.Button();
            this.btn_novaIgra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_odigraniPotezi = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vrsta5 = new System.Windows.Forms.RadioButton();
            this.vrsta4 = new System.Windows.Forms.RadioButton();
            this.vrsta3 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kolona5 = new System.Windows.Forms.RadioButton();
            this.kolona4 = new System.Windows.Forms.RadioButton();
            this.kolona3 = new System.Windows.Forms.RadioButton();
            this.btn_bojaLinija = new System.Windows.Forms.Button();
            this.btn_Kraj = new System.Windows.Forms.Button();
            this.lbl_nazivSlike = new System.Windows.Forms.Label();
            this.btn_sacuvaj = new System.Windows.Forms.Button();
            this.btn_otvori = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_unesiIme = new System.Windows.Forms.TextBox();
            this.btn_prikaziRezultate = new System.Windows.Forms.Button();
            this.btn_upisiIme = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ucitajSliku
            // 
            this.btn_ucitajSliku.Location = new System.Drawing.Point(938, 26);
            this.btn_ucitajSliku.Name = "btn_ucitajSliku";
            this.btn_ucitajSliku.Size = new System.Drawing.Size(101, 28);
            this.btn_ucitajSliku.TabIndex = 0;
            this.btn_ucitajSliku.Text = "Ucitaj sliku";
            this.btn_ucitajSliku.UseVisualStyleBackColor = true;
            this.btn_ucitajSliku.Click += new System.EventHandler(this.btn_ucitajSliku_Click);
            // 
            // btn_novaIgra
            // 
            this.btn_novaIgra.Location = new System.Drawing.Point(939, 88);
            this.btn_novaIgra.Name = "btn_novaIgra";
            this.btn_novaIgra.Size = new System.Drawing.Size(101, 28);
            this.btn_novaIgra.TabIndex = 1;
            this.btn_novaIgra.Text = "Nova igra";
            this.btn_novaIgra.UseVisualStyleBackColor = true;
            this.btn_novaIgra.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(936, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Poteza:";
            // 
            // lbl_odigraniPotezi
            // 
            this.lbl_odigraniPotezi.AutoSize = true;
            this.lbl_odigraniPotezi.Location = new System.Drawing.Point(998, 132);
            this.lbl_odigraniPotezi.Name = "lbl_odigraniPotezi";
            this.lbl_odigraniPotezi.Size = new System.Drawing.Size(16, 17);
            this.lbl_odigraniPotezi.TabIndex = 3;
            this.lbl_odigraniPotezi.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vrsta5);
            this.groupBox1.Controls.Add(this.vrsta4);
            this.groupBox1.Controls.Add(this.vrsta3);
            this.groupBox1.Location = new System.Drawing.Point(939, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 143);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Broj vrsta:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // vrsta5
            // 
            this.vrsta5.AutoSize = true;
            this.vrsta5.Location = new System.Drawing.Point(30, 116);
            this.vrsta5.Name = "vrsta5";
            this.vrsta5.Size = new System.Drawing.Size(37, 21);
            this.vrsta5.TabIndex = 2;
            this.vrsta5.TabStop = true;
            this.vrsta5.Text = "5";
            this.vrsta5.UseVisualStyleBackColor = true;
            this.vrsta5.CheckedChanged += new System.EventHandler(this.vrsta5_CheckedChanged);
            // 
            // vrsta4
            // 
            this.vrsta4.AutoSize = true;
            this.vrsta4.Location = new System.Drawing.Point(30, 77);
            this.vrsta4.Name = "vrsta4";
            this.vrsta4.Size = new System.Drawing.Size(37, 21);
            this.vrsta4.TabIndex = 1;
            this.vrsta4.TabStop = true;
            this.vrsta4.Text = "4";
            this.vrsta4.UseVisualStyleBackColor = true;
            this.vrsta4.CheckedChanged += new System.EventHandler(this.vrsta4_CheckedChanged);
            // 
            // vrsta3
            // 
            this.vrsta3.AutoSize = true;
            this.vrsta3.Location = new System.Drawing.Point(30, 37);
            this.vrsta3.Name = "vrsta3";
            this.vrsta3.Size = new System.Drawing.Size(37, 21);
            this.vrsta3.TabIndex = 0;
            this.vrsta3.TabStop = true;
            this.vrsta3.Text = "3";
            this.vrsta3.UseVisualStyleBackColor = true;
            this.vrsta3.CheckedChanged += new System.EventHandler(this.vrsta3_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kolona5);
            this.groupBox2.Controls.Add(this.kolona4);
            this.groupBox2.Controls.Add(this.kolona3);
            this.groupBox2.Location = new System.Drawing.Point(939, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(101, 143);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Broj kolona:";
            // 
            // kolona5
            // 
            this.kolona5.AutoSize = true;
            this.kolona5.Location = new System.Drawing.Point(30, 114);
            this.kolona5.Name = "kolona5";
            this.kolona5.Size = new System.Drawing.Size(37, 21);
            this.kolona5.TabIndex = 2;
            this.kolona5.TabStop = true;
            this.kolona5.Text = "5";
            this.kolona5.UseVisualStyleBackColor = true;
            this.kolona5.CheckedChanged += new System.EventHandler(this.kolona5_CheckedChanged);
            // 
            // kolona4
            // 
            this.kolona4.AutoSize = true;
            this.kolona4.Location = new System.Drawing.Point(30, 73);
            this.kolona4.Name = "kolona4";
            this.kolona4.Size = new System.Drawing.Size(37, 21);
            this.kolona4.TabIndex = 1;
            this.kolona4.TabStop = true;
            this.kolona4.Text = "4";
            this.kolona4.UseVisualStyleBackColor = true;
            this.kolona4.CheckedChanged += new System.EventHandler(this.kolona4_CheckedChanged);
            // 
            // kolona3
            // 
            this.kolona3.AutoSize = true;
            this.kolona3.Location = new System.Drawing.Point(30, 37);
            this.kolona3.Name = "kolona3";
            this.kolona3.Size = new System.Drawing.Size(37, 21);
            this.kolona3.TabIndex = 0;
            this.kolona3.TabStop = true;
            this.kolona3.Text = "3";
            this.kolona3.UseVisualStyleBackColor = true;
            this.kolona3.CheckedChanged += new System.EventHandler(this.kolona3_CheckedChanged);
            // 
            // btn_bojaLinija
            // 
            this.btn_bojaLinija.Location = new System.Drawing.Point(939, 468);
            this.btn_bojaLinija.Name = "btn_bojaLinija";
            this.btn_bojaLinija.Size = new System.Drawing.Size(101, 28);
            this.btn_bojaLinija.TabIndex = 6;
            this.btn_bojaLinija.Text = "Boja linija";
            this.btn_bojaLinija.UseVisualStyleBackColor = true;
            this.btn_bojaLinija.Click += new System.EventHandler(this.btn_bojaLinija_Click);
            // 
            // btn_Kraj
            // 
            this.btn_Kraj.Location = new System.Drawing.Point(939, 791);
            this.btn_Kraj.Name = "btn_Kraj";
            this.btn_Kraj.Size = new System.Drawing.Size(101, 29);
            this.btn_Kraj.TabIndex = 7;
            this.btn_Kraj.Text = "Kraj";
            this.btn_Kraj.UseVisualStyleBackColor = true;
            this.btn_Kraj.Click += new System.EventHandler(this.btn_Kraj_Click);
            // 
            // lbl_nazivSlike
            // 
            this.lbl_nazivSlike.AutoSize = true;
            this.lbl_nazivSlike.Location = new System.Drawing.Point(943, 64);
            this.lbl_nazivSlike.Name = "lbl_nazivSlike";
            this.lbl_nazivSlike.Size = new System.Drawing.Size(0, 17);
            this.lbl_nazivSlike.TabIndex = 8;
            // 
            // btn_sacuvaj
            // 
            this.btn_sacuvaj.Location = new System.Drawing.Point(939, 514);
            this.btn_sacuvaj.Name = "btn_sacuvaj";
            this.btn_sacuvaj.Size = new System.Drawing.Size(101, 28);
            this.btn_sacuvaj.TabIndex = 9;
            this.btn_sacuvaj.Text = "Sacuvaj";
            this.btn_sacuvaj.UseVisualStyleBackColor = true;
            this.btn_sacuvaj.Click += new System.EventHandler(this.btn_sacuvaj_Click);
            // 
            // btn_otvori
            // 
            this.btn_otvori.Location = new System.Drawing.Point(939, 561);
            this.btn_otvori.Name = "btn_otvori";
            this.btn_otvori.Size = new System.Drawing.Size(101, 28);
            this.btn_otvori.TabIndex = 10;
            this.btn_otvori.Text = "Otvori";
            this.btn_otvori.UseVisualStyleBackColor = true;
            this.btn_otvori.Click += new System.EventHandler(this.btn_otvori_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(938, 605);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Unesi svoje ime:";
            // 
            // lbl_unesiIme
            // 
            this.lbl_unesiIme.Location = new System.Drawing.Point(939, 632);
            this.lbl_unesiIme.Name = "lbl_unesiIme";
            this.lbl_unesiIme.Size = new System.Drawing.Size(101, 22);
            this.lbl_unesiIme.TabIndex = 12;
            // 
            // btn_prikaziRezultate
            // 
            this.btn_prikaziRezultate.Location = new System.Drawing.Point(941, 720);
            this.btn_prikaziRezultate.Name = "btn_prikaziRezultate";
            this.btn_prikaziRezultate.Size = new System.Drawing.Size(101, 47);
            this.btn_prikaziRezultate.TabIndex = 13;
            this.btn_prikaziRezultate.Text = "Prikazi rezultate";
            this.btn_prikaziRezultate.UseVisualStyleBackColor = true;
            this.btn_prikaziRezultate.Click += new System.EventHandler(this.btn_prikaziRezultate_Click);
            // 
            // btn_upisiIme
            // 
            this.btn_upisiIme.Location = new System.Drawing.Point(939, 664);
            this.btn_upisiIme.Name = "btn_upisiIme";
            this.btn_upisiIme.Size = new System.Drawing.Size(101, 40);
            this.btn_upisiIme.TabIndex = 14;
            this.btn_upisiIme.Text = "Upisi ime";
            this.btn_upisiIme.UseVisualStyleBackColor = true;
            this.btn_upisiIme.Click += new System.EventHandler(this.btn_upisiIme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 860);
            this.Controls.Add(this.btn_upisiIme);
            this.Controls.Add(this.btn_prikaziRezultate);
            this.Controls.Add(this.lbl_unesiIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_otvori);
            this.Controls.Add(this.btn_sacuvaj);
            this.Controls.Add(this.lbl_nazivSlike);
            this.Controls.Add(this.btn_Kraj);
            this.Controls.Add(this.btn_bojaLinija);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_odigraniPotezi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_novaIgra);
            this.Controls.Add(this.btn_ucitajSliku);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ucitajSliku;
        private System.Windows.Forms.Button btn_novaIgra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_odigraniPotezi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton vrsta5;
        private System.Windows.Forms.RadioButton vrsta4;
        private System.Windows.Forms.RadioButton vrsta3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton kolona5;
        private System.Windows.Forms.RadioButton kolona4;
        private System.Windows.Forms.RadioButton kolona3;
        private System.Windows.Forms.Button btn_bojaLinija;
        private System.Windows.Forms.Button btn_Kraj;
        private System.Windows.Forms.Label lbl_nazivSlike;
        private System.Windows.Forms.Button btn_sacuvaj;
        private System.Windows.Forms.Button btn_otvori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lbl_unesiIme;
        private System.Windows.Forms.Button btn_prikaziRezultate;
        private System.Windows.Forms.Button btn_upisiIme;
    }
}

