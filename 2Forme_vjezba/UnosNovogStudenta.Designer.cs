namespace _2Forme_vjezba
{
    partial class UnosNovogStudenta
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
            this.txtBoxIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxPrezime = new System.Windows.Forms.TextBox();
            this.txtBoxSmjer = new System.Windows.Forms.TextBox();
            this.txtBoxBrojIndeksa = new System.Windows.Forms.TextBox();
            this.txtBoxDatumRodjenja = new System.Windows.Forms.TextBox();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtBoxIme
            // 
            this.txtBoxIme.Location = new System.Drawing.Point(28, 68);
            this.txtBoxIme.Multiline = true;
            this.txtBoxIme.Name = "txtBoxIme";
            this.txtBoxIme.Size = new System.Drawing.Size(300, 47);
            this.txtBoxIme.TabIndex = 0;
            this.txtBoxIme.TextChanged += new System.EventHandler(this.txtBoxIme_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Smjer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Broj Indeksa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(530, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Datum Rodjenja:";
            // 
            // txtBoxPrezime
            // 
            this.txtBoxPrezime.Location = new System.Drawing.Point(18, 203);
            this.txtBoxPrezime.Multiline = true;
            this.txtBoxPrezime.Name = "txtBoxPrezime";
            this.txtBoxPrezime.Size = new System.Drawing.Size(249, 42);
            this.txtBoxPrezime.TabIndex = 6;
            // 
            // txtBoxSmjer
            // 
            this.txtBoxSmjer.Location = new System.Drawing.Point(28, 355);
            this.txtBoxSmjer.Multiline = true;
            this.txtBoxSmjer.Name = "txtBoxSmjer";
            this.txtBoxSmjer.Size = new System.Drawing.Size(239, 35);
            this.txtBoxSmjer.TabIndex = 7;
            // 
            // txtBoxBrojIndeksa
            // 
            this.txtBoxBrojIndeksa.Location = new System.Drawing.Point(523, 68);
            this.txtBoxBrojIndeksa.Multiline = true;
            this.txtBoxBrojIndeksa.Name = "txtBoxBrojIndeksa";
            this.txtBoxBrojIndeksa.Size = new System.Drawing.Size(241, 35);
            this.txtBoxBrojIndeksa.TabIndex = 8;
            // 
            // txtBoxDatumRodjenja
            // 
            this.txtBoxDatumRodjenja.Location = new System.Drawing.Point(541, 203);
            this.txtBoxDatumRodjenja.Multiline = true;
            this.txtBoxDatumRodjenja.Name = "txtBoxDatumRodjenja";
            this.txtBoxDatumRodjenja.Size = new System.Drawing.Size(223, 42);
            this.txtBoxDatumRodjenja.TabIndex = 9;
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(488, 315);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(104, 37);
            this.btnSnimi.TabIndex = 10;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(627, 305);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(98, 47);
            this.btnOtkazi.TabIndex = 11;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Programer",
            "Sistem Administrator",
            "Mrezni Administrator"});
            this.comboBox1.Location = new System.Drawing.Point(339, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // UnosNovogStudenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.txtBoxDatumRodjenja);
            this.Controls.Add(this.txtBoxBrojIndeksa);
            this.Controls.Add(this.txtBoxSmjer);
            this.Controls.Add(this.txtBoxPrezime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxIme);
            this.Name = "UnosNovogStudenta";
            this.Text = "UnosNovogStudenta";
            this.Load += new System.EventHandler(this.UnosNovogStudenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxPrezime;
        private System.Windows.Forms.TextBox txtBoxSmjer;
        private System.Windows.Forms.TextBox txtBoxBrojIndeksa;
        private System.Windows.Forms.TextBox txtBoxDatumRodjenja;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}