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
    public partial class Grafic : Form
    {
        ProduseFunctii produseFunctii = new ProduseFunctii();
        ComenziFunctii comenziFunctii = new ComenziFunctii();
        public Grafic()
        {
            InitializeComponent();
        }

        private void Grafic_Load(object sender, EventArgs e)
        {
            fillChart();
        }
        private void fillChart()
        {
            BindingList<Produs> produse = new BindingList<Produs>();
            produse = produseFunctii.GetAll();
            int countProduse = produse.Count;
            BindingList<Comanda> comenzi = new BindingList<Comanda>();
            comenzi = comenziFunctii.getAll();
            Dictionary<int, int> comenziPerProdus = new Dictionary<int, int>();
            foreach (var produs in produse)
            {
                comenziPerProdus[produs.Id] = 0;
            }
            foreach (var comanda in comenzi)
            {
                if (comenziPerProdus.ContainsKey(comanda.IdProdus))
                {
                    comenziPerProdus[comanda.IdProdus]++;
                }
            }
            foreach (var produs in produse)
            {
                comenziChart.Series["Comenzi"].Points.AddXY(produs.Id, comenziPerProdus[produs.Id]);
            }
            comenziChart.Titles.Add("Numărul de comenzi pentru fiecare produs");
            comenziChart.ChartAreas[0].AxisX.Title = "ID Produs";
            comenziChart.ChartAreas[0].AxisY.Title = "Număr de comenzi";

        }

        private void comenziChart_Click(object sender, EventArgs e)
        {

        }

        private void pbIesire_Click(object sender, EventArgs e)
        {
            Produse formProduse = new Produse();
            formProduse.ShowDialog();
            this.Close();
        }
    }
}
