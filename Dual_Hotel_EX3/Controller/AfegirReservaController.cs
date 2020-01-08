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
        List<Servei> serveis;

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
            getServeis();

            ar.Show();

        }

        private void inputs() {

            ar.SeleccionaTipusInput.SelectedIndexChanged += actualitzarTipus;
            ar.quantitatInput.TextChanged += quantitatChanged;

            ar.SeleccionaTipusInput.SelectedIndexChanged += tipusHabitacioChanged;

        }

        private void tipusHabitacioChanged(object sender, EventArgs e)
        {

            calcPreus();

        }

        private void calcPreus() {

            tipusHab = (TipusHabitacio)ar.SeleccionaTipusInput.SelectedItem;

            try
            {

                importBrut = Math.Round(((Decimal)tipusHab.SuplementPersona * Int32.Parse(ar.quantitatInput.Text)), 2);
                IVA = Math.Round(((importBrut / 100) * 21),2);
                Total = Math.Round((importBrut + IVA),2);

                updateCamps();
            }
            catch (Exception ex)
            {
                importBrut = 0;
            }

        }

        private void updateCamps() {

            ar.importBaseInput.Text = importBrut.ToString();
            ar.IVAInput.Text = IVA.ToString();
            ar.importTotalInput.Text = Total.ToString();

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

            calcPreus();

            // CHECK

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
        private void getServeis()
        {

            serveis = ServeiRepository.getServeis();

            ar.ServeisList.AutoGenerateColumns = false;
            ar.ServeisList.DataSource = serveis;

            ar.ServeisList.Columns[0].Width = 200;

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
