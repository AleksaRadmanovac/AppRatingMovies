using System.Windows.Forms;

namespace Forme.UserControls.Admin
{
    partial class UCAdministratorPocetna
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
            this.dgvZahteviFilm = new System.Windows.Forms.DataGridView();
            this.dgvZahteviGlumac = new System.Windows.Forms.DataGridView();
            this.lblZahteviFilm = new System.Windows.Forms.Label();
            this.lblZahteviGlumac = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahteviFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahteviGlumac)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZahteviFilm
            // 
            this.dgvZahteviFilm.AllowUserToAddRows = false;
            this.dgvZahteviFilm.AllowUserToDeleteRows = false;
            this.dgvZahteviFilm.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dgvZahteviFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZahteviFilm.GridColor = System.Drawing.Color.NavajoWhite;
            this.dgvZahteviFilm.Location = new System.Drawing.Point(74, 79);
            this.dgvZahteviFilm.Name = "dgvZahteviFilm";
            this.dgvZahteviFilm.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZahteviFilm.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.NavajoWhite;
            this.dgvZahteviFilm.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvZahteviFilm.Size = new System.Drawing.Size(256, 305);
            this.dgvZahteviFilm.TabIndex = 0;
            this.dgvZahteviFilm.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZahteviFilm_CellDoubleClick);
            // 
            // dgvZahteviGlumac
            // 
            this.dgvZahteviGlumac.AllowUserToAddRows = false;
            this.dgvZahteviGlumac.AllowUserToDeleteRows = false;
            this.dgvZahteviGlumac.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dgvZahteviGlumac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZahteviGlumac.GridColor = System.Drawing.Color.NavajoWhite;
            this.dgvZahteviGlumac.Location = new System.Drawing.Point(432, 79);
            this.dgvZahteviGlumac.Name = "dgvZahteviGlumac";
            this.dgvZahteviGlumac.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZahteviGlumac.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.NavajoWhite;
            this.dgvZahteviGlumac.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvZahteviGlumac.Size = new System.Drawing.Size(256, 305);
            this.dgvZahteviGlumac.TabIndex = 1;
            this.dgvZahteviGlumac.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZahteviGlumac_CellDoubleClick);
            // 
            // lblZahteviFilm
            // 
            this.lblZahteviFilm.AutoSize = true;
            this.lblZahteviFilm.Location = new System.Drawing.Point(111, 60);
            this.lblZahteviFilm.Name = "lblZahteviFilm";
            this.lblZahteviFilm.Size = new System.Drawing.Size(187, 13);
            this.lblZahteviFilm.TabIndex = 2;
            this.lblZahteviFilm.Text = "Lista zahteva za unos i izmenu filmova";
            // 
            // lblZahteviGlumac
            // 
            this.lblZahteviGlumac.AutoSize = true;
            this.lblZahteviGlumac.Location = new System.Drawing.Point(473, 60);
            this.lblZahteviGlumac.Name = "lblZahteviGlumac";
            this.lblZahteviGlumac.Size = new System.Drawing.Size(188, 13);
            this.lblZahteviGlumac.TabIndex = 3;
            this.lblZahteviGlumac.Text = "Lista zahteva za unos i izmenu glumca";
            // 
            // UCAdministratorPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblZahteviGlumac);
            this.Controls.Add(this.lblZahteviFilm);
            this.Controls.Add(this.dgvZahteviGlumac);
            this.Controls.Add(this.dgvZahteviFilm);
            this.Name = "UCAdministratorPocetna";
            this.Size = new System.Drawing.Size(787, 428);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahteviFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahteviGlumac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZahteviFilm;
        private System.Windows.Forms.DataGridView dgvZahteviGlumac;
        private System.Windows.Forms.Label lblZahteviFilm;
        private System.Windows.Forms.Label lblZahteviGlumac;

        public DataGridView DgvZahteviFilm { get => dgvZahteviFilm; set => dgvZahteviFilm = value; }
        public DataGridView DgvZahteviGlumac { get => dgvZahteviGlumac; set => dgvZahteviGlumac = value; }
        public Label LblZahteviFilm { get => lblZahteviFilm; set => lblZahteviFilm = value; }
        public Label LblZahteviGlumac { get => lblZahteviGlumac; set => lblZahteviGlumac = value; }
    }
}
