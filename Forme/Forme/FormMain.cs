using Forme.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public partial class FormMain : Form
    {
        public bool PrijavaAdministratora = false;
        public FormMain()
        {
            InitializeComponent();
            this.ChangeUserControl(new UCLogin());
        }

        public void ChangeUserControl(Control control)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            pnlMain.AutoSize = true;
        }


    }
}
