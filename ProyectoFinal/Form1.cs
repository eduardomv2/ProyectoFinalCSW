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
        public Form1()
        {
            InitializeComponent();
        }

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
    }
}
