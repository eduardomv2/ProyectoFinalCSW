using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Vertex
    {
        public string Nombre { get; set; }
        public Point Valor { get; set; }

        public Vertex(string nombre, Point valor)
        {
            Nombre = nombre;
            Valor = valor;
        }
    }
}
