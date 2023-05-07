using Forme.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public class MainCoordinator
    {
        private static MainCoordinator instance;
        private FormMain frmMain;
        public UCLogin ucLogin;
        public static MainCoordinator Instance
        {
            get 
            { 
                if(instance ==null)
                    instance = new MainCoordinator();
                return instance;
            }     
        }

        private MainCoordinator() { }

        public void ShowFrmMain()
        {
            Communication.Instance.Connect();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmMain = new FormMain();
            ucLogin = new UCLogin();
            frmMain.ChangeUserControl(ucLogin);
            Application.Run(frmMain);
        }

        public void ShowRegistracija()
        { 
            frmMain.ChangeUserControl(new UCRegistracija());
        }

        public void ShowLogin()
        { 
            frmMain.ChangeUserControl(ucLogin);
        }

        public void Hide()
        { 
            frmMain.Hide();
        }

        public void ServerskaGreska()
        {
            DialogResult dr = MessageBox.Show("Server je ugasen","Pokusajte ponovo", MessageBoxButtons.RetryCancel);
            if(dr == DialogResult.Retry) 
            {
                Communication.Instance.Connect();
            }
            if (dr == DialogResult.Cancel)
            { 
            }
            //Application.Exit();
        }
        


    }
}
