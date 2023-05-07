using System.Windows.Forms;

namespace Forme.UserControls
{
    partial class UCKorisnikPocetna
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvGlumci = new System.Windows.Forms.DataGridView();
            this.dgvFilmovi = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPretrazivanjeGlumaca = new System.Windows.Forms.TextBox();
            this.txtBoxPretrazivanjeFilmova = new System.Windows.Forms.TextBox();
            this.btnPretraziFilmove = new System.Windows.Forms.Button();
            this.btnPretraziGlumce = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGlumci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmovi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGlumci
            // 
            this.dgvGlumci.AllowUserToAddRows = false;
            this.dgvGlumci.AllowUserToDeleteRows = false;
            this.dgvGlumci.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dgvGlumci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGlumci.GridColor = System.Drawing.Color.NavajoWhite;
            this.dgvGlumci.Location = new System.Drawing.Point(396, 144);
            this.dgvGlumci.Name = "dgvGlumci";
            this.dgvGlumci.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGlumci.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.NavajoWhite;
            this.dgvGlumci.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGlumci.Size = new System.Drawing.Size(377, 249);
            this.dgvGlumci.TabIndex = 11;
            this.dgvGlumci.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGlumci_CellDoubleClick);
            // 
            // dgvFilmovi
            // 
            this.dgvFilmovi.AllowUserToAddRows = false;
            this.dgvFilmovi.AllowUserToDeleteRows = false;
            this.dgvFilmovi.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dgvFilmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmovi.GridColor = System.Drawing.Color.NavajoWhite;
            this.dgvFilmovi.Location = new System.Drawing.Point(13, 144);
            this.dgvFilmovi.Name = "dgvFilmovi";
            this.dgvFilmovi.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFilmovi.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.NavajoWhite;
            this.dgvFilmovi.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFilmovi.Size = new System.Drawing.Size(377, 249);
            this.dgvFilmovi.TabIndex = 10;
            this.dgvFilmovi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilmovi_CellClick);
            this.dgvFilmovi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilmovi_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pretrazivanje Glumaca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pretrazivanje Filmova";
            // 
            // txtBoxPretrazivanjeGlumaca
            // 
            this.txtBoxPretrazivanjeGlumaca.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtBoxPretrazivanjeGlumaca.Location = new System.Drawing.Point(454, 87);
            this.txtBoxPretrazivanjeGlumaca.Name = "txtBoxPretrazivanjeGlumaca";
            this.txtBoxPretrazivanjeGlumaca.Size = new System.Drawing.Size(233, 20);
            this.txtBoxPretrazivanjeGlumaca.TabIndex = 7;
            // 
            // txtBoxPretrazivanjeFilmova
            // 
            this.txtBoxPretrazivanjeFilmova.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtBoxPretrazivanjeFilmova.Location = new System.Drawing.Point(94, 87);
            this.txtBoxPretrazivanjeFilmova.Name = "txtBoxPretrazivanjeFilmova";
            this.txtBoxPretrazivanjeFilmova.Size = new System.Drawing.Size(233, 20);
            this.txtBoxPretrazivanjeFilmova.TabIndex = 6;
            // 
            // btnPretraziFilmove
            // 
            this.btnPretraziFilmove.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnPretraziFilmove.Location = new System.Drawing.Point(170, 113);
            this.btnPretraziFilmove.Name = "btnPretraziFilmove";
            this.btnPretraziFilmove.Size = new System.Drawing.Size(75, 23);
            this.btnPretraziFilmove.TabIndex = 12;
            this.btnPretraziFilmove.Text = "Pretrazi";
            this.btnPretraziFilmove.UseVisualStyleBackColor = false;
            this.btnPretraziFilmove.Click += new System.EventHandler(this.btnPretraziFilmove_Click);
            // 
            // btnPretraziGlumce
            // 
            this.btnPretraziGlumce.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnPretraziGlumce.Location = new System.Drawing.Point(540, 113);
            this.btnPretraziGlumce.Name = "btnPretraziGlumce";
            this.btnPretraziGlumce.Size = new System.Drawing.Size(75, 23);
            this.btnPretraziGlumce.TabIndex = 13;
            this.btnPretraziGlumce.Text = "Pretrazi";
            this.btnPretraziGlumce.UseVisualStyleBackColor = false;
            this.btnPretraziGlumce.Click += new System.EventHandler(this.btnPretraziGlumce_Click);
            // 
            // UCKorisnikPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPretraziGlumce);
            this.Controls.Add(this.btnPretraziFilmove);
            this.Controls.Add(this.dgvGlumci);
            this.Controls.Add(this.dgvFilmovi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxPretrazivanjeGlumaca);
            this.Controls.Add(this.txtBoxPretrazivanjeFilmova);
            this.Name = "UCKorisnikPocetna";
            this.Size = new System.Drawing.Size(787, 428);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGlumci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGlumci;
        private System.Windows.Forms.DataGridView dgvFilmovi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxPretrazivanjeGlumaca;
        private System.Windows.Forms.TextBox txtBoxPretrazivanjeFilmova;
        private System.Windows.Forms.Button btnPretraziFilmove;
        private System.Windows.Forms.Button btnPretraziGlumce;

        public DataGridView DgvGlumci { get => dgvGlumci; set => dgvGlumci = value; }
        public DataGridView DgvFilmovi { get => dgvFilmovi; set => dgvFilmovi = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public TextBox TxtBoxPretrazivanjeGlumaca { get => txtBoxPretrazivanjeGlumaca; set => txtBoxPretrazivanjeGlumaca = value; }
        public TextBox TxtBoxPretrazivanjeFilmova { get => txtBoxPretrazivanjeFilmova; set => txtBoxPretrazivanjeFilmova = value; }
        public Button BtnPretraziFilmove { get => btnPretraziFilmove; set => btnPretraziFilmove = value; }
        public Button BtnPretraziGlumce { get => btnPretraziGlumce; set => btnPretraziGlumce = value; }
    }
}
