using EstructurasDinamicas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructurasDinamicas.Formularios
{
    public partial class FrmPila2 : Form
    {


        Stack<Expediente> pila = new Stack<Expediente>();



        public FrmPila2()
        {
            InitializeComponent();
        }

        private void FrmPila2_Load(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGUardar_Click(object sender, EventArgs e)
        {

            Expediente est = new Expediente();

            est.Nombres = tbNombres.Text;
            est.Apellidos = tbApellidos.Text;
            est.Promedio = int.Parse(tbPromedios.Text);


            pila.push(est);

            LlenarList();





        }

        private void GetLlenarList()
        {
            lstPromedios.Items.Clear();

            foreach(Expediente est in pila)
            {
                lstPromedios.Items.Add(est.Promedio);
            }





        }





    }
}
