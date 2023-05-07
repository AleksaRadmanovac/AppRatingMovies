using Domen;
using Forme.UserControls;
using Forme.UserControls.Admin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.GUIControllers.Admin
{
    public class AdministratorPocetnaGUIController
    {

        public AdministratorPocetnaGUIController(UCAdministratorPocetna administratorPocetna)
        {
            try
            {
                administratorPocetna.DgvZahteviFilm.DataSource = Communication.Instance.UcitajListuZahteva();
                administratorPocetna.DgvZahteviGlumac.DataSource = Communication.Instance.UcitajListuZahtevaZaGlumca();
            }
            catch (IOException)
            {
                MainCoordinator.Instance.ServerskaGreska();
            }
            foreach (DataGridViewColumn kolona in administratorPocetna.DgvZahteviFilm.Columns)
            {
                kolona.Visible = false;
            }
            foreach (DataGridViewColumn kolona in administratorPocetna.DgvZahteviGlumac.Columns)
            {
                kolona.Visible = false;
            }
            administratorPocetna.DgvZahteviFilm.Columns["Id"].Visible = true;
            administratorPocetna.DgvZahteviFilm.Columns["Film"].Visible = true;
            administratorPocetna.DgvZahteviGlumac.Columns["Id"].Visible = true;
            administratorPocetna.DgvZahteviGlumac.Columns["Glumac"].Visible = true;
        }

        public void IzaberiZahtevZaFilm(UCAdministratorPocetna administratorPocetna)
        {
            try
            {
                ZahtevZaFilm zahtevZaFilm = (ZahtevZaFilm)administratorPocetna.DgvZahteviFilm.SelectedRows[0].DataBoundItem;
                AdministratorCoordinator.Instance.ShowObradaZahtevaZaFilm(zahtevZaFilm);
            }
            catch (Exception) { }
        }

        public void IzaberiZahtevZaGlumca(UCAdministratorPocetna administratorPocetna)
        {
            try
            {
                ZahtevZaGlumca zahtevZaGlumca = (ZahtevZaGlumca)administratorPocetna.DgvZahteviGlumac.SelectedRows[0].DataBoundItem;
                AdministratorCoordinator.Instance.ShowObradaZahtevaZaGlumca(zahtevZaGlumca);
            }
            catch (Exception) { }
        }

    }
}
