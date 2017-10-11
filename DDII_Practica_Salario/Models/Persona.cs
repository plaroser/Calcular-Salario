using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDII_Practica_Salario.Models
{
    class Persona
    {
        private string nombre;
        private string apellidos;

        public Persona(string nombre, string apellidos)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
        }

        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        
        public string toString()
        {
            return Apellidos + ", " + nombre;
        }
        
    }
}
