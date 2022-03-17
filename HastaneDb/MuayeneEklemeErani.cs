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
    public partial class MuayeneEklemeErani : Form
    {
        private HastaneDbEntities _db;
        public MuayeneEklemeErani()
        {
            InitializeComponent();
            _db = new HastaneDbEntities();
        }

        private void MuayeneEklemeErani_Load(object sender, EventArgs e)
        {
            var hekimler = _db.AileHekimleris.Where(x => x.IsActive).ToList();

            foreach (var hekim in hekimler)
            {
                cmbHekimler.Items.Add(hekim);
            }

            var hastalar = _db.Hastalars.Where(x => x.IsActive).ToList();

            foreach (var hasta in hastalar)
            {
                cmbHasta.Items.Add(hasta);
            }
            var hastaliklar = _db.Hastaliklars.Where(x => x.IsActive).ToList();

            foreach (var hastalik in hastaliklar)
            {
                chblHastaliklar.Items.Add(hastalik);
            }
        }

        private void btnMuayeneEkle_Click(object sender, EventArgs e)
        {
            var muayeneHastalikListe = new List<MuayeneHastaliklar>();

            foreach (Hastaliklar hastalik in chblHastaliklar.CheckedItems)
            {
                var hastalikEkle = new MuayeneHastaliklar()
                {
                    HastaliklarId = hastalik.ID,
                };
                muayeneHastalikListe.Add(hastalikEkle);
            }


            var muayene = new Muayeneler()
            {
                MuayeneTarihi = dtMuayeneTarihi.Value.Date,
                AileHekimleriId = ((AileHekimleri)cmbHekimler.SelectedItem).ID,
                HastalarId = ((Hastalar)cmbHasta.SelectedItem).ID,
                MuayeneHastaliklars = muayeneHastalikListe,
                CreatedById = -1,
                CreatedDate = DateTime.Now,
                IsActive=true
            };
            _db.Muayenelers.Add(muayene);
            var sonuc = _db.SaveChanges();
            if (sonuc > 0)
            {
                MessageBox.Show("Muayene Eklendi");
            }
        }
    }
}
