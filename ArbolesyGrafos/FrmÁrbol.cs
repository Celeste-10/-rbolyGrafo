using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ArbolesyGrafos
{
    public partial class FrmÁrbol : Form
    {
        public FrmÁrbol()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbElemento.Text))
            {
                MessageBox.Show("Ingrese un elemento válido");
                return;
            }

            if (tvArbol.SelectedNode != null)
                tvArbol.SelectedNode.Nodes.Add(tbElemento.Text);
            else
                tvArbol.Nodes.Add(tbElemento.Text);

            tbElemento.Clear();
            tbElemento.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbBuscar.Text))
            {
                MessageBox.Show("Ingrese el nodo a buscar.");
                return;
            }

            TreeNode nodo = BuscarNodo(tvArbol.Nodes, tbBuscar.Text);

            if (nodo != null)
            {
                tvArbol.SelectedNode = nodo;
                nodo.Expand();
                MessageBox.Show("Nodo encontrado: " + nodo.Text);
            }
            else
                MessageBox.Show("Nodo NO encontrado.");
        }
        private TreeNode BuscarNodo(TreeNodeCollection nodos, string texto)
        {
            foreach (TreeNode n in nodos)
            {
                if (n.Text.Equals(texto, StringComparison.OrdinalIgnoreCase))
                    return n;

                TreeNode encontrado = BuscarNodo(n.Nodes, texto);
                if (encontrado != null)
                    return encontrado;
            }
            return null;
        }
        private void btnContar_Click(object sender, EventArgs e)
        {
            int total = 0;

            foreach (TreeNode n in tvArbol.Nodes)
                total += Contar(n);

            MessageBox.Show("Total de nodos en el árbol: " + total);
        }
        private int Contar(TreeNode nodo)
        {
            int count = 1;

            foreach (TreeNode hijo in nodo.Nodes)
                count += Contar(hijo);

            return count;
        }

        private void btnRecorrido_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            foreach (TreeNode n in tvArbol.Nodes)
            {
                RecorrerPreorden(n, lista);
            }

            string resultado = string.Join(" → ", lista);
            MessageBox.Show("Recorrido Preorden:\n" + resultado);
        }
        private void RecorrerPreorden(TreeNode nodo, List<string> lista)
        {
            lista.Add(nodo.Text);

            foreach (TreeNode hijo in nodo.Nodes)
                RecorrerPreorden(hijo, lista);
        }

        private void btnNiveles_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();

            foreach (TreeNode n in tvArbol.Nodes)
                ObtenerNiveles(n, 0, lista);

            string resultado = string.Join("\n", lista);
            MessageBox.Show("Niveles del árbol:\n\n" + resultado);
        }
        private void ObtenerNiveles(TreeNode nodo, int nivel, List<string> lista)
        {
            lista.Add($"{nodo.Text} – Nivel {nivel}");

            foreach (TreeNode hijo in nodo.Nodes)
                ObtenerNiveles(hijo, nivel + 1, lista);
        }
    }
}
