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
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        #region "Menus 1 y 2"
        private void mENÚ1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioMenu1 menu1 = new FormularioMenu1();

            menu1.Show();
        }

        private void mENÚ2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioMenu2 menu2 = new FormularioMenu2();

            menu2.Show();
        }
        #endregion

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void creadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creado por Kevin Hidalgo IGTI 6 Semestre ---> Ejercicio 1");
        }
    }
}
