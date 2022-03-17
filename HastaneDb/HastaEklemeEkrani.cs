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
    public partial class HastaEklemeEkrani : Form
    {
        private HastaneDbEntities _db;
        public HastaEklemeEkrani()
        {
            InitializeComponent();
            _db = new HastaneDbEntities();
        }

        private void HastaEklemeEkrani_Load(object sender, EventArgs e)
        {
            var hekimler = _db.AileHekimleris.Where(x => x.IsActive).ToList();

            foreach (var hekim in hekimler)
            {
                cmbAileHekimi.Items.Add(hekim);
            }
        }

        private void btnHastayiEkle_Click(object sender, EventArgs e)
        {
            var hasta = new Hastalar()
            {
                 AileHekimleriId = ((AileHekimleri)cmbAileHekimi.SelectedItem).ID,
                Name = txtHastaninAdi.Text,
                Surname = txtHastaninSoyadi.Text,
                Tckn = txtHastaninTckn.Text,
                Adres = txtHastaninAdresi.Text,
                DogumTarihi = dtpDogumTarihi.Value.Date,
                IsActive = true,
                CreatedById = -1,
                CreatedDate = DateTime.Now,
            };
            _db.Hastalars.Add(hasta);
            var sonuc = _db.SaveChanges();
            if (sonuc>0)
            {
                MessageBox.Show("Hasta Eklendi");
            }
        }
    }
}
