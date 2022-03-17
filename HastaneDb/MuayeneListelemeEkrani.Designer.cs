
namespace HastaneDb
{
    partial class MuayeneListelemeEkrani
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstMuayene = new System.Windows.Forms.ListView();
            this.lvlId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvlMuayeneTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvlAileHekimi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvlHasta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvlHastaliklar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // lstMuayene
            // 
            this.lstMuayene.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvlId,
            this.lvlMuayeneTarihi,
            this.lvlAileHekimi,
            this.lvlHasta,
            this.lvlHastaliklar});
            this.lstMuayene.ContextMenuStrip = this.contextMenuStrip1;
            this.lstMuayene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMuayene.FullRowSelect = true;
            this.lstMuayene.GridLines = true;
            this.lstMuayene.HideSelection = false;
            this.lstMuayene.Location = new System.Drawing.Point(0, 0);
            this.lstMuayene.MultiSelect = false;
            this.lstMuayene.Name = "lstMuayene";
            this.lstMuayene.Size = new System.Drawing.Size(800, 450);
            this.lstMuayene.TabIndex = 1;
            this.lstMuayene.UseCompatibleStateImageBehavior = false;
            this.lstMuayene.View = System.Windows.Forms.View.Details;
            // 
            // lvlId
            // 
            this.lvlId.Text = "ID";
            // 
            // lvlMuayeneTarihi
            // 
            this.lvlMuayeneTarihi.Text = "Muayene Tarihi";
            this.lvlMuayeneTarihi.Width = 98;
            // 
            // lvlAileHekimi
            // 
            this.lvlAileHekimi.Text = "Aile Hekimi";
            this.lvlAileHekimi.Width = 81;
            // 
            // lvlHasta
            // 
            this.lvlHasta.Text = "Hasta";
            this.lvlHasta.Width = 72;
            // 
            // lvlHastaliklar
            // 
            this.lvlHastaliklar.Text = "Hastalıklar";
            this.lvlHastaliklar.Width = 76;
            // 
            // MuayeneListelemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstMuayene);
            this.Name = "MuayeneListelemeEkrani";
            this.Text = "MuayeneListelemeEkrani";
            this.Load += new System.EventHandler(this.MuayeneListelemeEkrani_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ListView lstMuayene;
        private System.Windows.Forms.ColumnHeader lvlId;
        private System.Windows.Forms.ColumnHeader lvlMuayeneTarihi;
        private System.Windows.Forms.ColumnHeader lvlAileHekimi;
        private System.Windows.Forms.ColumnHeader lvlHasta;
        private System.Windows.Forms.ColumnHeader lvlHastaliklar;
    }
}