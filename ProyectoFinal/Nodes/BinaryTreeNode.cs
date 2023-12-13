using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Nodes
{
    internal class BinaryTreeNode
    {
        public int Value;
        public BinaryTreeNode Left, Right;

        public BinaryTreeNode(int value)
        { 
            Value = value;
            Left = Right = null;
        }
    }
}
