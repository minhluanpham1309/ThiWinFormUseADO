using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiWinfrom
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void thôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchQuảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DSSP frm_ds = new Frm_DSSP();
            frm_ds.MdiParent = this;
            frm_ds.Show();
        }
    }
}
