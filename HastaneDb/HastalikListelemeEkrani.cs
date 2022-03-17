using HastaneDb.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneDb
{
    public partial class HastalikListelemeEkrani : Form
    {
        private HastaneDbEntities _db;
        public HastalikListelemeEkrani()
        {
            InitializeComponent();
            _db = new HastaneDbEntities();
        }
        private void HastalikListelemeEkrani_Load(object sender, EventArgs e)
        {
            var hastaliklar = _db.Hastaliklars.Where(x => x.IsActive).ToList();
            

            foreach (var hastalik in hastaliklar)
            {
                ListViewItem li = new ListViewItem();
                li.Text = hastalik.ID.ToString();
                li.SubItems.Add(hastalik.HastalikAdi);
                li.SubItems.Add(hastalik.ICD10);
                lstvHastaliklar.Items.Add(li);
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastalikDuzenlemeEkrani hde = new HastalikDuzenlemeEkrani();
            var secilenId = lstvHastaliklar.SelectedItems[0].Text;
            hde.lblHastalikId.Text = secilenId;
            hde.Show();
            MessageBox.Show("Test");
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var secilenId = Convert.ToInt32(lstvHastaliklar.SelectedItems[0].Text);
                var hastalik = _db.Hastaliklars.FirstOrDefault(x => x.ID == secilenId);
            hastalik.IsActive = false;
            hastalik.UpdatedById = -1;
            hastalik.UpdatedDate = DateTime.Now;
            var sonuc = _db.SaveChanges();
            if (sonuc>0)
            {
                MessageBox.Show("İşlem Başarılı");
            }
            lstvHastaliklar.Items.Clear();
            var hastaliklar = _db.Hastaliklars.Where(x => x.IsActive).ToList();

            foreach (var hst in hastaliklar)
            {
                ListViewItem li = new ListViewItem();
                li.Text = hst.ID.ToString();
                li.SubItems.Add(hst.HastalikAdi);
                li.SubItems.Add(hst.ICD10);
            }
        }
    }
}
