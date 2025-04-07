namespace florarie
{
    partial class Livrari
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Livrari));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbFlori = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbIesire2 = new System.Windows.Forms.Label();
            this.lbComm = new System.Windows.Forms.Label();
            this.lbProduse = new System.Windows.Forms.Label();
            this.lbAdresa = new System.Windows.Forms.Label();
            this.lbCurier = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.lbCostTransport = new System.Windows.Forms.Label();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.tbCostTransport = new System.Windows.Forms.TextBox();
            this.cbCurier = new System.Windows.Forms.ComboBox();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnCom = new System.Windows.Forms.Button();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.grvLivrari = new System.Windows.Forms.DataGridView();
            this.clIdl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAdresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFirm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbLi = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvLivrari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.TabIndex = 1;
            // 
            // lbFlori
            // 
            this.lbFlori.AutoSize = true;
            this.lbFlori.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFlori.ForeColor = System.Drawing.Color.White;
            this.lbFlori.Location = new System.Drawing.Point(488, 9);
            this.lbFlori.Name = "lbFlori";
            this.lbFlori.Size = new System.Drawing.Size(249, 39);
            this.lbFlori.TabIndex = 1;
            this.lbFlori.Text = "EDENUL FLORAL";
            this.lbFlori.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbFlori.Click += new System.EventHandler(this.lbFlori_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 593);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1266, 24);
            this.panel2.TabIndex = 21;
            // 
            // lbIesire2
            // 
            this.lbIesire2.AutoSize = true;
            this.lbIesire2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIesire2.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbIesire2.Location = new System.Drawing.Point(975, 93);
            this.lbIesire2.Name = "lbIesire2";
            this.lbIesire2.Size = new System.Drawing.Size(121, 21);
            this.lbIesire2.TabIndex = 24;
            this.lbIesire2.Text = "DECONECTARE";
            this.lbIesire2.Click += new System.EventHandler(this.lbIesire2_Click);
            // 
            // lbComm
            // 
            this.lbComm.AutoSize = true;
            this.lbComm.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComm.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbComm.Location = new System.Drawing.Point(799, 93);
            this.lbComm.Name = "lbComm";
            this.lbComm.Size = new System.Drawing.Size(83, 21);
            this.lbComm.TabIndex = 23;
            this.lbComm.Text = "COMENZI";
            this.lbComm.Click += new System.EventHandler(this.lbComm_Click);
            // 
            // lbProduse
            // 
            this.lbProduse.AutoSize = true;
            this.lbProduse.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduse.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbProduse.Location = new System.Drawing.Point(629, 93);
            this.lbProduse.Name = "lbProduse";
            this.lbProduse.Size = new System.Drawing.Size(81, 21);
            this.lbProduse.TabIndex = 22;
            this.lbProduse.Text = "PRODUSE";
            this.lbProduse.Click += new System.EventHandler(this.lbProduse_Click);
            // 
            // lbAdresa
            // 
            this.lbAdresa.AutoSize = true;
            this.lbAdresa.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdresa.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbAdresa.Location = new System.Drawing.Point(33, 201);
            this.lbAdresa.Name = "lbAdresa";
            this.lbAdresa.Size = new System.Drawing.Size(124, 24);
            this.lbAdresa.TabIndex = 29;
            this.lbAdresa.Text = "Adresă livrare";
            // 
            // lbCurier
            // 
            this.lbCurier.AutoSize = true;
            this.lbCurier.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurier.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbCurier.Location = new System.Drawing.Point(33, 272);
            this.lbCurier.Name = "lbCurier";
            this.lbCurier.Size = new System.Drawing.Size(149, 24);
            this.lbCurier.TabIndex = 30;
            this.lbCurier.Text = "Firmă de curierat";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbData.Location = new System.Drawing.Point(33, 341);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(204, 24);
            this.lbData.TabIndex = 31;
            this.lbData.Text = "Dată estimată de livrare";
            // 
            // lbCostTransport
            // 
            this.lbCostTransport.AutoSize = true;
            this.lbCostTransport.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCostTransport.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbCostTransport.Location = new System.Drawing.Point(33, 410);
            this.lbCostTransport.Name = "lbCostTransport";
            this.lbCostTransport.Size = new System.Drawing.Size(128, 24);
            this.lbCostTransport.TabIndex = 32;
            this.lbCostTransport.Text = "Cost transport";
            // 
            // tbAdresa
            // 
            this.tbAdresa.BackColor = System.Drawing.Color.White;
            this.tbAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdresa.ForeColor = System.Drawing.Color.Indigo;
            this.tbAdresa.Location = new System.Drawing.Point(37, 228);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(302, 24);
            this.tbAdresa.TabIndex = 33;
            // 
            // tbCostTransport
            // 
            this.tbCostTransport.BackColor = System.Drawing.Color.White;
            this.tbCostTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCostTransport.ForeColor = System.Drawing.Color.Indigo;
            this.tbCostTransport.Location = new System.Drawing.Point(37, 437);
            this.tbCostTransport.Name = "tbCostTransport";
            this.tbCostTransport.Size = new System.Drawing.Size(302, 24);
            this.tbCostTransport.TabIndex = 34;
            this.tbCostTransport.TextChanged += new System.EventHandler(this.tbCostTransport_TextChanged);
            // 
            // cbCurier
            // 
            this.cbCurier.BackColor = System.Drawing.SystemColors.Window;
            this.cbCurier.ForeColor = System.Drawing.Color.Indigo;
            this.cbCurier.FormattingEnabled = true;
            this.cbCurier.Items.AddRange(new object[] {
            "Fan Courier",
            "Urgent Cargus",
            "DPD ",
            "GLS"});
            this.cbCurier.Location = new System.Drawing.Point(37, 299);
            this.cbCurier.Name = "cbCurier";
            this.cbCurier.Size = new System.Drawing.Size(302, 24);
            this.cbCurier.TabIndex = 35;
            this.cbCurier.SelectedIndexChanged += new System.EventHandler(this.cbCurier_SelectedIndexChanged);
            // 
            // dtData
            // 
            this.dtData.CalendarForeColor = System.Drawing.Color.Indigo;
            this.dtData.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtData.CalendarTitleBackColor = System.Drawing.Color.Thistle;
            this.dtData.CalendarTitleForeColor = System.Drawing.Color.Indigo;
            this.dtData.CalendarTrailingForeColor = System.Drawing.Color.Thistle;
            this.dtData.Location = new System.Drawing.Point(37, 368);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(302, 22);
            this.dtData.TabIndex = 36;
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnModifica.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifica.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.ForeColor = System.Drawing.Color.White;
            this.btnModifica.Location = new System.Drawing.Point(198, 492);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(119, 41);
            this.btnModifica.TabIndex = 39;
            this.btnModifica.Text = "Modifică";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnCom
            // 
            this.btnCom.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnCom.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCom.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCom.ForeColor = System.Drawing.Color.White;
            this.btnCom.Location = new System.Drawing.Point(63, 492);
            this.btnCom.Name = "btnCom";
            this.btnCom.Size = new System.Drawing.Size(119, 41);
            this.btnCom.TabIndex = 37;
            this.btnCom.Text = "Comandă";
            this.btnCom.UseVisualStyleBackColor = false;
            this.btnCom.Click += new System.EventHandler(this.btnCom_Click);
            // 
            // tbTotal
            // 
            this.tbTotal.BackColor = System.Drawing.Color.White;
            this.tbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.ForeColor = System.Drawing.Color.Indigo;
            this.tbTotal.Location = new System.Drawing.Point(867, 500);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(183, 24);
            this.tbTotal.TabIndex = 42;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbTotal.Location = new System.Drawing.Point(721, 500);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(129, 24);
            this.lbTotal.TabIndex = 40;
            this.lbTotal.Text = "Total de plată:";
            // 
            // grvLivrari
            // 
            this.grvLivrari.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvLivrari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvLivrari.BackgroundColor = System.Drawing.Color.White;
            this.grvLivrari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvLivrari.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grvLivrari.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkOrchid;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 15, 10, 15);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkOrchid;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvLivrari.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grvLivrari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvLivrari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clIdl,
            this.clIDC,
            this.clAdresa,
            this.clFirm,
            this.clData});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkOrchid;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvLivrari.DefaultCellStyle = dataGridViewCellStyle5;
            this.grvLivrari.EnableHeadersVisualStyles = false;
            this.grvLivrari.GridColor = System.Drawing.Color.Black;
            this.grvLivrari.Location = new System.Drawing.Point(392, 212);
            this.grvLivrari.MultiSelect = false;
            this.grvLivrari.Name = "grvLivrari";
            this.grvLivrari.ReadOnly = true;
            this.grvLivrari.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkOrchid;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvLivrari.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grvLivrari.RowHeadersVisible = false;
            this.grvLivrari.RowHeadersWidth = 51;
            this.grvLivrari.RowTemplate.Height = 24;
            this.grvLivrari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvLivrari.Size = new System.Drawing.Size(832, 243);
            this.grvLivrari.TabIndex = 43;
            this.grvLivrari.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvLivrari_CellClick);
            // 
            // clIdl
            // 
            this.clIdl.HeaderText = "LivrareID";
            this.clIdl.MinimumWidth = 6;
            this.clIdl.Name = "clIdl";
            this.clIdl.ReadOnly = true;
            // 
            // clIDC
            // 
            this.clIDC.HeaderText = "ComandaID";
            this.clIDC.MinimumWidth = 6;
            this.clIDC.Name = "clIDC";
            this.clIDC.ReadOnly = true;
            // 
            // clAdresa
            // 
            this.clAdresa.HeaderText = "Adresă";
            this.clAdresa.MinimumWidth = 6;
            this.clAdresa.Name = "clAdresa";
            this.clAdresa.ReadOnly = true;
            // 
            // clFirm
            // 
            this.clFirm.HeaderText = "Curier";
            this.clFirm.MinimumWidth = 6;
            this.clFirm.Name = "clFirm";
            this.clFirm.ReadOnly = true;
            // 
            // clData
            // 
            this.clData.HeaderText = "Dată";
            this.clData.MinimumWidth = 6;
            this.clData.Name = "clData";
            this.clData.ReadOnly = true;
            // 
            // lbLi
            // 
            this.lbLi.AutoSize = true;
            this.lbLi.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLi.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbLi.Location = new System.Drawing.Point(737, 156);
            this.lbLi.Name = "lbLi";
            this.lbLi.Size = new System.Drawing.Size(137, 39);
            this.lbLi.TabIndex = 44;
            this.lbLi.Text = "LIVRĂRI";
            this.lbLi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(641, 481);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(63, 59);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 41;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(154, 130);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(89, 74);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(744, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(920, 80);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(574, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Livrari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1266, 617);
            this.Controls.Add(this.lbLi);
            this.Controls.Add(this.grvLivrari);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnCom);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.cbCurier);
            this.Controls.Add(this.tbCostTransport);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.lbCostTransport);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lbCurier);
            this.Controls.Add(this.lbAdresa);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbIesire2);
            this.Controls.Add(this.lbComm);
            this.Controls.Add(this.lbProduse);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Livrari";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Livrari";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Livrari_FormClosing);
            this.Load += new System.EventHandler(this.Livrari_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvLivrari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbFlori;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbIesire2;
        private System.Windows.Forms.Label lbComm;
        private System.Windows.Forms.Label lbProduse;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbAdresa;
        private System.Windows.Forms.Label lbCurier;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbCostTransport;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.TextBox tbCostTransport;
        private System.Windows.Forms.ComboBox cbCurier;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnCom;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.DataGridView grvLivrari;
        private System.Windows.Forms.Label lbLi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIdl;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAdresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clData;
    }
}