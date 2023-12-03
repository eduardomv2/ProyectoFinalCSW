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
        Random random;
        Auto auto;
        private MyStack<string> stringStack;
        TreeNode root;
        Tree tree;
        private Queue<string> cola;
        private LinkedList<string> bicola;
        private Grafo grafo;
        private SortedDictionary<int, Queue<string>> colaPrioridad;



        public Form1()
        {
            InitializeComponent();
            random = new Random();
            auto = new Auto();
            stringStack = new MyStack<string>();
            root = new TreeNode("Root");
            tree = new Tree(root);
            cola = new Queue<string>();
            bicola = new LinkedList<string>();
            grafo = new Grafo();
            colaPrioridad = new SortedDictionary<int, Queue<string>>();
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

        #region Tree
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
        #endregion

        #region Queues
        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            // Agregar un elemento a la cola
            string elemento = txtQueue.Text;
            cola.Enqueue(elemento);

            // Actualizar la lista de elementos en la cola
            ActualizarListaCola();
        }
        private void ActualizarListaCola()
        {
            // Mostrar la cola en el ListBox
            lstvQueue.Items.Clear();
            foreach (string elemento in cola)
            {
               lstvQueue.Items.Add(elemento);
            }
        }
        private void btnDequeue_Click(object sender, EventArgs e)
        {
            // Verificar si la cola no está vacía antes de intentar eliminar
            if (cola.Count > 0)
            {
                // Eliminar el elemento de la cola
                string elementoEliminado = cola.Dequeue();

                // Mostrar un mensaje con el elemento eliminado
                MessageBox.Show($"Se eliminó el elemento: {elementoEliminado}");

                // Actualizar la lista de elementos en la cola
                ActualizarListaCola();
            }
            else
            {
                MessageBox.Show("La cola está vacía. No se pueden eliminar elementos.");
            }
        }
        private void ActualizarListaBicola()
        {
            // Mostrar la bicola en el ListBox
            lstvDeque.Items.Clear();
            foreach (string elemento in bicola)
            {
                lstvDeque.Items.Add(elemento);
            }
        }
        private void btnEnqueueFirst_Click(object sender, EventArgs e)
        {
            // Agregar un elemento al inicio de la bicola
            string elemento = txtDeque.Text;
            bicola.AddFirst(elemento);

            // Actualizar la lista de elementos en la bicola
            ActualizarListaBicola();
        }
        private void btnEnqueueLast_Click(object sender, EventArgs e)
        {
            // Agregar un elemento al final de la bicola
            string elemento = txtDeque.Text;
            bicola.AddLast(elemento);

            // Actualizar la lista de elementos en la bicola
            ActualizarListaBicola();
        }

        private void btnDequeueFirst_Click(object sender, EventArgs e)
        {
            // Verificar si la bicola no está vacía antes de intentar eliminar al inicio
            if (bicola.Count > 0)
            {
                // Eliminar el elemento al inicio de la bicola
                string elementoEliminado = bicola.First.Value;
                bicola.RemoveFirst();

                // Mostrar un mensaje con el elemento eliminado
                MessageBox.Show($"Se eliminó el elemento al inicio: {elementoEliminado}");

                // Actualizar la lista de elementos en la bicola
                ActualizarListaBicola();
            }
            else
            {
                MessageBox.Show("La bicola está vacía. No se pueden eliminar elementos al inicio.");
            }
        }

        private void btnDequeueLast_Click(object sender, EventArgs e)
        {
            // Verificar si la bicola no está vacía antes de intentar eliminar al final
            if (bicola.Count > 0)
            {
                // Eliminar el elemento al final de la bicola
                string elementoEliminado = bicola.Last.Value;
                bicola.RemoveLast();

                // Mostrar un mensaje con el elemento eliminado
                MessageBox.Show($"Se eliminó el elemento al final: {elementoEliminado}");

                // Actualizar la lista de elementos en la bicola
                ActualizarListaBicola();
            }
            else
            {
                MessageBox.Show("La bicola está vacía. No se pueden eliminar elementos al final.");
            }
        }

        private void btnEnqueuePrior_Click(object sender, EventArgs e)
        {
            string elemento = txtPriorityQueue.Text;
            int prioridad;

            if (int.TryParse(txtPriorityQueue.Text, out prioridad))
            {
                if (!colaPrioridad.ContainsKey(prioridad))
                {
                    colaPrioridad[prioridad] = new Queue<string>();
                }

                colaPrioridad[prioridad].Enqueue(elemento);

                // Actualizar la lista de elementos en la cola de prioridad
                ActualizarListaColaPrioridad();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una prioridad válida (número entero).");
            }
        }

        private void btnDequeuePiror_Click(object sender, EventArgs e)
        {
            // Verificar si la cola de prioridad no está vacía antes de intentar eliminar
            if (colaPrioridad.Count > 0)
            {
                // Encontrar la cola con la prioridad más baja
                var primeraCola = colaPrioridad.Keys.Min();
                var elementoEliminado = colaPrioridad[primeraCola].Dequeue();

                // Si la cola está vacía, eliminarla de la cola de prioridad
                if (colaPrioridad[primeraCola].Count == 0)
                {
                    colaPrioridad.Remove(primeraCola);
                }

                // Mostrar un mensaje con el elemento eliminado
                MessageBox.Show($"Se eliminó el elemento: {elementoEliminado}");

                // Actualizar la lista de elementos en la cola de prioridad
                ActualizarListaColaPrioridad();
            }
            else
            {
                MessageBox.Show("La cola de prioridad está vacía. No se pueden eliminar elementos.");
            }
        }
        private void ActualizarListaColaPrioridad()
        {
            // Mostrar la cola de prioridad en el ListBox
            lstvPriorityQueue.Items.Clear();
            foreach (var kvp in colaPrioridad)
            {
                foreach (var elemento in kvp.Value)
                {
                    lstvPriorityQueue.Items.Add($"{elemento} - Prioridad: {kvp.Key}");
                }
            }
        }


        #endregion

        #region Graphs

        #endregion

        private void btnAddVertex_Click(object sender, EventArgs e)
        {
            string vertice = txtVertex.Text;

            // Añadir vértice al grafo
            grafo.AgregarVertice(vertice);

            // Actualizar la visualización del grafo
            ActualizarVisualizacionGrafo();
        }

        private void btnAddEdge_Click(object sender, EventArgs e)
        {
            string origen = txtOrigin.Text;
            string destino = txtDestination.Text;

            // Añadir arista al grafo
            grafo.AgregarArista(origen, destino);

            // Actualizar la visualización del grafo
            ActualizarVisualizacionGrafo();
        }
        private void ActualizarVisualizacionGrafo()
        {
            // Crear una imagen para visualizar el grafo
            Bitmap imagenGrafo = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(imagenGrafo))
            {
                // Dibujar los vértices
                foreach (var vertice in grafo.Vertices)
                {
                    g.FillEllipse(Brushes.Blue, vertice.Valor.X, vertice.Valor.Y, 30, 30);
                    g.DrawString(vertice.Nombre, DefaultFont, Brushes.White, vertice.Valor.X + 8, vertice.Valor.Y + 8);
                }

                // Dibujar las aristas
                foreach (var arista in grafo.Aristas)
                {
                    g.DrawLine(Pens.Black, arista.Origen.Valor.X + 15, arista.Origen.Valor.Y + 15,
                                         arista.Destino.Valor.X + 15, arista.Destino.Valor.Y + 15);
                }
            }

            // Mostrar la imagen del grafo en el PictureBox
            pictureBox1.Image = imagenGrafo;
        }
    }
}
