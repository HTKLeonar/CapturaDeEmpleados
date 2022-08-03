using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuOrdinario
{
    public class Personas
    {

        public List<Personas> listaPersonas = new List<Personas>();//Lista de objetos de la clase personas
        public String Nombre { get; set; }

        public String Apellido { get; set;}

        public int Edad { get; set;}

        public double Sueldo { get; set;}   
    }
}
