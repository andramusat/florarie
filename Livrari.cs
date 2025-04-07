using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using florarie.Repositories;

namespace florarie
{
    public partial class Livrari : Form
    {
        int id_c;
        int id;
        double pretComanda;
        LivrariFunctii livrariFunctii = new LivrariFunctii();
        public Livrari(int id_comanda, double pret)
        {
            InitializeComponent();
            pretComanda = pret;
            id_c = id_comanda;
            BindingList<Livrare> livrari = livrariFunctii.getAll();
            grvLivrari.Rows.Clear();
            foreach (Livrare livrare in livrari)
            {
                DataGridViewRow r1 = new DataGridViewRow();
                r1.CreateCells(grvLivrari);
                r1.Cells[0].Value = livrare.Id.ToString();
                r1.Cells[1].Value = livrare.IdComanda.ToString();
                r1.Cells[2].Value = livrare.AdresaLivrare;
                r1.Cells[3].Value = livrare.FirmaCurierat;
                r1.Cells[4].Value = livrare.DataEstimataDeLivrare.ToString();
                r1.Tag = livrare;
                grvLivrari.Rows.Add(r1);
            }
        }

        private void lbFlori_Click(object sender, EventArgs e)
        {

        }

        private void btnCom_Click(object sender, EventArgs e)
        {
            if (id_c != -1)
            {
                Livrare livrare = new Livrare();
                livrare.Id = livrariFunctii.getMaxID() + 1;
                livrare.IdComanda = id_c;
                livrare.AdresaLivrare = tbAdresa.Text.ToString();
                livrare.DataEstimataDeLivrare = DateTime.Parse(dtData.Value.ToString());
                livrare.FirmaCurierat = cbCurier.Text.ToString();
                livrariFunctii.AdaugaLivrare(livrare);
                BindingList<Livrare> livrari = livrariFunctii.getAll();
                grvLivrari.Rows.Clear();
                foreach (Livrare livr in livrari)
                {
                    DataGridViewRow r1 = new DataGridViewRow();
                    r1.CreateCells(grvLivrari);
                    r1.Cells[0].Value = livr.Id.ToString();
                    r1.Cells[1].Value = livr.IdComanda.ToString();
                    r1.Cells[2].Value = livr.AdresaLivrare;
                    r1.Cells[3].Value = livr.FirmaCurierat;
                    r1.Cells[4].Value = livr.DataEstimataDeLivrare.ToString();
                    r1.Tag = livr;
                    grvLivrari.Rows.Add(r1);
                }
                MessageBox.Show("Comanda a fost plasată cu succes!", "Succes", MessageBoxButtons.OK);
                Produse produseForm = new Produse();
                produseForm.ShowDialog();
                this.Hide();

            }

        }

        private void cbCurier_SelectedIndexChanged(object sender, EventArgs e)
        {
            double transport = 0;
            if (cbCurier.Text.ToString() == "Fan Courier")
            {
                tbCostTransport.Text = "16" + "\t" + "RON";
                transport = 16;
            }
            if (cbCurier.Text.ToString() == "Urgent Cargus")
            {
                tbCostTransport.Text = "20" + "\t" + "RON";
                transport = 20;
            }
            if (cbCurier.Text.ToString() == "DPD")
            {
                tbCostTransport.Text = "15" + "\t" + "RON";
                transport = 15;
            }
            if (cbCurier.Text.ToString() == "GLS")
            {
                tbCostTransport.Text = "10" + "\t" + "RON";
                transport = 10;
            }
            tbTotal.Text = (transport + pretComanda).ToString();
        }

        private void Livrari_Load(object sender, EventArgs e)
        {

        }

        private void grvLivrari_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < grvLivrari.Rows.Count && grvLivrari.SelectedRows[0].Tag != null)
            {
                DataGridViewRow row = grvLivrari.Rows[e.RowIndex];
                id = int.Parse(row.Cells[0].Value.ToString());
                id_c = int.Parse(row.Cells[1].Value.ToString());
                tbAdresa.Text = row.Cells[2].Value.ToString();
                cbCurier.Text = row.Cells[3].Value.ToString();
                dtData.Value = DateTime.Parse(row.Cells[4].Value.ToString());
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            Livrare livrare = new Livrare();
            livrare.Id = id;
            livrare.IdComanda = id_c;
            livrare.AdresaLivrare = tbAdresa.Text.ToString();
            livrare.DataEstimataDeLivrare = DateTime.Parse(dtData.Value.ToString());
            livrare.FirmaCurierat = cbCurier.Text.ToString();
            livrariFunctii.EditeazaLivrare(livrare);
            BindingList<Livrare> livrari = livrariFunctii.getAll();
            grvLivrari.Rows.Clear();
            foreach (Livrare livr in livrari)
            {
                DataGridViewRow r1 = new DataGridViewRow();
                r1.CreateCells(grvLivrari);
                r1.Cells[0].Value = livr.Id.ToString();
                r1.Cells[1].Value = livr.IdComanda.ToString();
                r1.Cells[2].Value = livr.AdresaLivrare;
                r1.Cells[3].Value = livr.FirmaCurierat;
                r1.Cells[4].Value = livr.DataEstimataDeLivrare.ToString();
                r1.Tag = livr;
                grvLivrari.Rows.Add(r1);
            }
            MessageBox.Show("Modificare realizată cu succes!", "Succes", MessageBoxButtons.OK);
            Produse produseForm = new Produse();
            produseForm.ShowDialog();
            this.Hide();

        }

        private void lbProduse_Click(object sender, EventArgs e)
        {
            Produse ProduseForm = new Produse();
            ProduseForm.ShowDialog();
            this.Hide();
        }

        private void lbComm_Click(object sender, EventArgs e)
        {
            Produs produs = null;
            Comenzi comenziForm = new Comenzi(produs);
            comenziForm.ShowDialog();
            this.Hide();
        }

        private void lbIesire2_Click(object sender, EventArgs e)
        {
            Florarie formF = new Florarie();
            formF.ShowDialog();
            this.Hide();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == (Keys.Control | Keys.P))
            {
                if (grvLivrari.SelectedRows[0].Tag != null)
                {
                    Livrare livrare = new Livrare();
                    livrare.Id = id;
                    livrare.IdComanda = id_c;
                    livrare.AdresaLivrare = tbAdresa.Text.ToString();
                    livrare.DataEstimataDeLivrare = DateTime.Parse(dtData.Value.ToString());
                    livrare.FirmaCurierat = cbCurier.Text.ToString();
                    SaveFileDialog fd = new SaveFileDialog();
                    fd.Filter = ".txt | *.txt";
                    fd.CheckPathExists = true;
                    if (fd.ShowDialog() == DialogResult.OK)
                    {
                        using(StreamWriter write = new StreamWriter(fd.FileName))
                        {
                            string content = "ID livrare: " + livrare.Id + Environment.NewLine +
                                             "ID comandă: " + livrare.IdComanda + Environment.NewLine +
                                             "Adresă de livrare: " + livrare.AdresaLivrare + Environment.NewLine +
                                             "Dată estimată de livrare: " + livrare.DataEstimataDeLivrare.ToString() + Environment.NewLine +
                                             "Firmă de curierat: " + livrare.FirmaCurierat + Environment.NewLine +
                                             "Cost total: " + tbTotal.Text;
                            write.WriteLine(content);
                        }
                        MessageBox.Show("Printare realizată cu succes!");
                    }
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Livrari_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void tbCostTransport_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
