using ProyectoFinal.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class BinaryTreeSort
    {
        private BinaryTreeNode root;
        private int index = 0;
        public void Sort(int[] arr)
        {
            // Construir el árbol binario
            foreach (var value in arr)
            {
                root = Insert(root, value);
            }

            // Recorrer el árbol en orden para obtener los elementos ordenados
            InOrderTraversal(root, arr, ref index);
        }
        private BinaryTreeNode Insert(BinaryTreeNode node, int value)
        {
            if (node == null)
            {
                return new BinaryTreeNode(value);
            }

            if (value < node.Value)
            {
                node.Left = Insert(node.Left, value);
            }
            else if (value > node.Value)
            {
                node.Right = Insert(node.Right, value);
            }

            return node;
        }
        private void InOrderTraversal(BinaryTreeNode node, int[] arr, ref int index)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left, arr, ref index);
                arr[index++] = node.Value;
                InOrderTraversal(node.Right, arr, ref index);
            }
        }
    }
}
