using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using florarie.Repositories;

namespace florarie
{
    public partial class FormProduse : Form
    {
        public Produs produsNou;
        ProduseFunctii produseFunctii = new ProduseFunctii();
        public FormProduse(Produs produs)
        {
            InitializeComponent();
            if(produs == null)
            {
                produsNou = new Produs();
                btnAdauga.Text = "Adaugă";
                produsNou.Id = produseFunctii.getMaxID() + 1;
            }
            else
            {
                btnAdauga.Text = "Editează";
                tbDenumire.Text = produs.Denumire;
                tbDescriere.Text = produs.Descriere;
                tbPret.Text = produs.Pret.ToString();
                tbProducator.Text = produs.Producator;
                produsNou = produs;
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            produsNou.Denumire = tbDenumire.Text;
            produsNou.Descriere = tbDescriere.Text;
            string eroare = "";
            double pret;
            if(double.TryParse(tbPret.Text, out pret))
            {
                produsNou.Pret = double.Parse(tbPret.Text);
            }
            else
            {
                eroare = "Prețul trebuie să fie unul valid.";
                this.DialogResult = DialogResult.None;
            }
            errorProduse.SetError(tbPret, eroare);
            produsNou.Producator = tbProducator.Text;



            if(btnAdauga.Text== "Adaugă")
            {
                produseFunctii.AdaugaProdus(produsNou);
            }
            else
            {
                produseFunctii.ModificaProdus(produsNou);
            }
                
        }

        private void tbPret_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
