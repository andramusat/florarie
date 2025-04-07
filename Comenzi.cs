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
    public partial class Comenzi : Form
    {
        Produs prod = new Produs();
        ComenziFunctii comenziFunctii = new ComenziFunctii();
        int id;
        int id_produs;
        double cost_total;
        int cnt = 1;
        public Comenzi(Produs produs)
        {
            InitializeComponent();
            SetDataGridViewStyle();
            if (produs != null)
            {
                prod = produs;
                cost_total = produs.Pret;
                cnt = 0;
            }
            else
            {
                prod = new Produs();
            }
            BindingList<Comanda> comenzi = new BindingList<Comanda>();
            comenzi = comenziFunctii.getAll();
            grvComenzi.Rows.Clear();
            foreach (Comanda comanda in comenzi)
            {
                DataGridViewRow r1 = new DataGridViewRow();
                r1.CreateCells(grvComenzi);
                r1.Cells[0].Value = comanda.Id.ToString();
                r1.Cells[1].Value = comanda.IdProdus.ToString();
                r1.Cells[2].Value = comanda.Cantitate.ToString();
                r1.Cells[3].Value = comanda.NumeClient;
                r1.Cells[4].Value = comanda.PrenumeClient;
                r1.Cells[5].Value = comanda.TelefonContact;
                r1.Cells[6].Value = comanda.MetodaPlata;
                r1.Tag = comanda;
                grvComenzi.Rows.Add(r1);
            }
        }

        private void SetDataGridViewStyle()
        {
            grvComenzi.DefaultCellStyle.ForeColor = Color.DarkOrchid;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Comenzi_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbCantitate_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbValoareTotala.Text = (int.Parse(cbCantitate.Text) * prod.Pret).ToString() + "\t" +"RON";
        }

        private void btnContinua_Click(object sender, EventArgs e)
        {
            if (cnt == 0)
            {
                Comanda comanda = new Comanda();
                comanda.Id = comenziFunctii.getMaxID() + 1;
                comanda.IdProdus = prod.Id;
                comanda.Cantitate = int.Parse(cbCantitate.Text);
                comanda.NumeClient = tbNumeClient.Text;
                comanda.PrenumeClient = tbPrenumeClient.Text;
                comanda.TelefonContact = tbTelefon.Text;
                comanda.MetodaPlata = cbPlata.Text;
                comenziFunctii.AdaugaComanda(comanda);

                BindingList<Comanda> comenzi = new BindingList<Comanda>();
                comenzi = comenziFunctii.getAll();
                grvComenzi.Rows.Clear();
                foreach (Comanda com in comenzi)
                {
                    DataGridViewRow r1 = new DataGridViewRow();
                    r1.CreateCells(grvComenzi);
                    r1.Cells[0].Value = com.Id.ToString();
                    r1.Cells[1].Value = com.IdProdus.ToString();
                    r1.Cells[2].Value = com.Cantitate.ToString();
                    r1.Cells[3].Value = com.NumeClient;
                    r1.Cells[4].Value = com.PrenumeClient;
                    r1.Cells[5].Value = com.TelefonContact;
                    r1.Cells[6].Value = com.MetodaPlata;
                    r1.Tag = com;
                    grvComenzi.Rows.Add(r1);
                }
                cost_total = cost_total * comanda.Cantitate;
                Livrari livrariForm = new Livrari(comanda.Id, cost_total);
                livrariForm.ShowDialog();
            }
        }

        private void grvComenzi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 

        }

        private void ClearValidationErrors()
        {
            errorComenzi.SetError(tbTelefon, "");
        }

        private void ValidareNumarTelefon()
        {
            if (tbTelefon.Text.Length != 10)
            {
                errorComenzi.SetError(tbTelefon, "Numărul de telefon trebuie să fie format din 10 cifre!");
            }
            else
            {
                errorComenzi.SetError(tbTelefon, "");
            }
        }

        private void grvComenzi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < grvComenzi.Rows.Count && grvComenzi.SelectedRows[0].Tag!=null)
            {
                ClearValidationErrors();
                DataGridViewRow row = grvComenzi.Rows[e.RowIndex];
                id = int.Parse(row.Cells[0].Value.ToString());
                id_produs = int.Parse(row.Cells[1].Value.ToString());
                cbCantitate.Text = row.Cells[2].Value.ToString();
                tbNumeClient.Text = row.Cells[3].Value.ToString();
                tbPrenumeClient.Text = row.Cells[4].Value.ToString();
                tbTelefon.Text = row.Cells[5].Value.ToString();
                cbPlata.Text = row.Cells[6].Value.ToString();
                ValidareNumarTelefon();
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            Comanda comandaModificata = new Comanda();
            comandaModificata.Id = id;
            comandaModificata.IdProdus = id_produs;
            comandaModificata.Cantitate = int.Parse(cbCantitate.Text.ToString());
            comandaModificata.PrenumeClient = tbPrenumeClient.Text.ToString();
            comandaModificata.NumeClient = tbNumeClient.Text.ToString();
            comandaModificata.TelefonContact = tbTelefon.Text.ToString();
            comandaModificata.MetodaPlata = cbPlata.Text.ToString();
            comenziFunctii.EditeazaComanda(comandaModificata);
            BindingList<Comanda> comenzi = new BindingList<Comanda>();
            comenzi = comenziFunctii.getAll();
            grvComenzi.Rows.Clear();
            foreach (Comanda com in comenzi)
            {
                DataGridViewRow r1 = new DataGridViewRow();
                r1.CreateCells(grvComenzi);
                r1.Cells[0].Value = com.Id.ToString();
                r1.Cells[1].Value = com.IdProdus.ToString();
                r1.Cells[2].Value = com.Cantitate.ToString();
                r1.Cells[3].Value = com.NumeClient;
                r1.Cells[4].Value = com.PrenumeClient;
                r1.Cells[5].Value = com.TelefonContact;
                r1.Cells[6].Value = com.MetodaPlata;
                r1.Tag = com;
                grvComenzi.Rows.Add(r1);
            }
            MessageBox.Show("Modificare realizată cu succes!", "Succes", MessageBoxButtons.OK);
            Livrari livrariForm = new Livrari(comandaModificata.Id, cost_total);
            livrariForm.ShowDialog();
        }

        private void btnRen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ești sigur(ă) că vrei să ștergi comanda selectată?",
                   "Confirmare",
                   MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Comanda comandaModificata = new Comanda();
                comandaModificata.Id = id;
                comandaModificata.IdProdus = id_produs;
                comandaModificata.Cantitate = int.Parse(cbCantitate.Text.ToString());
                comandaModificata.PrenumeClient = tbPrenumeClient.Text.ToString();
                comandaModificata.NumeClient = tbNumeClient.Text.ToString();
                comandaModificata.TelefonContact = tbTelefon.Text.ToString();
                comandaModificata.MetodaPlata = cbPlata.Text.ToString();

                comenziFunctii.StergeComanda(comandaModificata);

                BindingList<Comanda> comenzi = new BindingList<Comanda>();
                comenzi = comenziFunctii.getAll();
                grvComenzi.Rows.Clear();
                foreach (Comanda com in comenzi)
                {
                    DataGridViewRow r1 = new DataGridViewRow();
                    r1.CreateCells(grvComenzi);
                    r1.Cells[0].Value = com.Id.ToString();
                    r1.Cells[1].Value = com.IdProdus.ToString();
                    r1.Cells[2].Value = com.Cantitate.ToString();
                    r1.Cells[3].Value = com.NumeClient;
                    r1.Cells[4].Value = com.PrenumeClient;
                    r1.Cells[5].Value = com.TelefonContact;
                    r1.Cells[6].Value = com.MetodaPlata;
                    r1.Tag = com;
                    grvComenzi.Rows.Add(r1);
                }
                MessageBox.Show("Comandă ștearsă!");
                Produse formProduse = new Produse();
                formProduse.ShowDialog();
            
            }
        }

        private void lbProd_Click(object sender, EventArgs e)
        {
            Produse produseForm = new Produse();
            produseForm.ShowDialog();
            this.Hide();

        }

        private void lbLivr_Click(object sender, EventArgs e)
        {
            Livrari livrariForm = new Livrari(0, -1);
            livrariForm.ShowDialog();
            this.Hide();
        }

        private void lbIesire_Click(object sender, EventArgs e)
        {
            Florarie florarie = new Florarie();
            florarie.ShowDialog();
            this.Hide();
        }
     

        private void tbTelefon_Validating(object sender, CancelEventArgs e)
        {
            ValidareNumarTelefon();
        }

        private void tbTelefon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
