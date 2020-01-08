using Dual_Hotel_EX3.Model;
using Dual_Hotel_EX3.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dual_Hotel_EX3.Controller
{

    public class AfegirReservaController : CommonController
    {

        List<Hoste> hostes;
        List<TipusHabitacio> tipuss;

        TipusHabitacio tipusHab = new TipusHabitacio();

        int qty = 0;

        decimal importBrut = 0;
        decimal IVA = 0;
        decimal Total = 0;

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
            ar.quantitatInput.TextChanged += quantitatChanged;

        }

        private void quantitatChanged(object sender, EventArgs e)
        {

            try
            {

                qty = Int32.Parse(ar.quantitatInput.Text);
                if (checkIfEmptyOrNull(qty))
                {
                    qty = 0;
                }

            }
            catch (Exception ex)
            {

                qty = 0;
                ar.quantitatInput.Text = "";

            }

            calcImport();

            // CHECK

        }

        private void calcImport() {



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
