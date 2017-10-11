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
        private float horas;
        private float precioHora;

        public Persona(string nombre, string apellidos)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
        }

        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public float Horas { get => horas; set => horas = value; }
        public float PrecioHora { get => precioHora; set => precioHora = value; }

        public float salario()
        {
            return (horas * precioHora) * ((100 - Program.IMPUESTOS) / 100);
        }

        public string toString()
        {
            return nombre + " " + apellidos;
        }
    }
}
