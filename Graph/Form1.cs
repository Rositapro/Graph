using System.Data;

namespace Graph
{
    public partial class Form1 : Form
    {

        Graph miGrafo = new Graph();
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();

        }

        private void btnAddNode_Click(object sender, EventArgs e)
        {
            string nodo = txtNode.Text;
            if (!string.IsNullOrEmpty(nodo))
            {
                miGrafo.AddNode(nodo);
                panelGrafo.Invalidate(); // Redibujar el panel
            }
        }

        private void btnAddArista_Click(object sender, EventArgs e)
        {
            string nodeA = txtNodeA.Text;
            string nodeB = txtNodeB.Text;
            int weight = (int)numPeso.Value;

            if (!string.IsNullOrEmpty(nodeA) && !string.IsNullOrEmpty(nodeB))
            {
                miGrafo.AddAristas(nodeA, nodeB, weight);
                MessageBox.Show($"Arista agregada: {nodeA} - {nodeB} con peso {weight}");
                panelGrafo.Invalidate(); 
            }
            else
            {
                MessageBox.Show("Enter valid names for Node A and Node B.");
            }
        }
        private void panelGrafo_Paint(object sender, PaintEventArgs e)
        {
            DibujarGrafo(e.Graphics, miGrafo);
        }

        private void DibujarGrafo(Graphics g, Graph grafo)
        {
            Dictionary<string, Point> posiciones = new Dictionary<string, Point>();
            Random rnd = new Random();

            foreach (var nodo in grafo.Nodos)
            {
                if (!posiciones.ContainsKey(nodo))
                {
                    posiciones[nodo] = new Point(rnd.Next(50, panelGrafo.Width - 50),
                                                 rnd.Next(50, panelGrafo.Height - 50));
                }
            }

            // Dibujar aristas
            Pen penArista = new Pen(Color.Black, 2);
            foreach (var arista in grafo.Aristas)
            {
                if (posiciones.ContainsKey(arista.Item1) && posiciones.ContainsKey(arista.Item2))
                {
                    Point p1 = posiciones[arista.Item1];
                    Point p2 = posiciones[arista.Item2];

                    g.DrawLine(penArista, p1, p2);

                    string peso = arista.Item3.ToString();
                    g.DrawString(peso, new Font("Arial", 10), Brushes.Red,
                                 (p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
                }
            }

            foreach (var nodo in grafo.Nodos)
            {
                Point pos = posiciones[nodo];
                g.FillEllipse(Brushes.LightBlue, pos.X - 20, pos.Y - 20, 40, 40); 
                g.DrawEllipse(Pens.Black, pos.X - 20, pos.Y - 20, 40, 40);        
                g.DrawString(nodo, new Font("Arial", 12), Brushes.Black, pos.X - 10, pos.Y - 10); 
            }
        }

    }
}