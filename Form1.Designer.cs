namespace florarie
{
    partial class Florarie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Florarie));
            this.lbTitlu = new System.Windows.Forms.Label();
            this.btnConectare = new System.Windows.Forms.Button();
            this.lbUtilizator = new System.Windows.Forms.Label();
            this.lbParola = new System.Windows.Forms.Label();
            this.tbUtilizator = new System.Windows.Forms.TextBox();
            this.tbParola = new System.Windows.Forms.TextBox();
            this.pbIesire = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIesire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitlu
            // 
            this.lbTitlu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitlu.AutoSize = true;
            this.lbTitlu.BackColor = System.Drawing.Color.Transparent;
            this.lbTitlu.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitlu.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbTitlu.Location = new System.Drawing.Point(584, 70);
            this.lbTitlu.Name = "lbTitlu";
            this.lbTitlu.Size = new System.Drawing.Size(602, 120);
            this.lbTitlu.TabIndex = 0;
            this.lbTitlu.Text = "BUN VENIT LA FLORĂRIA\r\nEDENUL FLORAL!";
            this.lbTitlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTitlu.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnConectare
            // 
            this.btnConectare.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnConectare.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConectare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectare.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectare.ForeColor = System.Drawing.Color.White;
            this.btnConectare.Location = new System.Drawing.Point(776, 486);
            this.btnConectare.Name = "btnConectare";
            this.btnConectare.Size = new System.Drawing.Size(249, 49);
            this.btnConectare.TabIndex = 1;
            this.btnConectare.Text = "CONECTARE";
            this.btnConectare.UseVisualStyleBackColor = false;
            this.btnConectare.Click += new System.EventHandler(this.btnVizualizare_Click);
            // 
            // lbUtilizator
            // 
            this.lbUtilizator.AutoSize = true;
            this.lbUtilizator.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUtilizator.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbUtilizator.Location = new System.Drawing.Point(686, 306);
            this.lbUtilizator.Name = "lbUtilizator";
            this.lbUtilizator.Size = new System.Drawing.Size(186, 31);
            this.lbUtilizator.TabIndex = 6;
            this.lbUtilizator.Text = "Nume utilizator:";
            // 
            // lbParola
            // 
            this.lbParola.AutoSize = true;
            this.lbParola.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParola.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbParola.Location = new System.Drawing.Point(686, 386);
            this.lbParola.Name = "lbParola";
            this.lbParola.Size = new System.Drawing.Size(86, 31);
            this.lbParola.TabIndex = 7;
            this.lbParola.Text = "Parolă:";
            // 
            // tbUtilizator
            // 
            this.tbUtilizator.BackColor = System.Drawing.Color.White;
            this.tbUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUtilizator.ForeColor = System.Drawing.Color.Indigo;
            this.tbUtilizator.Location = new System.Drawing.Point(692, 340);
            this.tbUtilizator.Name = "tbUtilizator";
            this.tbUtilizator.Size = new System.Drawing.Size(408, 24);
            this.tbUtilizator.TabIndex = 11;
            // 
            // tbParola
            // 
            this.tbParola.BackColor = System.Drawing.Color.White;
            this.tbParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbParola.ForeColor = System.Drawing.Color.Indigo;
            this.tbParola.Location = new System.Drawing.Point(692, 420);
            this.tbParola.Name = "tbParola";
            this.tbParola.PasswordChar = '*';
            this.tbParola.Size = new System.Drawing.Size(408, 24);
            this.tbParola.TabIndex = 12;
            this.tbParola.TextChanged += new System.EventHandler(this.tbParola_TextChanged);
            // 
            // pbIesire
            // 
            this.pbIesire.Image = ((System.Drawing.Image)(resources.GetObject("pbIesire.Image")));
            this.pbIesire.Location = new System.Drawing.Point(1211, 0);
            this.pbIesire.Name = "pbIesire";
            this.pbIesire.Size = new System.Drawing.Size(56, 37);
            this.pbIesire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIesire.TabIndex = 3;
            this.pbIesire.TabStop = false;
            this.pbIesire.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(522, 617);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Florarie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1266, 617);
            this.Controls.Add(this.tbParola);
            this.Controls.Add(this.tbUtilizator);
            this.Controls.Add(this.lbParola);
            this.Controls.Add(this.lbUtilizator);
            this.Controls.Add(this.pbIesire);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConectare);
            this.Controls.Add(this.lbTitlu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Florarie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Florarie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Florarie_FormClosing);
            this.Load += new System.EventHandler(this.Florarie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIesire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitlu;
        private System.Windows.Forms.Button btnConectare;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbIesire;
        private System.Windows.Forms.Label lbUtilizator;
        private System.Windows.Forms.Label lbParola;
        private System.Windows.Forms.TextBox tbUtilizator;
        private System.Windows.Forms.TextBox tbParola;
    }
}

