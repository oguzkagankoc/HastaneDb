
namespace HastaneDb
{
    partial class MuayeneDuzenlemeEkrani
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
            this.label4 = new System.Windows.Forms.Label();
            this.chblHastaliklar = new System.Windows.Forms.CheckedListBox();
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMuayeneEkle = new System.Windows.Forms.Button();
            this.cmbHekimler = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtMuayeneTarihi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMuayeneId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Hastalıklar";
            // 
            // chblHastaliklar
            // 
            this.chblHastaliklar.FormattingEnabled = true;
            this.chblHastaliklar.Location = new System.Drawing.Point(172, 173);
            this.chblHastaliklar.Name = "chblHastaliklar";
            this.chblHastaliklar.Size = new System.Drawing.Size(200, 124);
            this.chblHastaliklar.TabIndex = 16;
            // 
            // cmbHasta
            // 
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(172, 137);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(200, 21);
            this.cmbHasta.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Hasta";
            // 
            // btnMuayeneEkle
            // 
            this.btnMuayeneEkle.Location = new System.Drawing.Point(56, 381);
            this.btnMuayeneEkle.Name = "btnMuayeneEkle";
            this.btnMuayeneEkle.Size = new System.Drawing.Size(316, 43);
            this.btnMuayeneEkle.TabIndex = 13;
            this.btnMuayeneEkle.Text = "Muayene Duzenle";
            this.btnMuayeneEkle.UseVisualStyleBackColor = true;
            this.btnMuayeneEkle.Click += new System.EventHandler(this.btnMuayeneEkle_Click);
            // 
            // cmbHekimler
            // 
            this.cmbHekimler.FormattingEnabled = true;
            this.cmbHekimler.Location = new System.Drawing.Point(172, 102);
            this.cmbHekimler.Name = "cmbHekimler";
            this.cmbHekimler.Size = new System.Drawing.Size(200, 21);
            this.cmbHekimler.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Aile Hekimi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Muayene Tarihi";
            // 
            // dtMuayeneTarihi
            // 
            this.dtMuayeneTarihi.Location = new System.Drawing.Point(172, 57);
            this.dtMuayeneTarihi.Name = "dtMuayeneTarihi";
            this.dtMuayeneTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtMuayeneTarihi.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "ID";
            // 
            // lblMuayeneId
            // 
            this.lblMuayeneId.AutoSize = true;
            this.lblMuayeneId.Location = new System.Drawing.Point(169, 28);
            this.lblMuayeneId.Name = "lblMuayeneId";
            this.lblMuayeneId.Size = new System.Drawing.Size(0, 13);
            this.lblMuayeneId.TabIndex = 19;
            // 
            // MuayeneDuzenlemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMuayeneId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chblHastaliklar);
            this.Controls.Add(this.cmbHasta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMuayeneEkle);
            this.Controls.Add(this.cmbHekimler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtMuayeneTarihi);
            this.Name = "MuayeneDuzenlemeEkrani";
            this.Text = "MuayeneDuzenlemeEkrani";
            this.Load += new System.EventHandler(this.MuayeneDuzenlemeEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox chblHastaliklar;
        private System.Windows.Forms.ComboBox cmbHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMuayeneEkle;
        private System.Windows.Forms.ComboBox cmbHekimler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtMuayeneTarihi;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblMuayeneId;
    }
}