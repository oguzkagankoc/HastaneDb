
namespace HastaneDb
{
    partial class AileHekimiEklemeEkrani
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHekiminAdi = new System.Windows.Forms.TextBox();
            this.txtHekiminSoyadi = new System.Windows.Forms.TextBox();
            this.txtDiplomaNo = new System.Windows.Forms.TextBox();
            this.txtHekiminTckn = new System.Windows.Forms.TextBox();
            this.btnAileHekimiEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hekimin Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hekimin Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Diploma No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TCKN";
            // 
            // txtHekiminAdi
            // 
            this.txtHekiminAdi.Location = new System.Drawing.Point(185, 50);
            this.txtHekiminAdi.Name = "txtHekiminAdi";
            this.txtHekiminAdi.Size = new System.Drawing.Size(100, 20);
            this.txtHekiminAdi.TabIndex = 4;
            // 
            // txtHekiminSoyadi
            // 
            this.txtHekiminSoyadi.Location = new System.Drawing.Point(185, 82);
            this.txtHekiminSoyadi.Name = "txtHekiminSoyadi";
            this.txtHekiminSoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtHekiminSoyadi.TabIndex = 5;
            // 
            // txtDiplomaNo
            // 
            this.txtDiplomaNo.Location = new System.Drawing.Point(185, 111);
            this.txtDiplomaNo.Name = "txtDiplomaNo";
            this.txtDiplomaNo.Size = new System.Drawing.Size(100, 20);
            this.txtDiplomaNo.TabIndex = 6;
            // 
            // txtHekiminTckn
            // 
            this.txtHekiminTckn.Location = new System.Drawing.Point(185, 139);
            this.txtHekiminTckn.Name = "txtHekiminTckn";
            this.txtHekiminTckn.Size = new System.Drawing.Size(100, 20);
            this.txtHekiminTckn.TabIndex = 7;
            // 
            // btnAileHekimiEkle
            // 
            this.btnAileHekimiEkle.Location = new System.Drawing.Point(78, 177);
            this.btnAileHekimiEkle.Name = "btnAileHekimiEkle";
            this.btnAileHekimiEkle.Size = new System.Drawing.Size(207, 44);
            this.btnAileHekimiEkle.TabIndex = 8;
            this.btnAileHekimiEkle.Text = "Aile Hekimi Ekle";
            this.btnAileHekimiEkle.UseVisualStyleBackColor = true;
            this.btnAileHekimiEkle.Click += new System.EventHandler(this.btnAileHekimiEkle_Click);
            // 
            // AileHekimiEklemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAileHekimiEkle);
            this.Controls.Add(this.txtHekiminTckn);
            this.Controls.Add(this.txtDiplomaNo);
            this.Controls.Add(this.txtHekiminSoyadi);
            this.Controls.Add(this.txtHekiminAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AileHekimiEklemeEkrani";
            this.Text = "AileHekimiEklemeEkrani";
            this.Load += new System.EventHandler(this.AileHekimiEklemeEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHekiminAdi;
        private System.Windows.Forms.TextBox txtHekiminSoyadi;
        private System.Windows.Forms.TextBox txtDiplomaNo;
        private System.Windows.Forms.TextBox txtHekiminTckn;
        private System.Windows.Forms.Button btnAileHekimiEkle;
    }
}