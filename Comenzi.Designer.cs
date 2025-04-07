namespace florarie
{
    partial class Comenzi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comenzi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbFlori = new System.Windows.Forms.Label();
            this.lbProd = new System.Windows.Forms.Label();
            this.lbLivr = new System.Windows.Forms.Label();
            this.lbIesire = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbNumeClient = new System.Windows.Forms.Label();
            this.lbPrenumeClient = new System.Windows.Forms.Label();
            this.lbTelefon = new System.Windows.Forms.Label();
            this.lbPlata = new System.Windows.Forms.Label();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.tbPrenumeClient = new System.Windows.Forms.TextBox();
            this.tbNumeClient = new System.Windows.Forms.TextBox();
            this.cbCantitate = new System.Windows.Forms.ComboBox();
            this.cbPlata = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRen = new System.Windows.Forms.Button();
            this.btnContinua = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.lbValoareTotala = new System.Windows.Forms.Label();
            this.tbValoareTotala = new System.Windows.Forms.TextBox();
            this.grvComenzi = new System.Windows.Forms.DataGridView();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIdp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCantitate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrenume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPlata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbCom = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorComenzi = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvComenzi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorComenzi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel1.Controls.Add(this.lbFlori);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1266, 67);
            this.panel1.TabIndex = 0;
            // 
            // lbFlori
            // 
            this.lbFlori.AutoSize = true;
            this.lbFlori.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFlori.ForeColor = System.Drawing.Color.White;
            this.lbFlori.Location = new System.Drawing.Point(533, 9);
            this.lbFlori.Name = "lbFlori";
            this.lbFlori.Size = new System.Drawing.Size(249, 39);
            this.lbFlori.TabIndex = 1;
            this.lbFlori.Text = "EDENUL FLORAL";
            this.lbFlori.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbProd
            // 
            this.lbProd.AutoSize = true;
            this.lbProd.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProd.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbProd.Location = new System.Drawing.Point(685, 85);
            this.lbProd.Name = "lbProd";
            this.lbProd.Size = new System.Drawing.Size(81, 21);
            this.lbProd.TabIndex = 2;
            this.lbProd.Text = "PRODUSE";
            this.lbProd.Click += new System.EventHandler(this.lbProd_Click);
            // 
            // lbLivr
            // 
            this.lbLivr.AutoSize = true;
            this.lbLivr.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLivr.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbLivr.Location = new System.Drawing.Point(867, 85);
            this.lbLivr.Name = "lbLivr";
            this.lbLivr.Size = new System.Drawing.Size(75, 21);
            this.lbLivr.TabIndex = 3;
            this.lbLivr.Text = "LIVRĂRI";
            this.lbLivr.Click += new System.EventHandler(this.lbLivr_Click);
            // 
            // lbIesire
            // 
            this.lbIesire.AutoSize = true;
            this.lbIesire.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIesire.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbIesire.Location = new System.Drawing.Point(1031, 85);
            this.lbIesire.Name = "lbIesire";
            this.lbIesire.Size = new System.Drawing.Size(121, 21);
            this.lbIesire.TabIndex = 4;
            this.lbIesire.Text = "DECONECTARE";
            this.lbIesire.Click += new System.EventHandler(this.lbIesire_Click);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbID.Location = new System.Drawing.Point(33, 150);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(85, 24);
            this.lbID.TabIndex = 10;
            this.lbID.Text = "Cantitate";
            // 
            // lbNumeClient
            // 
            this.lbNumeClient.AutoSize = true;
            this.lbNumeClient.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeClient.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbNumeClient.Location = new System.Drawing.Point(33, 217);
            this.lbNumeClient.Name = "lbNumeClient";
            this.lbNumeClient.Size = new System.Drawing.Size(106, 24);
            this.lbNumeClient.TabIndex = 11;
            this.lbNumeClient.Text = "Nume client";
            // 
            // lbPrenumeClient
            // 
            this.lbPrenumeClient.AutoSize = true;
            this.lbPrenumeClient.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrenumeClient.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbPrenumeClient.Location = new System.Drawing.Point(33, 285);
            this.lbPrenumeClient.Name = "lbPrenumeClient";
            this.lbPrenumeClient.Size = new System.Drawing.Size(128, 24);
            this.lbPrenumeClient.TabIndex = 12;
            this.lbPrenumeClient.Text = "Prenume client";
            this.lbPrenumeClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTelefon
            // 
            this.lbTelefon.AutoSize = true;
            this.lbTelefon.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefon.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbTelefon.Location = new System.Drawing.Point(33, 354);
            this.lbTelefon.Name = "lbTelefon";
            this.lbTelefon.Size = new System.Drawing.Size(154, 24);
            this.lbTelefon.TabIndex = 13;
            this.lbTelefon.Text = "Număr de telefon";
            // 
            // lbPlata
            // 
            this.lbPlata.AutoSize = true;
            this.lbPlata.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlata.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbPlata.Location = new System.Drawing.Point(33, 424);
            this.lbPlata.Name = "lbPlata";
            this.lbPlata.Size = new System.Drawing.Size(142, 24);
            this.lbPlata.TabIndex = 14;
            this.lbPlata.Text = "Metodă de plată";
            // 
            // tbTelefon
            // 
            this.tbTelefon.BackColor = System.Drawing.Color.White;
            this.tbTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefon.ForeColor = System.Drawing.Color.Indigo;
            this.tbTelefon.Location = new System.Drawing.Point(37, 381);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(302, 24);
            this.tbTelefon.TabIndex = 15;
            this.tbTelefon.TextChanged += new System.EventHandler(this.tbTelefon_TextChanged);
            this.tbTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.tbTelefon_Validating);
            // 
            // tbPrenumeClient
            // 
            this.tbPrenumeClient.BackColor = System.Drawing.Color.White;
            this.tbPrenumeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrenumeClient.ForeColor = System.Drawing.Color.Indigo;
            this.tbPrenumeClient.Location = new System.Drawing.Point(37, 312);
            this.tbPrenumeClient.Name = "tbPrenumeClient";
            this.tbPrenumeClient.Size = new System.Drawing.Size(302, 24);
            this.tbPrenumeClient.TabIndex = 16;
            // 
            // tbNumeClient
            // 
            this.tbNumeClient.BackColor = System.Drawing.Color.White;
            this.tbNumeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumeClient.ForeColor = System.Drawing.Color.Indigo;
            this.tbNumeClient.Location = new System.Drawing.Point(37, 244);
            this.tbNumeClient.Name = "tbNumeClient";
            this.tbNumeClient.Size = new System.Drawing.Size(302, 24);
            this.tbNumeClient.TabIndex = 17;
            // 
            // cbCantitate
            // 
            this.cbCantitate.BackColor = System.Drawing.SystemColors.Window;
            this.cbCantitate.ForeColor = System.Drawing.Color.Indigo;
            this.cbCantitate.FormattingEnabled = true;
            this.cbCantitate.Items.AddRange(new object[] {
            "1 ",
            "2",
            "3 ",
            "4 ",
            "5 ",
            "6 ",
            "7 ",
            "8 ",
            "9 ",
            "10 "});
            this.cbCantitate.Location = new System.Drawing.Point(37, 177);
            this.cbCantitate.Name = "cbCantitate";
            this.cbCantitate.Size = new System.Drawing.Size(302, 24);
            this.cbCantitate.TabIndex = 18;
            this.cbCantitate.SelectedIndexChanged += new System.EventHandler(this.cbCantitate_SelectedIndexChanged);
            // 
            // cbPlata
            // 
            this.cbPlata.ForeColor = System.Drawing.Color.Indigo;
            this.cbPlata.FormattingEnabled = true;
            this.cbPlata.Items.AddRange(new object[] {
            "cash la livrare",
            "cu cardul la livrare"});
            this.cbPlata.Location = new System.Drawing.Point(37, 451);
            this.cbPlata.Name = "cbPlata";
            this.cbPlata.Size = new System.Drawing.Size(302, 24);
            this.cbPlata.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 593);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1266, 24);
            this.panel2.TabIndex = 20;
            // 
            // btnRen
            // 
            this.btnRen.BackColor = System.Drawing.Color.Indigo;
            this.btnRen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRen.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRen.ForeColor = System.Drawing.Color.White;
            this.btnRen.Location = new System.Drawing.Point(123, 545);
            this.btnRen.Name = "btnRen";
            this.btnRen.Size = new System.Drawing.Size(119, 41);
            this.btnRen.TabIndex = 22;
            this.btnRen.Text = "Renunță";
            this.btnRen.UseVisualStyleBackColor = false;
            this.btnRen.Click += new System.EventHandler(this.btnRen_Click);
            // 
            // btnContinua
            // 
            this.btnContinua.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnContinua.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnContinua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinua.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinua.ForeColor = System.Drawing.Color.White;
            this.btnContinua.Location = new System.Drawing.Point(62, 498);
            this.btnContinua.Name = "btnContinua";
            this.btnContinua.Size = new System.Drawing.Size(119, 41);
            this.btnContinua.TabIndex = 21;
            this.btnContinua.Text = "Continuă";
            this.btnContinua.UseVisualStyleBackColor = false;
            this.btnContinua.Click += new System.EventHandler(this.btnContinua_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnModifica.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifica.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.ForeColor = System.Drawing.Color.White;
            this.btnModifica.Location = new System.Drawing.Point(197, 498);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(119, 41);
            this.btnModifica.TabIndex = 23;
            this.btnModifica.Text = "Modifică";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // lbValoareTotala
            // 
            this.lbValoareTotala.AutoSize = true;
            this.lbValoareTotala.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValoareTotala.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbValoareTotala.Location = new System.Drawing.Point(722, 527);
            this.lbValoareTotala.Name = "lbValoareTotala";
            this.lbValoareTotala.Size = new System.Drawing.Size(140, 24);
            this.lbValoareTotala.TabIndex = 24;
            this.lbValoareTotala.Text = "Valoarea totală:";
            // 
            // tbValoareTotala
            // 
            this.tbValoareTotala.BackColor = System.Drawing.Color.White;
            this.tbValoareTotala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValoareTotala.ForeColor = System.Drawing.Color.Indigo;
            this.tbValoareTotala.Location = new System.Drawing.Point(868, 527);
            this.tbValoareTotala.Name = "tbValoareTotala";
            this.tbValoareTotala.Size = new System.Drawing.Size(183, 24);
            this.tbValoareTotala.TabIndex = 26;
            // 
            // grvComenzi
            // 
            this.grvComenzi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvComenzi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvComenzi.BackgroundColor = System.Drawing.Color.White;
            this.grvComenzi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvComenzi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grvComenzi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrchid;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 15, 10, 15);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrchid;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvComenzi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvComenzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvComenzi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clIdp,
            this.clCantitate,
            this.clNume,
            this.clPrenume,
            this.clNr,
            this.clPlata});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkOrchid;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvComenzi.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvComenzi.EnableHeadersVisualStyles = false;
            this.grvComenzi.GridColor = System.Drawing.Color.Black;
            this.grvComenzi.Location = new System.Drawing.Point(377, 227);
            this.grvComenzi.MultiSelect = false;
            this.grvComenzi.Name = "grvComenzi";
            this.grvComenzi.ReadOnly = true;
            this.grvComenzi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkOrchid;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvComenzi.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grvComenzi.RowHeadersVisible = false;
            this.grvComenzi.RowHeadersWidth = 51;
            this.grvComenzi.RowTemplate.Height = 24;
            this.grvComenzi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvComenzi.Size = new System.Drawing.Size(855, 193);
            this.grvComenzi.TabIndex = 27;
            this.grvComenzi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvComenzi_CellClick);
            this.grvComenzi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvComenzi_CellContentClick);
            // 
            // clId
            // 
            this.clId.HeaderText = "ComandaID";
            this.clId.MinimumWidth = 6;
            this.clId.Name = "clId";
            this.clId.ReadOnly = true;
            // 
            // clIdp
            // 
            this.clIdp.HeaderText = "ProdusID";
            this.clIdp.MinimumWidth = 6;
            this.clIdp.Name = "clIdp";
            this.clIdp.ReadOnly = true;
            // 
            // clCantitate
            // 
            this.clCantitate.HeaderText = "Cantitate";
            this.clCantitate.MinimumWidth = 6;
            this.clCantitate.Name = "clCantitate";
            this.clCantitate.ReadOnly = true;
            // 
            // clNume
            // 
            this.clNume.HeaderText = "Nume";
            this.clNume.MinimumWidth = 6;
            this.clNume.Name = "clNume";
            this.clNume.ReadOnly = true;
            // 
            // clPrenume
            // 
            this.clPrenume.HeaderText = "Prenume";
            this.clPrenume.MinimumWidth = 6;
            this.clPrenume.Name = "clPrenume";
            this.clPrenume.ReadOnly = true;
            // 
            // clNr
            // 
            this.clNr.HeaderText = "Telefon";
            this.clNr.MinimumWidth = 6;
            this.clNr.Name = "clNr";
            this.clNr.ReadOnly = true;
            // 
            // clPlata
            // 
            this.clPlata.HeaderText = "Plată";
            this.clPlata.MinimumWidth = 6;
            this.clPlata.Name = "clPlata";
            this.clPlata.ReadOnly = true;
            // 
            // lbCom
            // 
            this.lbCom.AutoSize = true;
            this.lbCom.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCom.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbCom.Location = new System.Drawing.Point(719, 163);
            this.lbCom.Name = "lbCom";
            this.lbCom.Size = new System.Drawing.Size(155, 39);
            this.lbCom.TabIndex = 28;
            this.lbCom.Text = "COMENZI";
            this.lbCom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCom.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(642, 508);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(63, 59);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(153, 84);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(89, 74);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(812, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(976, 72);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(630, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // errorComenzi
            // 
            this.errorComenzi.ContainerControl = this;
            // 
            // Comenzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1266, 617);
            this.Controls.Add(this.lbCom);
            this.Controls.Add(this.grvComenzi);
            this.Controls.Add(this.tbValoareTotala);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lbValoareTotala);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnRen);
            this.Controls.Add(this.btnContinua);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbPlata);
            this.Controls.Add(this.cbCantitate);
            this.Controls.Add(this.tbNumeClient);
            this.Controls.Add(this.tbPrenumeClient);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.lbPlata);
            this.Controls.Add(this.lbTelefon);
            this.Controls.Add(this.lbPrenumeClient);
            this.Controls.Add(this.lbNumeClient);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbIesire);
            this.Controls.Add(this.lbLivr);
            this.Controls.Add(this.lbProd);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Comenzi";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comenzi";
            this.Load += new System.EventHandler(this.Comenzi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvComenzi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorComenzi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbFlori;
        private System.Windows.Forms.Label lbProd;
        private System.Windows.Forms.Label lbLivr;
        private System.Windows.Forms.Label lbIesire;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbNumeClient;
        private System.Windows.Forms.Label lbPrenumeClient;
        private System.Windows.Forms.Label lbTelefon;
        private System.Windows.Forms.Label lbPlata;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.TextBox tbPrenumeClient;
        private System.Windows.Forms.TextBox tbNumeClient;
        private System.Windows.Forms.ComboBox cbCantitate;
        private System.Windows.Forms.ComboBox cbPlata;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRen;
        private System.Windows.Forms.Button btnContinua;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Label lbValoareTotala;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox tbValoareTotala;
        private System.Windows.Forms.DataGridView grvComenzi;
        private System.Windows.Forms.Label lbCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIdp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCantitate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNume;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrenume;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPlata;
        private System.Windows.Forms.ErrorProvider errorComenzi;
    }
}