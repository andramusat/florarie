using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using florarie.Repositories;

namespace florarie
{
    public partial class Produse : Form
    {
        ProduseFunctii produseFunctii = new ProduseFunctii();
        DataGridViewRow rightClickedRow = new DataGridViewRow();
        public Produse()
        {
            InitializeComponent();
            grvProduse.Rows.Clear();
            BindingList<Produs> produse = new BindingList<Produs>();
            produse = produseFunctii.GetAll();
            /*p1 = new Produs(1, "Buchet rustic", "flori de câmp, margarete, lavanda, spice de grâu", 55.5, "Geneva");
            p2 = new Produs(2, "Buchet de primăvară", "lalele, narcise, frezii", 60.5, "Olanda");
            p3 = new Produs(3, "Buchetul eleganței", "trandafiri, orhidee,iasomii", 90, "Bulgaria");
            p4 = new Produs(4, "Buchetul bucuriei", "crini, gerbere, flori de cireș", 80.7, "Elveția");*/
            foreach (Produs produs in produse)
            {
                DataGridViewRow r1 = new DataGridViewRow();
                r1.CreateCells(grvProduse);
                r1.Cells[0].Value = produs.Id.ToString();
                r1.Cells[1].Value = produs.Denumire;
                r1.Cells[2].Value = produs.Descriere;
                r1.Cells[3].Value = produs.Pret.ToString();
                r1.Cells[4].Value = produs.Producator;
                r1.Tag = produs;
                grvProduse.Rows.Add(r1);
            }

/*            r1.CreateCells(grvProduse);
            r1.Cells[0].Value = p1.Id.ToString();
            r1.Cells[1].Value = p1.Denumire;
            r1.Cells[2].Value = p1.Descriere;
            r1.Cells[3].Value = p1.Pret.ToString();
            r1.Cells[4].Value = p1.Producator;
            r1.Tag = p1;
            grvProduse.Rows.Add(r1);*/

        }

        private void Produse_Load(object sender, EventArgs e)
        {

        }

        private void grvProduse_MouseDown(object sender, MouseEventArgs e)
        {
                if (e.Button == MouseButtons.Left && grvProduse.SelectedRows.Count > 0 && grvProduse.SelectedRows[0].Tag!=null)
                {
                    Produs produs = (Produs)grvProduse.SelectedRows[0].Tag;
                    grvProduse.DoDragDrop(produs, DragDropEffects.Copy);
                }

        }

