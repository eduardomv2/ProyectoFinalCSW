using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    internal class Tree
    {
        public TreeNode Root { get; set; }

        public Tree(TreeNode root)
        {
            Root = root;
        }

        public void PrintTree(TreeNode node, TextBox textBox, string indent = "")
        {
            textBox.Text += (indent + $"└─  {node.Name}\r\n");

            for (int i = 0; i < node.Children.Count; i++)
            {
                PrintTree(node.Children[i], textBox, indent + "   ");
            }
        }

        public TreeNode FindNode(string nodeName, TreeNode node = null)
        {
            if (node == null)
                node = Root;

            if (node.Name == nodeName)
                return node;

            foreach (var child in node.Children)
            {
                var foundNode = FindNode(nodeName, child);
                if (foundNode != null)
                    return foundNode;
            }

            return null;
        }

        public async void AddNode(string parentNodeName, string newNodeName, TextBox textBox)
        {
            var parentNode = FindNode(parentNodeName);
            if (parentNode != null)
            {
                parentNode.Children.Add(new TreeNode(newNodeName));
                textBox.Text = string.Empty;
                PrintTree(Root, textBox);
            }
            else
            {
                textBox.Text = ($"parent node not found '{parentNodeName}'.");
                await Task.Delay(2000);
                textBox.Text = string.Empty;
                PrintTree(Root, textBox);
            }
        }

        

        public async void DeleteNode(string nodeName, TextBox textBox)
        {
            var nodeToDelete = FindNode(nodeName);
            if (nodeToDelete != null)
            {
                var parent = FindParentNode(nodeName);

                if (nodeToDelete == Root)
                {
                    // Deleting the root node
                    if (nodeToDelete.Children.Count > 0)
                    {
                        // Assign the first child as the new root
                        Root = nodeToDelete.Children[0];
                        textBox.Text = ($"The root node '{nodeName}' was deleted, and the first child became the new root..");
                    }
                    else
                    {
                        Root = null;
                        textBox.Text = ($"The root node '{nodeName}' was deleted");
                    }
                }
                else if (parent != null)
                {
                    if (nodeToDelete.Children.Count > 0)
                    {
                        // Convertir el primer hijo en el nuevo padre
                        var firstChild = nodeToDelete.Children[0];
                        firstChild.Children.AddRange(nodeToDelete.Children.Skip(1));
                        parent.Children.Insert(parent.Children.IndexOf(nodeToDelete), firstChild);
                    }
                    parent.Children.Remove(nodeToDelete);
                    textBox.Text = ($"The node '{nodeName}' was deleted, and the first child became the new parent without changing the branch position.");
                }
                await Task.Delay(2000);
                textBox.Text = string.Empty;
                PrintTree(Root, textBox);
            }
            else
            {
                textBox.Text = ($"Node '{nodeName} not found'.");
            }
        }

        private TreeNode FindParentNode(string nodeName, TreeNode node = null)
        {
            if (node == null)
                node = Root;

            foreach (var child in node.Children)
            {
                if (child.Name == nodeName)
                    return node;

                var parent = FindParentNode(nodeName, child);
                if (parent != null)
                    return parent;
            }

            return null;
        }
    }
}
