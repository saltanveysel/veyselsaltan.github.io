using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev5
{
    public partial class FormAna : Form
    {
        public FormAna()
        {
            InitializeComponent();
        }

        private void FormAna_Load(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            fl.MdiParent = this;
            fl.StartPosition = FormStartPosition.CenterScreen;
            fl.Show();
        }
        public void AktifEt()
        {
            referanslarToolStripMenuItem.Visible = true;
            hastaKabulToolStripMenuItem.Enabled = true;
            raporlarToolStripMenuItem.Enabled = true;

        }
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void poliklinikTanıtmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Polikliniktanitma fp = new Polikliniktanitma();
            fp.MdiParent = this;
            fp.StartPosition = FormStartPosition.CenterScreen;
            fp.Show();
        }

        private void kullanıcıTanıtmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciTanitma fk = new KullaniciTanitma();
            fk.MdiParent = this;
            fk.StartPosition = FormStartPosition.CenterParent;
            fk.Show();
        }

        private void hastaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hastaislemleri fh = new Hastaislemleri();
            fh.MdiParent = this;
            fh.StartPosition = FormStartPosition.CenterScreen;
            fh.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            fl.MdiParent = this;
            fl.StartPosition = FormStartPosition.CenterScreen;
            fl.Show();
        }

        private void rapor1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRapor fr = new FormRapor();
            fr.Show();
        }
    }
}
