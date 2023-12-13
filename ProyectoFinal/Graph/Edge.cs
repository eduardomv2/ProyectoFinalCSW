﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Edge
    {
        public Vertex Origen { get; set; }
        public Vertex Destino { get; set; }

        public Edge(Vertex origen, Vertex destino)
        {
            Origen = origen; 
            Destino = destino;
        }
    }
}
