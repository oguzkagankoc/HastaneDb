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
    public partial class AileHekimiEklemeEkrani : Form
    {
        private HastaneDbEntities _db;
        public AileHekimiEklemeEkrani()
        {
            InitializeComponent();
            _db = new HastaneDbEntities();
        }

        private void AileHekimiEklemeEkrani_Load(object sender, EventArgs e)
        {

        }

        private void btnAileHekimiEkle_Click(object sender, EventArgs e)
        {
            var hekim = new AileHekimleri()
            {
                Name = txtHekiminAdi.Text,
                Surname = txtHekiminSoyadi.Text,
                DiplomaNo = txtDiplomaNo.Text,
                Tckn = txtHekiminTckn.Text,
              IsActive = true,
              CreatedDate = DateTime.Now,
              CreatedById = -1,
            };
            _db.AileHekimleris.Add(hekim);
            var sonuc = _db.SaveChanges();
            if (sonuc>0)
            {
                MessageBox.Show("Eklendi");
            }
        }
    }
}
