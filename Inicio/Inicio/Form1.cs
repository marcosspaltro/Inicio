using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBorrar(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)

                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void btnagregar(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(buscar.FileName);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
        }

        private void btninicio_Click(object sender, EventArgs e)
        { if (listBox1.SelectedIndex != -1)
            System.Diagnostics.Process.Start(listBox1.Text);
            listBox1.SelectedIndex =  listBox1.SelectedIndex + 1;
        }
    }
}
