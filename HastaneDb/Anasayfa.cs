using HastaneDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneDb
{
    public partial class Ana_Sayfa : Form
    {
        public Ana_Sayfa()
        {
            InitializeComponent();
        }

        private void ShowNewForm(string acilacakFormunAdi, Type acilacakFormunTipi)
        {
            Form acilacakForm = null;
            foreach (Form acikOlanForm in Application.OpenForms)
            {
                if (acikOlanForm.Name == acilacakFormunAdi)
                {
                    acilacakForm = acikOlanForm;
                }
            }
            if (acilacakForm == null)
            {
                Form yeniAcilacakForm = (Form)Activator.CreateInstance(acilacakFormunTipi);
                yeniAcilacakForm.MdiParent = this;
                yeniAcilacakForm.Show();
            }
            else
            {
                acilacakForm.BringToFront();
            }
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNewForm("AileHekimiEklemeEkrani", typeof(AileHekimiEklemeEkrani));
        }

        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNewForm("AileHekimiListelemeEkrani", typeof(AileHekimiListelemeEkrani));
        }

        private void ekleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowNewForm("HastaEklemeEkrani", typeof(HastaEklemeEkrani));
        }

        private void listeleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowNewForm("HastaListelemeEkrani", typeof(HastaListelemeEkrani));
        }

        private void ekleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ShowNewForm("HastalikEklemeEkrani", typeof(HastalikEklemeEkrani));
        }

        private void listeleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ShowNewForm("HastalikListelemeEkrani", typeof(HastalikListelemeEkrani));
        }

        private void ekleToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ShowNewForm("MuayeneEklemeEkrani",typeof(MuayeneEklemeErani));
        }

        private void listeleToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ShowNewForm("MuayeneListelemeEkrani", typeof(MuayeneListelemeEkrani));
        }
    }
}
