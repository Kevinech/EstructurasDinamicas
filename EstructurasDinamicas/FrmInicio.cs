using EstructurasDinamicas.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructurasDinamicas
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }



        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmPila().ShowDialog();
        }

        private void becaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmPila2().ShowDialog();

        }
    }
}
