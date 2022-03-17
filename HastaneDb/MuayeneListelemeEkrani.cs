using HastaneDb.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneDb
{
    public partial class MuayeneListelemeEkrani : Form
    {
        private HastaneDbEntities _db;
        public MuayeneListelemeEkrani()
        {
            InitializeComponent();
            _db = new HastaneDbEntities();
        }

        private void MuayeneListelemeEkrani_Load(object sender, EventArgs e)
        {
            var muayeneler = _db.Muayenelers.Include(x => x.AileHekimleri).Include(x => x.Hastalar).Include(x => x.MuayeneHastaliklars).Where(x => x.IsActive).ToList();

          

            foreach (var muayene in muayeneler)
            {
                var muayeneHastaliklarString = "";
                var muayeneHastaliklar = _db.MuayeneHastaliklars.Include(x => x.Hastaliklar).Where(x => x.MuayenelerId == muayene.ID).ToList();
                ListViewItem li = new ListViewItem(muayene.ID.ToString());
                li.Text = muayene.ID.ToString();
                li.SubItems.Add(muayene.MuayeneTarihi.ToString("dd/MM/yyyy"));
                li.SubItems.Add(muayene.AileHekimleri.ToString());
                li.SubItems.Add(muayene.Hastalar.ToString());
                foreach (var muayeneHastalik in muayeneHastaliklar)
                {
                    muayeneHastaliklarString += muayeneHastalik.Hastaliklar.HastalikAdi + " ";
                }

                li.SubItems.Add(muayeneHastaliklarString);
                lstMuayene.Items.Add(li);

            }

        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var secilenMuayene = lstMuayene.SelectedItems[0].Text;
            var secilenId = Convert.ToInt32(secilenMuayene);
            MuayeneDuzenlemeEkrani mde = new MuayeneDuzenlemeEkrani();
            mde.lblMuayeneId.Text = secilenMuayene;
            mde.Show();
         
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var secilenMuayene = lstMuayene.SelectedItems[0].Text;
            var secilenId = Convert.ToInt32(secilenMuayene);
            var muayene = _db.Muayenelers.FirstOrDefault(x => x.ID == secilenId);
            muayene.IsActive = false;
         var sonuc =   _db.SaveChanges();
            if (sonuc>0)
            {
                MessageBox.Show("Silme Başarılı");
            }

        }
    }
}
