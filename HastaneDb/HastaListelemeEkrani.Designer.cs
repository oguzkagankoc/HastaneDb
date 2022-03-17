
namespace HastaneDb
{
    partial class HastaListelemeEkrani
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
            this.lstvHasta = new System.Windows.Forms.ListView();
            this.lstId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstHastaAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstHastaSoyadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstHastaTckn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstAdres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstAileHekimi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstDogumTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstvHasta
            // 
            this.lstvHasta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lstId,
            this.lstHastaAdi,
            this.lstHastaSoyadi,
            this.lstHastaTckn,
            this.lstAdres,
            this.lstAileHekimi,
            this.lstDogumTarihi});
            this.lstvHasta.ContextMenuStrip = this.contextMenuStrip1;
            this.lstvHasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvHasta.FullRowSelect = true;
            this.lstvHasta.GridLines = true;
            this.lstvHasta.HideSelection = false;
            this.lstvHasta.Location = new System.Drawing.Point(0, 0);
            this.lstvHasta.MultiSelect = false;
            this.lstvHasta.Name = "lstvHasta";
            this.lstvHasta.Size = new System.Drawing.Size(800, 450);
            this.lstvHasta.TabIndex = 0;
            this.lstvHasta.UseCompatibleStateImageBehavior = false;
            this.lstvHasta.View = System.Windows.Forms.View.Details;
            // 
            // lstId
            // 
            this.lstId.Text = "ID";
            // 
            // lstHastaAdi
            // 
            this.lstHastaAdi.Text = "Hastanın Adı";
            this.lstHastaAdi.Width = 120;
            // 
            // lstHastaSoyadi
            // 
            this.lstHastaSoyadi.Text = "Hastanın Soyadı";
            this.lstHastaSoyadi.Width = 138;
            // 
            // lstHastaTckn
            // 
            this.lstHastaTckn.Text = "Hastanın Tckn";
            this.lstHastaTckn.Width = 87;
            // 
            // lstAdres
            // 
            this.lstAdres.Text = "Hastanın Adresi";
            // 
            // lstAileHekimi
            // 
            this.lstAileHekimi.Text = "Aile Hekimi";
            // 
            // lstDogumTarihi
            // 
            this.lstDogumTarihi.Text = "Doğum Tarihi";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 48);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // HastaListelemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstvHasta);
            this.Name = "HastaListelemeEkrani";
            this.Text = "HastaListelemeEkrani";
            this.Load += new System.EventHandler(this.HastaListelemeEkrani_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstvHasta;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader lstId;
        private System.Windows.Forms.ColumnHeader lstHastaAdi;
        private System.Windows.Forms.ColumnHeader lstHastaSoyadi;
        private System.Windows.Forms.ColumnHeader lstHastaTckn;
        private System.Windows.Forms.ColumnHeader lstAdres;
        private System.Windows.Forms.ColumnHeader lstAileHekimi;
        private System.Windows.Forms.ColumnHeader lstDogumTarihi;
    }
}