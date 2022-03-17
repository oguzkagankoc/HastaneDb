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
    public partial class HastalikDuzenlemeEkrani : Form
    {
        private HastaneDbEntities _db;
        public HastalikDuzenlemeEkrani()
        {
            InitializeComponent();
            _db = new HastaneDbEntities();
        }

        private void HastalikDuzenlemeEkrani_Load(object sender, EventArgs e)
        {
            var secilenId = Convert.ToInt32(lblHastalikId.Text);
            var hastalik = _db.Hastaliklars.FirstOrDefault(x => x.ID == secilenId);
            txtHastalikAdi.Text = hastalik.HastalikAdi;
            txtIcd10.Text = hastalik.ICD10;
        }

        private void btnHastalikEkle_Click(object sender, EventArgs e)
        {
            var secilenId = Convert.ToInt32(lblHastalikId.Text);
            var guncellenecekHastalik = _db.Hastaliklars.FirstOrDefault(x => x.ID == secilenId);
            guncellenecekHastalik.IsActive = true;
            guncellenecekHastalik.HastalikAdi = txtHastalikAdi.Text;
            guncellenecekHastalik.ICD10 = txtIcd10.Text;
            guncellenecekHastalik.UpdatedDate = DateTime.Now;
            guncellenecekHastalik.UpdatedById = -1;

            var sonuc = _db.SaveChanges();
            if (sonuc>0)
            {
                MessageBox.Show("Düzenleme Başarılı");
            }
        }
    }
}