        private void lbProduse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbProduse_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Effect == DragDropEffects.Copy && e.Data.GetDataPresent(typeof(Produs)))
            {
                Produs p = (Produs)e.Data.GetData(typeof(Produs));
                lbProduse.Items.Add(p.Denumire); 
            }
        }

        private void lbProduse_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Produs)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void adaugăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produs prod = null;
            FormProduse formProduse = new FormProduse(prod);
            formProduse.ShowDialog();
            BindingList<Produs> produse = new BindingList<Produs>();
            grvProduse.Rows.Clear();
            produse = produseFunctii.GetAll();
            foreach (Produs produs in produse)
            {
                DataGridViewRow r1 = new DataGridViewRow();
                r1.CreateCells(grvProduse);
                r1.Cells[0].Value = produs.Id.ToString();
                r1.Cells[1].Value = produs.Denumire;
                r1.Cells[2].Value = produs.Descriere;
                r1.Cells[3].Value = produs.Pret.ToString();
                r1.Cells[4].Value = produs.Producator;
                r1.Tag = produs;
                grvProduse.Rows.Add(r1);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (grvProduse.SelectedRows.Count > 0)
            {
                editeazăToolStripMenuItem.Enabled = true;
                ștergeToolStripMenuItem.Enabled = true;
            }
            else
            {
                editeazăToolStripMenuItem.Enabled = false;
                ștergeToolStripMenuItem.Enabled = false;
            }
        }

        private void grvProduse_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grvProduse_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right && e.RowIndex > 0)
            {
                grvProduse.ClearSelection();
                grvProduse.Rows[e.RowIndex].Selected = true;
                rightClickedRow = grvProduse.Rows[e.RowIndex];
                grvProduse.CurrentCell = grvProduse.Rows[e.RowIndex].Cells[e.ColumnIndex];
                grvProduse.ContextMenuStrip.Show(Cursor.Position);
            }
        }

        private void editeazăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produs produs1 = new Produs();
            DataGridViewRow selectedRow = grvProduse.SelectedRows[0];
            produs1.Id = int.Parse(selectedRow.Cells[0].Value.ToString());
            produs1.Denumire = selectedRow.Cells[1].Value.ToString();
            produs1.Descriere = selectedRow.Cells[2].Value.ToString();
            produs1.Pret = double.Parse(selectedRow.Cells[3].Value.ToString());
            produs1.Producator = selectedRow.Cells[4].Value.ToString();
            var updateForm = new FormProduse(produs1);
            updateForm.ShowDialog();
            grvProduse.Rows.Clear();
            BindingList<Produs> produse = new BindingList<Produs>();
            produse = produseFunctii.GetAll();
            foreach (Produs produs in produse)
            {
                DataGridViewRow r1 = new DataGridViewRow();
                r1.CreateCells(grvProduse);
                r1.Cells[0].Value = produs.Id.ToString();
                r1.Cells[1].Value = produs.Denumire;
                r1.Cells[2].Value = produs.Descriere;
                r1.Cells[3].Value = produs.Pret.ToString();
                r1.Cells[4].Value = produs.Producator;
                r1.Tag = produs;
                grvProduse.Rows.Add(r1);
            }
        }

        private void ștergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (grvProduse.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Ești sigur(ă) că vrei să ștergi produsul selectat?",
                    "Confirmare",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Produs produs1 = new Produs();
                    DataGridViewRow selectedRow = grvProduse.SelectedRows[0];
                    produs1.Id = int.Parse(selectedRow.Cells[0].Value.ToString());
                    produs1.Denumire = selectedRow.Cells[1].Value.ToString();
                    produs1.Descriere = selectedRow.Cells[2].Value.ToString();
                    produs1.Pret = double.Parse(selectedRow.Cells[3].Value.ToString());
                    produs1.Producator = selectedRow.Cells[4].Value.ToString();
                    produseFunctii.StergeProdus(produs1);
                    BindingList<Produs> produse = new BindingList<Produs>();
                    produse = produseFunctii.GetAll();
                    grvProduse.Rows.Clear();
                    foreach (Produs produs in produse)
                    {
                        DataGridViewRow r1 = new DataGridViewRow();
                        r1.CreateCells(grvProduse);
                        r1.Cells[0].Value = produs.Id.ToString();
                        r1.Cells[1].Value = produs.Denumire;
                        r1.Cells[2].Value = produs.Descriere;
                        r1.Cells[3].Value = produs.Pret.ToString();
                        r1.Cells[4].Value = produs.Producator;
                        r1.Tag = produs;
                        grvProduse.Rows.Add(r1);
                    }
                    MessageBox.Show("Produs șters!");
                       
                }
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "xml| *.xml ";
            fd.CheckPathExists = true;
            if(fd.ShowDialog() == DialogResult.OK)
            {
                BindingList<Produs> produse = new BindingList<Produs>();
                produse = produseFunctii.GetAll();
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Produs>));
                    Stream fisier = File.Create(fd.FileName);
                    serializer.Serialize(fisier, produse);
                    MessageBox.Show("Salvare realizată cu succes!");
                    fisier.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void grvProduse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            Produs prod = new Produs();
            string numeProdus = lbProduse.Text;
            BindingList<Produs> produse = new BindingList<Produs>();
            produse = produseFunctii.GetAll();
            foreach(var p in produse)
            {
                if(p.Denumire == numeProdus)
                {
                    prod = p;
                }
            }
            Comenzi comenziForm = new Comenzi(prod);
            comenziForm.ShowDialog();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == (Keys.Control| Keys.D))
            {
                if(lbProduse.SelectedItem != null)
                {
                    lbProduse.Items.Remove(lbProduse.SelectedItem);
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void lbComenzi_Click(object sender, EventArgs e)
        {
            Produs produs = null;
            Comenzi comenziForm = new Comenzi(produs);
            comenziForm.ShowDialog();
            this.Hide();
        }

        private void lbLivrari_Click(object sender, EventArgs e)
        {
            Livrari livrariForm = new Livrari(0, -1);
            livrariForm.ShowDialog();
            this.Hide();
        }

        private void lbDeconectare_Click(object sender, EventArgs e)
        {
            Florarie florarie = new Florarie();
            florarie.ShowDialog();
            this.Hide();
        }

        private void restaurareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "xml |*.xml";
            fd.CheckFileExists = true;
            if(fd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Stream fisier = File.OpenRead(fd.FileName);
                    XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Produs>));
                    BindingList<Produs> produse = (BindingList<Produs>)serializer.Deserialize(fisier);
                    if (grvProduse.Rows.Count > 0)
                    {
                        if (MessageBox.Show("Vrei să ștergi înregistrările existente?",
                            "Întrebare",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                            ) == DialogResult.Yes)
                        {
                            grvProduse.Rows.Clear();
                            foreach (Produs produs in produse)
                            {
                                DataGridViewRow r1 = new DataGridViewRow();
                                r1.CreateCells(grvProduse);
                                r1.Cells[0].Value = produs.Id.ToString();
                                r1.Cells[1].Value = produs.Denumire;
                                r1.Cells[2].Value = produs.Descriere;
                                r1.Cells[3].Value = produs.Pret.ToString();
                                r1.Cells[4].Value = produs.Producator;
                                r1.Tag = produs;
                                grvProduse.Rows.Add(r1);
                            }
                        }

                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void salvareBinaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "bin | *.bin";
            fd.CheckPathExists = true;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                BindingList<Produs> produse = produseFunctii.GetAll();
                try
                {
                    BinaryFormatter serializer = new BinaryFormatter();
                    Stream fisier = File.Create(fd.FileName);
                    serializer.Serialize(fisier, produse);
                    fisier.Close();
                    MessageBox.Show("Salvare realizată cu succes!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void restaurareFișierBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "bin |*.bin";
            fd.CheckFileExists = true;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Stream fisier = File.OpenRead(fd.FileName);
                    BinaryFormatter serializer = new BinaryFormatter();
                    BindingList<Produs> produse = (BindingList<Produs>)serializer.Deserialize(fisier);
                    if (grvProduse.Rows.Count > 0)
                    {
                        if (MessageBox.Show("Vrei să ștergi înregistrările existente?",
                            "Întrebare",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                            ) == DialogResult.Yes)
                        {
                            grvProduse.Rows.Clear();
                            foreach (Produs produs in produse)
                            {
                                DataGridViewRow r1 = new DataGridViewRow();
                                r1.CreateCells(grvProduse);
                                r1.Cells[0].Value = produs.Id.ToString();
                                r1.Cells[1].Value = produs.Denumire;
                                r1.Cells[2].Value = produs.Descriere;
                                r1.Cells[3].Value = produs.Pret.ToString();
                                r1.Cells[4].Value = produs.Producator;
                                r1.Tag = produs;
                                grvProduse.Rows.Add(r1);
                            }
                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void labelStatistici_Click(object sender, EventArgs e)
        {
            Grafic formGrafic = new Grafic();
            formGrafic.ShowDialog();
            this.Hide();
        }
    }
}
