using Domen;
using Forme.UserControls;
using Forme.UserControls.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.Forme
{
    public partial class FormAdministrator : Form
    {
        public FormAdministrator()
        {
            InitializeComponent();
            lblAdminUser.Text = AdministratorCoordinator.Instance.Administrator.Username;
            this.ChangeUserControl(new UCAdministratorPocetna());
        }

        public void ChangeUserControl(Control control)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            pnlMain.AutoSize = true;
        }

        private void pocetnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministratorCoordinator.Instance.ShowAdministratorPocetka();
        }
    }
}
