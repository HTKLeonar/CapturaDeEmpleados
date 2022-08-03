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
    public partial class FormularioMenu2 : Form
    {
        #region "Instancias de las clases"
        ErrorProvider error = new ErrorProvider();
        Operarios operarios = new Operarios();
        #endregion

        public FormularioMenu2()
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
            if (ValidarSueldo() == false)
            {
                return;
            }
            if(ValidarPuesto() == false)
            {
                return;
            }

            operarios.Nombre = textBox1.Text;
            operarios.Apellido = textBox2.Text;
            operarios.Sueldo = Convert.ToDouble(textBox3.Text);
            operarios.Ocupacion = textBox4.Text;

            operarios.listaPersonas.Add(operarios);
            MessageBox.Show("Agregado Exitosamente!!");
            limpiarDatos();

            ListViewItem item = new ListViewItem(operarios.Nombre + " " + operarios.Apellido);
            item.SubItems.Add(operarios.Sueldo.ToString());
            item.SubItems.Add(operarios.Ocupacion);

            listView1.Items.Add(item);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operario " + operarios.Nombre + " " + operarios.Apellido + "  Sueldo: " + operarios.Sueldo);
        }

        #endregion


        #region "Funcion para limpiar los campos"
        public void limpiarDatos()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
        #endregion


        #region "Validaciones"
        private bool ValidarPuesto()
        {
            if (string.IsNullOrEmpty(textBox4.Text))
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

        private bool ValidarSueldo()
        {
            double Sueldo;
            if (!double.TryParse(textBox3.Text, out Sueldo) || textBox3.Text == " ")
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
