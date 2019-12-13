using Dual_Hotel_EX3.Model;
using Dual_Hotel_EX3.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dual_Hotel_EX3.Controller
{

    public class AfegirReservaController
    {

        List<Hoste> hostes;
        List<TipusHabitacio> tipuss;

        TipusHabitacio tipusHab = new TipusHabitacio();

        AfegirReserva ar = new AfegirReserva();

        public AfegirReservaController() {

            //

            inputs();

            getHostes();
            getTipus();

            ar.Show();

        }

        private void inputs() {

            ar.SeleccionaTipusInput.SelectedIndexChanged += actualitzarTipus;

        }

        private void actualitzarTipus(object sender, EventArgs e)
        {
            tipusHab = (TipusHabitacio)ar.SeleccionaTipusInput.SelectedItem;
        }

        private void getHostes() {

            hostes = HosteRepository.getHostes();
            fillHostesCombobox();

        }

        private void getTipus() {

            tipuss = TipusHabitacioRepository.getTipusHabitacions();

            foreach (TipusHabitacio th in tipuss) {
                ar.SeleccionaTipusInput.Items.Add(th);
            }

            ar.SeleccionaTipusInput.DisplayMember = "nom";
            ar.SeleccionaTipusInput.ValueMember = "nom";

        }

        private void fillHostesCombobox()
        {

            foreach (Hoste h in hostes) {
                ar.SeleccionaHosteInput.Items.Add(h);
            }

            ar.SeleccionaHosteInput.DisplayMember = "Nom";
            ar.SeleccionaHosteInput.ValueMember = "Nom";

        }
    }
}
