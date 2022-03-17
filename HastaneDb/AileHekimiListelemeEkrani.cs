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
    public partial class AileHekimiListelemeEkrani : Form
    {
        private HastaneDbEntities _db;
        public AileHekimiListelemeEkrani()
        {
            InitializeComponent();
            _db = new HastaneDbEntities();
        }
        public void Listele()
        {
            listView1.Items.Clear();
            var hekimler = _db.AileHekimleris.Where(x => x.IsActive).ToList();



            foreach (var hekim in hekimler)
            {

                ListViewItem li = new ListViewItem();
                li.Text = hekim.ID.ToString();
                li.SubItems.Add(hekim.Name);
                li.SubItems.Add(hekim.Surname);
                li.SubItems.Add(hekim.DiplomaNo);
                li.SubItems.Add(hekim.Tckn);
                listView1.Items.Add(li);
            }
        }

        private void AileHekimiListelemeEkrani_Load(object sender, EventArgs e)
        {
            Listele();


        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AileHekimiDuzenlemeEkrani ahd = new AileHekimiDuzenlemeEkrani();
            var secilenId = listView1.SelectedItems[0].Text;
            ahd.lblId.Text = secilenId;
            ahd.Show();

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var secilenElemanId = Convert.ToInt32(listView1.SelectedItems[0].Text);
            var aileHekimi = _db.AileHekimleris.FirstOrDefault(x => x.ID == secilenElemanId);
            aileHekimi.IsActive = false;
            aileHekimi.UpdatedById = -1;
            aileHekimi.UpdatedDate = DateTime.Now;
            var sonuc = _db.SaveChanges();
            if (sonuc > 0)
            {
                MessageBox.Show("İşlem Başarılı");
            }
            listView1.Items.Clear();
            var hekimler = _db.AileHekimleris.Where(x => x.IsActive).ToList();



            foreach (var hekim in hekimler)
            {

                ListViewItem li = new ListViewItem();
                li.Text = hekim.ID.ToString();
                li.SubItems.Add(hekim.Name);
                li.SubItems.Add(hekim.Surname);
                li.SubItems.Add(hekim.DiplomaNo);
                li.SubItems.Add(hekim.Tckn);
                listView1.Items.Add(li);
            }

        }
    }
}
