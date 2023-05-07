using Domen;
using Forme.Forme;
using Forme.UserControls;
using Forme.UserControls.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forme
{
    public class AdministratorCoordinator
    {
        public Administrator Administrator { get; set; }
        private static AdministratorCoordinator instance;
        private FormAdministrator frmAdministrator;
        public static AdministratorCoordinator Instance
        {
            get
            {
                if (instance == null)
                    instance = new AdministratorCoordinator();
                return instance;
            }
        }

        private AdministratorCoordinator() { }
        public void ShowFrmAdministrator(Administrator administrator)
        {
            Administrator = administrator;
            frmAdministrator = new FormAdministrator();
            frmAdministrator.Show();
        }

        public void ShowAdministratorPocetka()
        {
           frmAdministrator.ChangeUserControl(new UCAdministratorPocetna());
        }

        public void ShowObradaZahtevaZaFilm(ZahtevZaFilm zahtevZaFilm)
        {
            frmAdministrator.ChangeUserControl(new UCObradaZahtevaZaFilm(zahtevZaFilm));
        }

        public void ShowObradaZahtevaZaGlumca(ZahtevZaGlumca zahtevZaGlumca)
        {
            frmAdministrator.ChangeUserControl(new UCObradaZahtevaZaGlumca(zahtevZaGlumca));
        }
    }
}
