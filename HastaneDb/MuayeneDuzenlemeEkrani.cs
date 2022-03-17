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
    public partial class MuayeneDuzenlemeEkrani : Form
    {
        private HastaneDbEntities _db;
        public MuayeneDuzenlemeEkrani()
        {
            InitializeComponent();
            _db = new HastaneDbEntities();
        }

        private void MuayeneDuzenlemeEkrani_Load(object sender, EventArgs e)
        {
            var aileHekimleri = _db.AileHekimleris.ToList();
            var hastalar = _db.Hastalars.ToList();
            var hastaliklar = _db.Hastaliklars.ToList();

            foreach (var aileHekimi in aileHekimleri)
            {
                cmbHekimler.Items.Add(aileHekimi);
            } 
            foreach (var hasta in hastalar)
            {
                cmbHasta.Items.Add(hasta);
            }
            foreach (var hastalik in hastaliklar)
            {
                chblHastaliklar.Items.Add(hastalik);
            }

            var secilenId = Convert.ToInt32(lblMuayeneId.Text);
            var muayene = _db.Muayenelers.Include(x => x.MuayeneHastaliklars).FirstOrDefault(x => x.ID == secilenId);
            var muayeneHastaliklar = _db.MuayeneHastaliklars.Include(x => x.Hastaliklar).Include(x => x.Muayeneler).Where(x => x.MuayenelerId == Convert.ToInt32(lblMuayeneId.Text));
            cmbHekimler.SelectedItem = muayene.AileHekimleri;
            cmbHasta.SelectedItem = muayene.Hastalar;

            foreach (var muayeneHastalik in muayene.MuayeneHastaliklars)
            {
                chblHastaliklar.SetItemChecked(muayeneHastalik.HastaliklarId - 1, true);
            }


        }

        private void btnMuayeneEkle_Click(object sender, EventArgs e)
        {
            var secilenHastalik = new List<MuayeneHastaliklar>();
            var secilenId = Convert.ToInt32(lblMuayeneId.Text);
            var muayene = _db.Muayenelers.Include(x => x.MuayeneHastaliklars).FirstOrDefault(x => x.ID == secilenId);
            foreach (Hastaliklar hastalik in chblHastaliklar.CheckedItems)
            {
                var muayeneHastalik = new MuayeneHastaliklar()
                {
                    HastaliklarId = hastalik.ID
                };
                secilenHastalik.Add(muayeneHastalik);
            }
            muayene.AileHekimleriId = ((AileHekimleri)cmbHekimler.SelectedItem).ID;
            muayene.HastalarId = ((Hastalar)cmbHasta.SelectedItem).ID;
            muayene.MuayeneHastaliklars = secilenHastalik;
            muayene.UpdatedById = -1;
            muayene.UpdatedDate = DateTime.Now;
            var sonuc = _db.SaveChanges();
            if (sonuc>0)
            {
                MessageBox.Show("Muayene Düzeltme Başarılı");
            }


        }
    }
}
