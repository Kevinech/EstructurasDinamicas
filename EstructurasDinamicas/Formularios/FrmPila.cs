using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructurasDinamicas.Formularios
{
    public partial class FrmPila : Form
    {

        Stack<int> pila = new Stack<int>();

        public FrmPila()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            int elemento = int.Parse(tbNumero.Text);
            //Agregar un elemento a la pila
            pila.Push(elemento);

            lblPila.Text = MostrarElementos();
            tbNumero.Clear();
            tbNumero.Focus();


        }

        private string MostrarElementos()
        {
            string msn = "";

            foreach (int i in pila)
            {
                msn += " " + i.ToString() + " |";

            }
            return msn;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {

            try
            {
                pila.Pop();
                //Quitar elementos de la pila
                lblPila.Text = MostrarElementos();
            }
            catch(InvalidOperationException)
            { 
                MessageBox.Show("Estimado usuario, no se puede eliminar elementos, porque la pila esta vacía."
                    , "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnMostrarU_Click(object sender, EventArgs e)
        {
            
            try
            {

                pila.Peek();

                int elemento = pila.Peek();


                lblPila.Text = "Ultimo elemento ingresado: " + elemento.ToString();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Pila vacía",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


            
        }

    }
}
