using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Threading;
using System.Security;

namespace ProyectoFinal
{

    public partial class Form1 : Form
    {
        Random random = new Random();
        Auto auto = new Auto();
        private MyStack<string> stringStack;
        TreeNode root;
        Tree tree; 
        public Form1()
        {
            InitializeComponent();
            stringStack = new MyStack<string>();
            root = new TreeNode("Root");
            tree = new Tree(root);
        }

        #region Listas
        private async void button1_Click(object sender, EventArgs e)
        {
            SimpleList<int> Lista_Simple = new SimpleList<int>();
            auto.Auto_Add_SimpleList(Lista_Simple, random, textBox2, int.Parse(textBox1.Text));
            await Task.Delay(2000);
            auto.Auto_Delete_SimpleList(Lista_Simple, random, textBox2, int.Parse(textBox1.Text));
            await Task.Delay(2000);
            auto.Auto_Search_SimpleList(Lista_Simple, random,textBox2, int.Parse(textBox1.Text));
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            CircularList<int> Circular_List = new CircularList<int>();
            
            auto.Auto_Add_CircularList(Circular_List, random,textBox2,int.Parse(textBox1.Text));
            await Task.Delay(2000);
            auto.Auto_Delete_CircularList(Circular_List, random,textBox2,int.Parse(textBox1.Text));
            await Task.Delay(2000);
            auto.Auto_Search_CircularList(Circular_List, random,textBox2,int.Parse(textBox1.Text));
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            DoublyLinkedList<int> Doubly_List_Linked = new DoublyLinkedList<int>();
            auto.Auto_Add_DoublyListLinked(Doubly_List_Linked, random, textBox2, int.Parse(textBox1.Text));
            await Task.Delay(2000);
            auto.Auto_Delete_DoublyListLinked(Doubly_List_Linked, random, textBox2, int.Parse(textBox1.Text));
            await Task.Delay(2000);
            auto.Auto_Search_DoublyListLinked(Doubly_List_Linked, random, textBox2, int.Parse(textBox1.Text));
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            CircularDoublyLinkedList<int> Circular_Doubly_Linked_List = new CircularDoublyLinkedList<int>();
            auto.Auto_Add_CircularDoublyLinkedList(Circular_Doubly_Linked_List, random, textBox2, int.Parse(textBox1.Text));
            await Task.Delay(2000);
            auto.Auto_Delete_CircularDoublyLinkedList(Circular_Doubly_Linked_List, random, textBox2, int.Parse(textBox1.Text));
            await Task.Delay(2000);
            auto.Auto_Search_CircularDoublyLinkedList(Circular_Doubly_Linked_List, random, textBox2, int.Parse(textBox1.Text));
        }


        #endregion

        #region Pilas
        private void UpdateStackListBox()
        {
            StackListBox.Items.Clear();
            for (int i = stringStack.Count - 1; i >= 0; i--)
            {
                string item = stringStack[i];
                StackListBox.Items.Add(item);
            }
        }
        private void PushButton_Click(object sender, EventArgs e)
        {
            string item = InputTextBox.Text;
            stringStack.Push(item);
            UpdateStackListBox();
            InputTextBox.Clear();
        }

        private void PopButton_Click(object sender, EventArgs e)
        {
            try
            {
                string poppedItem = stringStack.Pop();
                MessageBox.Show("Elemento desapilado: " + poppedItem);
                UpdateStackListBox();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("La pila está vacía. No se pueden desapilar elementos.");
            }
        }

        private void PeekButton_Click(object sender, EventArgs e)
        {
            try
            {
                string topItem = stringStack.Peek();
                MessageBox.Show("Elemento en la cima de la pila: " + topItem);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("La pila está vacía. No hay elementos para ver.");
            }
        }
        #endregion

        private void btnAddTree_Click(object sender, EventArgs e)
        {
            string parentNodeName = txtFather.Text;
            string newNodeName = txtNewNodeTree.Text;
            tree.AddNode(parentNodeName, newNodeName, txtTree);
        }

        private void btnDeleteTree_Click(object sender, EventArgs e)
        {
            string nodeNameToDelete = txtFather.Text;
            tree.DeleteNode(nodeNameToDelete, txtTree);
        }
    }
}
