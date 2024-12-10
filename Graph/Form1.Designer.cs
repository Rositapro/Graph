namespace Graph
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddNode = new Button();
            btnAddArista = new Button();
            Nodo = new Label();
            panelGrafo = new Panel();
            label1 = new Label();
            label2 = new Label();
            txtNodeB = new TextBox();
            label3 = new Label();
            numPeso = new NumericUpDown();
            txtNode = new TextBox();
            txtNodeA = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numPeso).BeginInit();
            SuspendLayout();
            // 
            // btnAddNode
            // 
            btnAddNode.Location = new Point(216, 31);
            btnAddNode.Name = "btnAddNode";
            btnAddNode.Size = new Size(75, 23);
            btnAddNode.TabIndex = 1;
            btnAddNode.Text = "Add node";
            btnAddNode.UseVisualStyleBackColor = true;
            btnAddNode.Click += btnAddNode_Click;
            // 
            // btnAddArista
            // 
            btnAddArista.Location = new Point(216, 122);
            btnAddArista.Name = "btnAddArista";
            btnAddArista.Size = new Size(75, 23);
            btnAddArista.TabIndex = 2;
            btnAddArista.Text = "Add arista";
            btnAddArista.UseVisualStyleBackColor = true;
            btnAddArista.Click += btnAddArista_Click;
            // 
            // Nodo
            // 
            Nodo.AutoSize = true;
            Nodo.Location = new Point(12, 32);
            Nodo.Name = "Nodo";
            Nodo.Size = new Size(36, 15);
            Nodo.TabIndex = 4;
            Nodo.Text = "Node";
            // 
            // panelGrafo
            // 
            panelGrafo.Location = new Point(316, 31);
            panelGrafo.Name = "panelGrafo";
            panelGrafo.Size = new Size(275, 202);
            panelGrafo.TabIndex = 7;
            panelGrafo.Paint += panelGrafo_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 69);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 8;
            label1.Text = "Node A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 9;
            label2.Text = "Node B";
            // 
            // txtNodeB
            // 
            txtNodeB.Location = new Point(110, 94);
            txtNodeB.Name = "txtNodeB";
            txtNodeB.Size = new Size(100, 23);
            txtNodeB.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 130);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 11;
            label3.Text = "Weight";
            // 
            // numPeso
            // 
            numPeso.Location = new Point(110, 122);
            numPeso.Name = "numPeso";
            numPeso.Size = new Size(100, 23);
            numPeso.TabIndex = 12;
            // 
            // txtNode
            // 
            txtNode.Location = new Point(110, 29);
            txtNode.Name = "txtNode";
            txtNode.Size = new Size(100, 23);
            txtNode.TabIndex = 13;
            // 
            // txtNodeA
            // 
            txtNodeA.Location = new Point(110, 65);
            txtNodeA.Name = "txtNodeA";
            txtNodeA.Size = new Size(100, 23);
            txtNodeA.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNodeA);
            Controls.Add(txtNode);
            Controls.Add(numPeso);
            Controls.Add(label3);
            Controls.Add(txtNodeB);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panelGrafo);
            Controls.Add(Nodo);
            Controls.Add(btnAddArista);
            Controls.Add(btnAddNode);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numPeso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewMatriz;
        private Button btnAddNode;
        private Button btnAddArista;
        private TextBox txtNodo;
        private Label Nodo;
        private TextBox txtNodoA;
        private Label lblResultado;
        private Panel panelGrafo;
        private Label label1;
        private Label label2;
        private TextBox txtNodeB;
        private Label label3;
        private NumericUpDown numPeso;
        private TextBox txtNode;
        private TextBox txtNodeA;
    }
}
