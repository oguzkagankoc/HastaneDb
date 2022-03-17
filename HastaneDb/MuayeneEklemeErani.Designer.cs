
namespace HastaneDb
{
    partial class MuayeneEklemeErani
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
            this.dtMuayeneTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHekimler = new System.Windows.Forms.ComboBox();
            this.btnMuayeneEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.chblHastaliklar = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtMuayeneTarihi
            // 
            this.dtMuayeneTarihi.Location = new System.Drawing.Point(161, 45);
            this.dtMuayeneTarihi.Name = "dtMuayeneTarihi";
            this.dtMuayeneTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtMuayeneTarihi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Muayene Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aile Hekimi";
            // 
            // cmbHekimler
            // 
            this.cmbHekimler.FormattingEnabled = true;
            this.cmbHekimler.Location = new System.Drawing.Point(161, 90);
            this.cmbHekimler.Name = "cmbHekimler";
            this.cmbHekimler.Size = new System.Drawing.Size(200, 21);
            this.cmbHekimler.TabIndex = 3;
            // 
            // btnMuayeneEkle
            // 
            this.btnMuayeneEkle.Location = new System.Drawing.Point(45, 369);
            this.btnMuayeneEkle.Name = "btnMuayeneEkle";
            this.btnMuayeneEkle.Size = new System.Drawing.Size(316, 43);
            this.btnMuayeneEkle.TabIndex = 4;
            this.btnMuayeneEkle.Text = "Muayene Ekle";
            this.btnMuayeneEkle.UseVisualStyleBackColor = true;
            this.btnMuayeneEkle.Click += new System.EventHandler(this.btnMuayeneEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hasta";
            // 
            // cmbHasta
            // 
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(161, 125);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(200, 21);
            this.cmbHasta.TabIndex = 6;
            // 
            // chblHastaliklar
            // 
            this.chblHastaliklar.FormattingEnabled = true;
            this.chblHastaliklar.Location = new System.Drawing.Point(161, 161);
            this.chblHastaliklar.Name = "chblHastaliklar";
            this.chblHastaliklar.Size = new System.Drawing.Size(200, 124);
            this.chblHastaliklar.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hastalıklar";
            // 
            // MuayeneEklemeErani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chblHastaliklar);
            this.Controls.Add(this.cmbHasta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMuayeneEkle);
            this.Controls.Add(this.cmbHekimler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtMuayeneTarihi);
            this.Name = "MuayeneEklemeErani";
            this.Text = "MuayeneEklemeErani";
            this.Load += new System.EventHandler(this.MuayeneEklemeErani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtMuayeneTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHekimler;
        private System.Windows.Forms.Button btnMuayeneEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbHasta;
        private System.Windows.Forms.CheckedListBox chblHastaliklar;
        private System.Windows.Forms.Label label4;
    }
}