using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Lista3_ListDataGridView
{
    class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;
        public Persona(string nom, string ap, int ed)
        {
            nombre = nom;
            apellido = ap;
            edad = ed;
        }
        public Persona()
        {
            nombre = string.Empty;
            apellido = string.Empty;
            edad = 0;
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
    }
}
