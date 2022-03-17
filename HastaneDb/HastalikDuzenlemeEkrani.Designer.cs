
namespace HastaneDb
{
    partial class HastalikDuzenlemeEkrani
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
            this.btnHastalikEkle = new System.Windows.Forms.Button();
            this.txtIcd10 = new System.Windows.Forms.TextBox();
            this.txtHastalikAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHastalikId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHastalikEkle
            // 
            this.btnHastalikEkle.Location = new System.Drawing.Point(55, 114);
            this.btnHastalikEkle.Name = "btnHastalikEkle";
            this.btnHastalikEkle.Size = new System.Drawing.Size(232, 32);
            this.btnHastalikEkle.TabIndex = 9;
            this.btnHastalikEkle.Text = "Hastalık Ekle";
            this.btnHastalikEkle.UseVisualStyleBackColor = true;
            this.btnHastalikEkle.Click += new System.EventHandler(this.btnHastalikEkle_Click);
            // 
            // txtIcd10
            // 
            this.txtIcd10.Location = new System.Drawing.Point(138, 78);
            this.txtIcd10.Name = "txtIcd10";
            this.txtIcd10.Size = new System.Drawing.Size(149, 20);
            this.txtIcd10.TabIndex = 8;
            // 
            // txtHastalikAdi
            // 
            this.txtHastalikAdi.Location = new System.Drawing.Point(138, 49);
            this.txtHastalikAdi.Name = "txtHastalikAdi";
            this.txtHastalikAdi.Size = new System.Drawing.Size(149, 20);
            this.txtHastalikAdi.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ICD10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hastalık Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID";
            // 
            // lblHastalikId
            // 
            this.lblHastalikId.AutoSize = true;
            this.lblHastalikId.Location = new System.Drawing.Point(135, 23);
            this.lblHastalikId.Name = "lblHastalikId";
            this.lblHastalikId.Size = new System.Drawing.Size(0, 13);
            this.lblHastalikId.TabIndex = 11;
            // 
            // HastalikDuzenlemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHastalikId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHastalikEkle);
            this.Controls.Add(this.txtIcd10);
            this.Controls.Add(this.txtHastalikAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HastalikDuzenlemeEkrani";
            this.Text = "HastalikDuzenlemeEkrani";
            this.Load += new System.EventHandler(this.HastalikDuzenlemeEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHastalikEkle;
        private System.Windows.Forms.TextBox txtIcd10;
        private System.Windows.Forms.TextBox txtHastalikAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblHastalikId;
    }
}