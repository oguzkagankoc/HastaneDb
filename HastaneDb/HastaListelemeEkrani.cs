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
    public partial class HastaListelemeEkrani : Form
    {
        private HastaneDbEntities _db;
        public HastaListelemeEkrani()
        {
            InitializeComponent();
            _db = new HastaneDbEntities();
        }

        private void HastaListelemeEkrani_Load(object sender, EventArgs e)
        {
            lstvHasta.Items.Clear();

            var hastalar = _db.Hastalars.Include(x=>x.AileHekimleri).Where(x => x.IsActive).ToList();

            foreach (var hasta in hastalar)
            {
                ListViewItem li = new ListViewItem();
                li.Text = hasta.ID.ToString();
                li.SubItems.Add(hasta.Name
                    );
                li.SubItems.Add(hasta.Surname);
                li.SubItems.Add(hasta.Tckn);
                li.SubItems.Add(hasta.Adres);
                li.SubItems.Add(hasta.AileHekimleri.Name + " " + hasta.AileHekimleri.Surname); li.SubItems.Add(hasta.DogumTarihi.ToString("dd/MM/yyyy"));
                lstvHasta.Items.Add(li);
            };

        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var secilenHasta = lstvHasta.SelectedItems[0].Text;

            var secilenId = Convert.ToInt32(secilenHasta);

            HastaDuzenlemeEkrani hde = new HastaDuzenlemeEkrani();
            hde.lblHastaId.Text = secilenHasta;

            hde.Show();

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var secilenHasta = lstvHasta.SelectedItems[0].Text;
            var secilenId = Convert.ToInt32(secilenHasta);
            var hasta = _db.Hastalars.FirstOrDefault(x => x.ID == secilenId);
            hasta.IsActive = false;
            var sonuc = _db.SaveChanges();

            if (sonuc>0)
            {
                MessageBox.Show("Silme İşlemi Başarılı");
            }

        }
    }
}
