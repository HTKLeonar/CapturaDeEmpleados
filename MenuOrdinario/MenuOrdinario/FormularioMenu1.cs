using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuOrdinario
{
    public partial class FormularioMenu1 : Form
    {

        #region "Instancias de las clases"
        ErrorProvider error = new ErrorProvider();
        
        Personas p1 = new Personas();
        #endregion


        public FormularioMenu1()
        {
            InitializeComponent();
        }

        #region "Botones"
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarNombre() == false)
            {
                return;
            }
            if (ValidarApellido() == false)
            {
                return;
            }
            if (ValidarEdad() == false)
            {
                return;
            }
           
        
            //Instanciamos las clase persona
            p1 = new Personas();
            p1.Nombre = textBox1.Text;
            p1.Apellido = textBox2.Text;
            p1.Edad = int.Parse(textBox3.Text);
            

            p1.listaPersonas.Add(p1);
            MessageBox.Show("Agregado Exitosamente!!");
            limpiarDatos();

            ListViewItem item = new ListViewItem(p1.Nombre);
            item.SubItems.Add(p1.Apellido);
            item.SubItems.Add(p1.Edad.ToString());

            listView1.Items.Add(item);

        }

        private void button2_Click(object sender, EventArgs e)
        {
             if (p1.Edad >= 18)
             {
                int contadorMayores = p1.listaPersonas.Count;
                MessageBox.Show("Mayores:" + contadorMayores.ToString());
             }
              else
             {
                MessageBox.Show("Ingreso un menor de edad");
             }
      
        }

        #endregion


        #region "Funcion para limpiar campos de texto"
        public void limpiarDatos()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }
        #endregion


        #region "Validaciones"

        private bool ValidarEdad()
        {
            int Edad;
            if (!int.TryParse(textBox3.Text, out Edad) || textBox3.Text == " ")
            {
                error.SetError(textBox3, "Ingresa valor numerico/y no lo dejes vacio");
                return false;
            }
            else
            {
                error.SetError(textBox3, "");
                return true;
            }
        }

        private bool ValidarApellido()
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                error.SetError(textBox2, "No dejes vacio el campo");
                return false;
            }
            else
            {
                error.SetError(textBox2, "");
                return true;
            }
        }

        private bool ValidarNombre()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                error.SetError(textBox1, "No dejes vacio el campo");
                return false;
            }
            else
            {
                error.SetError(textBox1, "");
                return true;
            }
        }

        #endregion
    }
}
