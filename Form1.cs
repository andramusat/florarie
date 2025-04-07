using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace florarie
{
    public partial class Florarie : Form
    {
        bool seInchide = false;
        public Florarie()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVizualizare_Click(object sender, EventArgs e)
        {
            if (tbUtilizator.Text == "andramusat" && tbParola.Text == "stud")
            {
                Produse fmProduse = new Produse();
                fmProduse.ShowDialog();
            }
            else
            {
                MessageBox.Show("Date introduse invalide.");
            }
        }

        private void Florarie_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbParola_TextChanged(object sender, EventArgs e)
        {

        }

        private void Florarie_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!seInchide)
            {
                seInchide = true;
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    Form form = Application.OpenForms[i];
                    if (form != this) 
                    {
                        form.Close();
                    }
                }
            }
            
        }
    }
}
