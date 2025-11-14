using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolesyGrafos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArbol_Click(object sender, EventArgs e)
        {
            FrmÁrbol frmArbol = new FrmÁrbol();
            frmArbol.Show();
        }

        private void btnGrafo_Click(object sender, EventArgs e)
        {
            FrmGrafo frmGrafo = new FrmGrafo();
            frmGrafo.Show();
        }
    }
}
