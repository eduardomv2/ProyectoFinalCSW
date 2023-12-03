namespace ProyectoFinal
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSimpleList = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.StackListBox = new System.Windows.Forms.ListBox();
            this.PeekButton = new System.Windows.Forms.Button();
            this.PopButton = new System.Windows.Forms.Button();
            this.PushButton = new System.Windows.Forms.Button();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.lblDato = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lstvPriorityQueue = new System.Windows.Forms.ListView();
            this.txtPriorityQueue = new System.Windows.Forms.TextBox();
            this.btnDequeuePiror = new System.Windows.Forms.Button();
            this.btnEnqueuePrior = new System.Windows.Forms.Button();
            this.btnDequeueLast = new System.Windows.Forms.Button();
            this.btnDequeueFirst = new System.Windows.Forms.Button();
            this.lstvDeque = new System.Windows.Forms.ListView();
            this.btnEnqueueLast = new System.Windows.Forms.Button();
            this.btnEnqueueFirst = new System.Windows.Forms.Button();
            this.txtDeque = new System.Windows.Forms.TextBox();
            this.lstvQueue = new System.Windows.Forms.ListView();
            this.btnDequeue = new System.Windows.Forms.Button();
            this.txtQueue = new System.Windows.Forms.TextBox();
            this.btnEnqueue = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtTree = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewNodeTree = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteTree = new System.Windows.Forms.Button();
            this.btnAddTree = new System.Windows.Forms.Button();
            this.txtFather = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnAddVertex = new System.Windows.Forms.Button();
            this.btnAddEdge = new System.Windows.Forms.Button();
            this.txtVertex = new System.Windows.Forms.TextBox();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(887, 508);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.lblSimpleList);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(879, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lists";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(324, 272);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(199, 55);
            this.button4.TabIndex = 7;
            this.button4.Text = "Circular Doubly Linked List";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(68, 283);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 33);
            this.button3.TabIndex = 6;
            this.button3.Text = "Doubly Linked List";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(324, 174);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "Circular List";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(575, 16);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(268, 418);
            this.textBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(68, 174);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Simple List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(324, 110);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 27);
            this.textBox1.TabIndex = 2;
            // 
            // lblSimpleList
            // 
            this.lblSimpleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimpleList.Location = new System.Drawing.Point(27, 91);
            this.lblSimpleList.Name = "lblSimpleList";
            this.lblSimpleList.Size = new System.Drawing.Size(292, 60);
            this.lblSimpleList.TabIndex = 1;
            this.lblSimpleList.Text = "How many integers would you like to add?";
            this.lblSimpleList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.StackListBox);
            this.tabPage2.Controls.Add(this.PeekButton);
            this.tabPage2.Controls.Add(this.PopButton);
            this.tabPage2.Controls.Add(this.PushButton);
            this.tabPage2.Controls.Add(this.InputTextBox);
            this.tabPage2.Controls.Add(this.lblDato);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(879, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stack";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // StackListBox
            // 
            this.StackListBox.FormattingEnabled = true;
            this.StackListBox.ItemHeight = 25;
            this.StackListBox.Location = new System.Drawing.Point(567, 28);
            this.StackListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StackListBox.Name = "StackListBox";
            this.StackListBox.Size = new System.Drawing.Size(269, 379);
            this.StackListBox.TabIndex = 5;
            // 
            // PeekButton
            // 
            this.PeekButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeekButton.Location = new System.Drawing.Point(261, 295);
            this.PeekButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PeekButton.Name = "PeekButton";
            this.PeekButton.Size = new System.Drawing.Size(232, 38);
            this.PeekButton.TabIndex = 4;
            this.PeekButton.Text = "Peek (Show Only)";
            this.PeekButton.UseVisualStyleBackColor = true;
            this.PeekButton.Click += new System.EventHandler(this.PeekButton_Click);
            // 
            // PopButton
            // 
            this.PopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopButton.Location = new System.Drawing.Point(261, 206);
            this.PopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PopButton.Name = "PopButton";
            this.PopButton.Size = new System.Drawing.Size(232, 38);
            this.PopButton.TabIndex = 3;
            this.PopButton.Text = "Pop (Delete)";
            this.PopButton.UseVisualStyleBackColor = true;
            this.PopButton.Click += new System.EventHandler(this.PopButton_Click);
            // 
            // PushButton
            // 
            this.PushButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PushButton.Location = new System.Drawing.Point(261, 117);
            this.PushButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PushButton.Name = "PushButton";
            this.PushButton.Size = new System.Drawing.Size(232, 38);
            this.PushButton.TabIndex = 2;
            this.PushButton.Text = "Push (Add)";
            this.PushButton.UseVisualStyleBackColor = true;
            this.PushButton.Click += new System.EventHandler(this.PushButton_Click);
            // 
            // InputTextBox
            // 
            this.InputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTextBox.Location = new System.Drawing.Point(65, 119);
            this.InputTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(125, 30);
            this.InputTextBox.TabIndex = 1;
            // 
            // lblDato
            // 
            this.lblDato.AutoSize = true;
            this.lblDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDato.Location = new System.Drawing.Point(60, 91);
            this.lblDato.Name = "lblDato";
            this.lblDato.Size = new System.Drawing.Size(146, 25);
            this.lblDato.TabIndex = 0;
            this.lblDato.Text = "Data (STRING)";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lstvPriorityQueue);
            this.tabPage3.Controls.Add(this.txtPriorityQueue);
            this.tabPage3.Controls.Add(this.btnDequeuePiror);
            this.tabPage3.Controls.Add(this.btnEnqueuePrior);
            this.tabPage3.Controls.Add(this.btnDequeueLast);
            this.tabPage3.Controls.Add(this.btnDequeueFirst);
            this.tabPage3.Controls.Add(this.lstvDeque);
            this.tabPage3.Controls.Add(this.btnEnqueueLast);
            this.tabPage3.Controls.Add(this.btnEnqueueFirst);
            this.tabPage3.Controls.Add(this.txtDeque);
            this.tabPage3.Controls.Add(this.lstvQueue);
            this.tabPage3.Controls.Add(this.btnDequeue);
            this.tabPage3.Controls.Add(this.txtQueue);
            this.tabPage3.Controls.Add(this.btnEnqueue);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(879, 470);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Queue";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lstvPriorityQueue
            // 
            this.lstvPriorityQueue.HideSelection = false;
            this.lstvPriorityQueue.Location = new System.Drawing.Point(595, 137);
            this.lstvPriorityQueue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstvPriorityQueue.Name = "lstvPriorityQueue";
            this.lstvPriorityQueue.Size = new System.Drawing.Size(257, 308);
            this.lstvPriorityQueue.TabIndex = 18;
            this.lstvPriorityQueue.UseCompatibleStateImageBehavior = false;
            // 
            // txtPriorityQueue
            // 
            this.txtPriorityQueue.Location = new System.Drawing.Point(595, 50);
            this.txtPriorityQueue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPriorityQueue.Name = "txtPriorityQueue";
            this.txtPriorityQueue.Size = new System.Drawing.Size(257, 30);
            this.txtPriorityQueue.TabIndex = 17;
            // 
            // btnDequeuePiror
            // 
            this.btnDequeuePiror.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDequeuePiror.Location = new System.Drawing.Point(733, 98);
            this.btnDequeuePiror.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDequeuePiror.Name = "btnDequeuePiror";
            this.btnDequeuePiror.Size = new System.Drawing.Size(119, 33);
            this.btnDequeuePiror.TabIndex = 16;
            this.btnDequeuePiror.Text = "Dequeue";
            this.btnDequeuePiror.UseVisualStyleBackColor = true;
            this.btnDequeuePiror.Click += new System.EventHandler(this.btnDequeuePiror_Click);
            // 
            // btnEnqueuePrior
            // 
            this.btnEnqueuePrior.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnqueuePrior.Location = new System.Drawing.Point(595, 98);
            this.btnEnqueuePrior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnqueuePrior.Name = "btnEnqueuePrior";
            this.btnEnqueuePrior.Size = new System.Drawing.Size(121, 33);
            this.btnEnqueuePrior.TabIndex = 15;
            this.btnEnqueuePrior.Text = "Enqueue";
            this.btnEnqueuePrior.UseVisualStyleBackColor = true;
            this.btnEnqueuePrior.Click += new System.EventHandler(this.btnEnqueuePrior_Click);
            // 
            // btnDequeueLast
            // 
            this.btnDequeueLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDequeueLast.Location = new System.Drawing.Point(413, 137);
            this.btnDequeueLast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDequeueLast.Name = "btnDequeueLast";
            this.btnDequeueLast.Size = new System.Drawing.Size(132, 33);
            this.btnDequeueLast.TabIndex = 14;
            this.btnDequeueLast.Text = "Dequeue Last";
            this.btnDequeueLast.UseVisualStyleBackColor = true;
            this.btnDequeueLast.Click += new System.EventHandler(this.btnDequeueLast_Click);
            // 
            // btnDequeueFirst
            // 
            this.btnDequeueFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDequeueFirst.Location = new System.Drawing.Point(413, 98);
            this.btnDequeueFirst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDequeueFirst.Name = "btnDequeueFirst";
            this.btnDequeueFirst.Size = new System.Drawing.Size(132, 33);
            this.btnDequeueFirst.TabIndex = 13;
            this.btnDequeueFirst.Text = "Dequeue First";
            this.btnDequeueFirst.UseVisualStyleBackColor = true;
            this.btnDequeueFirst.Click += new System.EventHandler(this.btnDequeueFirst_Click);
            // 
            // lstvDeque
            // 
            this.lstvDeque.HideSelection = false;
            this.lstvDeque.Location = new System.Drawing.Point(275, 176);
            this.lstvDeque.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstvDeque.Name = "lstvDeque";
            this.lstvDeque.Size = new System.Drawing.Size(271, 269);
            this.lstvDeque.TabIndex = 12;
            this.lstvDeque.UseCompatibleStateImageBehavior = false;
            // 
            // btnEnqueueLast
            // 
            this.btnEnqueueLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnqueueLast.Location = new System.Drawing.Point(275, 137);
            this.btnEnqueueLast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnqueueLast.Name = "btnEnqueueLast";
            this.btnEnqueueLast.Size = new System.Drawing.Size(132, 33);
            this.btnEnqueueLast.TabIndex = 10;
            this.btnEnqueueLast.Text = "Enqueue Last";
            this.btnEnqueueLast.UseVisualStyleBackColor = true;
            this.btnEnqueueLast.Click += new System.EventHandler(this.btnEnqueueLast_Click);
            // 
            // btnEnqueueFirst
            // 
            this.btnEnqueueFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnqueueFirst.Location = new System.Drawing.Point(275, 98);
            this.btnEnqueueFirst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnqueueFirst.Name = "btnEnqueueFirst";
            this.btnEnqueueFirst.Size = new System.Drawing.Size(132, 33);
            this.btnEnqueueFirst.TabIndex = 8;
            this.btnEnqueueFirst.Text = "Enqueue First";
            this.btnEnqueueFirst.UseVisualStyleBackColor = true;
            this.btnEnqueueFirst.Click += new System.EventHandler(this.btnEnqueueFirst_Click);
            // 
            // txtDeque
            // 
            this.txtDeque.Location = new System.Drawing.Point(275, 62);
            this.txtDeque.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeque.Name = "txtDeque";
            this.txtDeque.Size = new System.Drawing.Size(271, 30);
            this.txtDeque.TabIndex = 7;
            // 
            // lstvQueue
            // 
            this.lstvQueue.HideSelection = false;
            this.lstvQueue.Location = new System.Drawing.Point(5, 137);
            this.lstvQueue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstvQueue.Name = "lstvQueue";
            this.lstvQueue.Size = new System.Drawing.Size(212, 308);
            this.lstvQueue.TabIndex = 6;
            this.lstvQueue.UseCompatibleStateImageBehavior = false;
            // 
            // btnDequeue
            // 
            this.btnDequeue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDequeue.Location = new System.Drawing.Point(124, 98);
            this.btnDequeue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDequeue.Name = "btnDequeue";
            this.btnDequeue.Size = new System.Drawing.Size(93, 33);
            this.btnDequeue.TabIndex = 5;
            this.btnDequeue.Text = "Dequeue";
            this.btnDequeue.UseVisualStyleBackColor = true;
            this.btnDequeue.Click += new System.EventHandler(this.btnDequeue_Click);
            // 
            // txtQueue
            // 
            this.txtQueue.Location = new System.Drawing.Point(5, 62);
            this.txtQueue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQueue.Name = "txtQueue";
            this.txtQueue.Size = new System.Drawing.Size(212, 30);
            this.txtQueue.TabIndex = 4;
            // 
            // btnEnqueue
            // 
            this.btnEnqueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnqueue.Location = new System.Drawing.Point(5, 98);
            this.btnEnqueue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnqueue.Name = "btnEnqueue";
            this.btnEnqueue.Size = new System.Drawing.Size(93, 33);
            this.btnEnqueue.TabIndex = 3;
            this.btnEnqueue.Text = "Enqueue";
            this.btnEnqueue.UseVisualStyleBackColor = true;
            this.btnEnqueue.Click += new System.EventHandler(this.btnEnqueue_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(653, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Priority Queue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Double Ended Queue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Queue";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtTree);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.txtNewNodeTree);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.btnDeleteTree);
            this.tabPage4.Controls.Add(this.btnAddTree);
            this.tabPage4.Controls.Add(this.txtFather);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Size = new System.Drawing.Size(879, 470);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tree";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtTree
            // 
            this.txtTree.Location = new System.Drawing.Point(472, 17);
            this.txtTree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTree.Multiline = true;
            this.txtTree.Name = "txtTree";
            this.txtTree.Size = new System.Drawing.Size(383, 418);
            this.txtTree.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(277, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 169);
            this.label3.TabIndex = 7;
            this.label3.Text = "Write the name of the node that you want to delete in the Father Node TextBox.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNewNodeTree
            // 
            this.txtNewNodeTree.Location = new System.Drawing.Point(89, 175);
            this.txtNewNodeTree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewNodeTree.Name = "txtNewNodeTree";
            this.txtNewNodeTree.Size = new System.Drawing.Size(351, 30);
            this.txtNewNodeTree.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "New Node Name:";
            // 
            // btnDeleteTree
            // 
            this.btnDeleteTree.Location = new System.Drawing.Point(283, 238);
            this.btnDeleteTree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteTree.Name = "btnDeleteTree";
            this.btnDeleteTree.Size = new System.Drawing.Size(157, 34);
            this.btnDeleteTree.TabIndex = 4;
            this.btnDeleteTree.Text = "Delete";
            this.btnDeleteTree.UseVisualStyleBackColor = true;
            this.btnDeleteTree.Click += new System.EventHandler(this.btnDeleteTree_Click);
            // 
            // btnAddTree
            // 
            this.btnAddTree.Location = new System.Drawing.Point(89, 238);
            this.btnAddTree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTree.Name = "btnAddTree";
            this.btnAddTree.Size = new System.Drawing.Size(157, 34);
            this.btnAddTree.TabIndex = 3;
            this.btnAddTree.Text = "Add";
            this.btnAddTree.UseVisualStyleBackColor = true;
            this.btnAddTree.Click += new System.EventHandler(this.btnAddTree_Click);
            // 
            // txtFather
            // 
            this.txtFather.Location = new System.Drawing.Point(89, 96);
            this.txtFather.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFather.Name = "txtFather";
            this.txtFather.Size = new System.Drawing.Size(351, 30);
            this.txtFather.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Father Node Name:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.pictureBox1);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.txtDestination);
            this.tabPage5.Controls.Add(this.txtOrigin);
            this.tabPage5.Controls.Add(this.txtVertex);
            this.tabPage5.Controls.Add(this.btnAddEdge);
            this.tabPage5.Controls.Add(this.btnAddVertex);
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Size = new System.Drawing.Size(879, 470);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Graph";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnAddVertex
            // 
            this.btnAddVertex.Location = new System.Drawing.Point(229, 60);
            this.btnAddVertex.Name = "btnAddVertex";
            this.btnAddVertex.Size = new System.Drawing.Size(131, 37);
            this.btnAddVertex.TabIndex = 0;
            this.btnAddVertex.Text = "Add Vertex";
            this.btnAddVertex.UseVisualStyleBackColor = true;
            this.btnAddVertex.Click += new System.EventHandler(this.btnAddVertex_Click);
            // 
            // btnAddEdge
            // 
            this.btnAddEdge.Location = new System.Drawing.Point(130, 301);
            this.btnAddEdge.Name = "btnAddEdge";
            this.btnAddEdge.Size = new System.Drawing.Size(131, 37);
            this.btnAddEdge.TabIndex = 1;
            this.btnAddEdge.Text = "Add Edge";
            this.btnAddEdge.UseVisualStyleBackColor = true;
            this.btnAddEdge.Click += new System.EventHandler(this.btnAddEdge_Click);
            // 
            // txtVertex
            // 
            this.txtVertex.Location = new System.Drawing.Point(33, 63);
            this.txtVertex.Name = "txtVertex";
            this.txtVertex.Size = new System.Drawing.Size(169, 30);
            this.txtVertex.TabIndex = 2;
            // 
            // txtOrigin
            // 
            this.txtOrigin.Location = new System.Drawing.Point(33, 177);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(169, 30);
            this.txtOrigin.TabIndex = 3;
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(33, 245);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(169, 30);
            this.txtDestination.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Origin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Destination";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(436, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 460);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 532);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblSimpleList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblDato;
        private System.Windows.Forms.ListBox StackListBox;
        private System.Windows.Forms.Button PeekButton;
        private System.Windows.Forms.Button PopButton;
        private System.Windows.Forms.Button PushButton;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnDeleteTree;
        private System.Windows.Forms.Button btnAddTree;
        private System.Windows.Forms.TextBox txtFather;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewNodeTree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtTree;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEnqueue;
        private System.Windows.Forms.Button btnDequeue;
        private System.Windows.Forms.TextBox txtQueue;
        private System.Windows.Forms.ListView lstvQueue;
        private System.Windows.Forms.ListView lstvDeque;
        private System.Windows.Forms.Button btnEnqueueLast;
        private System.Windows.Forms.Button btnEnqueueFirst;
        private System.Windows.Forms.TextBox txtDeque;
        private System.Windows.Forms.Button btnDequeueFirst;
        private System.Windows.Forms.Button btnDequeueLast;
        private System.Windows.Forms.TextBox txtPriorityQueue;
        private System.Windows.Forms.Button btnDequeuePiror;
        private System.Windows.Forms.Button btnEnqueuePrior;
        private System.Windows.Forms.ListView lstvPriorityQueue;
        private System.Windows.Forms.Button btnAddVertex;
        private System.Windows.Forms.Button btnAddEdge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.TextBox txtVertex;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

