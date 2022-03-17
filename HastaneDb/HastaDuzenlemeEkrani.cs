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
    public partial class HastaDuzenlemeEkrani : Form
    {
        private HastaneDbEntities _db;
        public HastaDuzenlemeEkrani()
        {
            InitializeComponent();
            _db = new HastaneDbEntities();
        }

        private void HastaDuzenlemeEkrani_Load(object sender, EventArgs e)
        {
            var secilenId = Convert.ToInt32(lblHastaId.Text);

            var hasta = _db.Hastalars.Include(x => x.AileHekimleri).FirstOrDefault(x => x.ID == secilenId);

            var aileHekimleri = _db.AileHekimleris.Where(x => x.IsActive).ToList();
            hasta.Name = txtHastaninAdi.Text;
            hasta.Surname = txtHastaninSoyadi.Text;
            hasta.Tckn = txtHastaninTckn.Text;
            hasta.Adres = txtHastaninAdresi.Text;
            dtpDogumTarihi.Value = hasta.DogumTarihi;
            foreach (var aileHekimi in aileHekimleri)
            {
                cmbAileHekimi.Items.Add(aileHekimi);
            }
            cmbAileHekimi.SelectedItem = hasta.AileHekimleri;
        }

        private void btnHastayiEkle_Click(object sender, EventArgs e)
        {
            var secilenId = Convert.ToInt32(lblHastaId.Text);
            var hasta = _db.Hastalars.Include(x => x.AileHekimleri).FirstOrDefault(x => x.ID == secilenId);
            hasta.Name = txtHastaninAdi.Text;
            hasta.Surname = txtHastaninSoyadi.Text;
            hasta.Tckn = txtHastaninTckn.Text;
            hasta.Adres = txtHastaninAdresi.Text;
            hasta.AileHekimleriId = ((AileHekimleri)cmbAileHekimi.SelectedItem).ID;
            hasta.UpdatedDate = DateTime.Now;
            hasta.UpdatedById = -1;
            var sonuc = _db.SaveChanges();
            if (sonuc>0)
            {
                MessageBox.Show("Hasta Düzenleme Başarılı");
            }

        }
    }
}
