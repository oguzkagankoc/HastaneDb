
namespace HastaneDb
{
    partial class AileHekimiDuzenlemeEkrani
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnAileHekimiDuzenle = new System.Windows.Forms.Button();
            this.txtHekiminTckn = new System.Windows.Forms.TextBox();
            this.txtDiplomaNo = new System.Windows.Forms.TextBox();
            this.txtHekiminSoyadi = new System.Windows.Forms.TextBox();
            this.txtHekiminAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(149, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 1;
            // 
            // btnAileHekimiDuzenle
            // 
            this.btnAileHekimiDuzenle.Location = new System.Drawing.Point(93, 187);
            this.btnAileHekimiDuzenle.Name = "btnAileHekimiDuzenle";
            this.btnAileHekimiDuzenle.Size = new System.Drawing.Size(207, 44);
            this.btnAileHekimiDuzenle.TabIndex = 17;
            this.btnAileHekimiDuzenle.Text = "Aile Hekimi Düzenle";
            this.btnAileHekimiDuzenle.UseVisualStyleBackColor = true;
            this.btnAileHekimiDuzenle.Click += new System.EventHandler(this.btnAileHekimiDuzenle_Click);
            // 
            // txtHekiminTckn
            // 
            this.txtHekiminTckn.Location = new System.Drawing.Point(200, 149);
            this.txtHekiminTckn.Name = "txtHekiminTckn";
            this.txtHekiminTckn.Size = new System.Drawing.Size(100, 20);
            this.txtHekiminTckn.TabIndex = 16;
            // 
            // txtDiplomaNo
            // 
            this.txtDiplomaNo.Location = new System.Drawing.Point(200, 121);
            this.txtDiplomaNo.Name = "txtDiplomaNo";
            this.txtDiplomaNo.Size = new System.Drawing.Size(100, 20);
            this.txtDiplomaNo.TabIndex = 15;
            // 
            // txtHekiminSoyadi
            // 
            this.txtHekiminSoyadi.Location = new System.Drawing.Point(200, 92);
            this.txtHekiminSoyadi.Name = "txtHekiminSoyadi";
            this.txtHekiminSoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtHekiminSoyadi.TabIndex = 14;
            // 
            // txtHekiminAdi
            // 
            this.txtHekiminAdi.Location = new System.Drawing.Point(200, 60);
            this.txtHekiminAdi.Name = "txtHekiminAdi";
            this.txtHekiminAdi.Size = new System.Drawing.Size(100, 20);
            this.txtHekiminAdi.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "TCKN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Diploma No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hekimin Soyadı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hekimin Adı";
            // 
            // AileHekimiDuzenlemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAileHekimiDuzenle);
            this.Controls.Add(this.txtHekiminTckn);
            this.Controls.Add(this.txtDiplomaNo);
            this.Controls.Add(this.txtHekiminSoyadi);
            this.Controls.Add(this.txtHekiminAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label1);
            this.Name = "AileHekimiDuzenlemeEkrani";
            this.Text = "AileHekimiDuzenlemeEkrani";
            this.Load += new System.EventHandler(this.AileHekimiDuzenlemeEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAileHekimiDuzenle;
        private System.Windows.Forms.TextBox txtHekiminTckn;
        private System.Windows.Forms.TextBox txtDiplomaNo;
        private System.Windows.Forms.TextBox txtHekiminSoyadi;
        private System.Windows.Forms.TextBox txtHekiminAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblId;
    }
}