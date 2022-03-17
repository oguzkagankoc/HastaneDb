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
    public partial class HastalikEklemeEkrani : Form
    {
        private HastaneDbEntities _db;
        public HastalikEklemeEkrani()
        {
            InitializeComponent();
            _db = new HastaneDbEntities();
        }

        private void HastalikEklemeEkrani_Load(object sender, EventArgs e)
        {

        }

        private void btnHastalikEkle_Click(object sender, EventArgs e)
        {
            var hastalik = new Hastaliklar()
            {
                HastalikAdi = txtHastalikAdi.Text,
                ICD10 = txtIcd10.Text,
                IsActive = true,
                CreatedById = -1,
                CreatedDate =  DateTime.Now,
            };
            _db.Hastaliklars.Add(hastalik);
            var sonuc = _db.SaveChanges();
            if (sonuc>0)
            {
                MessageBox.Show("Hastalik Eklendi");
            }
        }
    }
}
