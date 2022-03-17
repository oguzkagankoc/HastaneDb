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
    public partial class AileHekimiDuzenlemeEkrani : Form
    {
        private HastaneDbEntities _db;
        public AileHekimiDuzenlemeEkrani()
        {
            InitializeComponent();
            _db = new HastaneDbEntities();
        }

        private void AileHekimiDuzenlemeEkrani_Load(object sender, EventArgs e)
        {
            var secilenId = Convert.ToInt32(lblId.Text);
            var aileHekimi = _db.AileHekimleris.FirstOrDefault(x => x.ID == secilenId);
            txtHekiminAdi.Text = aileHekimi.Name;
            txtHekiminSoyadi.Text = aileHekimi.Surname;
            txtDiplomaNo.Text = aileHekimi.DiplomaNo;
            txtHekiminTckn.Text = aileHekimi.Tckn;
        }

        private void btnAileHekimiDuzenle_Click(object sender, EventArgs e)
        {
            var secilenId = Convert.ToInt32(lblId.Text);
            var guncellenecekAileHekimi = _db.AileHekimleris.FirstOrDefault(x => x.ID == secilenId);
            guncellenecekAileHekimi.IsActive = true;
            guncellenecekAileHekimi.Name = txtHekiminAdi.Text;
            guncellenecekAileHekimi.Surname = txtHekiminSoyadi.Text;
            guncellenecekAileHekimi.Tckn = txtHekiminTckn.Text;
            guncellenecekAileHekimi.DiplomaNo = txtDiplomaNo.Text;
            guncellenecekAileHekimi.UpdatedDate = DateTime.Now;
            guncellenecekAileHekimi.UpdatedById = -1;

            var sonuc = _db.SaveChanges();
            if (sonuc > 0)
            {
                MessageBox.Show("Düzenleme Başarılı");
            }
            //AileHekimleri a1 = new AileHekimleri()
            //{
            //    ID = Convert.ToInt32(lblId),
            //    DiplomaNo = txtDiplomaNo.Text,
            //    Tckn = txtHekiminTckn.Text,
            //    Name = txtHekiminAdi.Text,
            //    Surname = txtHekiminSoyadi.Text,
            //    UpdatedById = -1,
            //    UpdatedDate = DateTime.Now,
            //};

        }
    }
}
