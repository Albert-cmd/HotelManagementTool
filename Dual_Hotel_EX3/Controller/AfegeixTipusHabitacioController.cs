using Dual_Hotel_EX3.Model;
using Dual_Hotel_EX3.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dual_Hotel_EX3.Controller
{
    public class AfegeixTipusHabitacioController : CommonController
    {

        AfegirTipusHabitacio ath = new AfegirTipusHabitacio();

        TipusHabitacio th = new TipusHabitacio();

        string Nom = null;
        string Descripcio = null;
        int Capacitat = 0;
        decimal Suplement = 0;

        public AfegeixTipusHabitacioController() {

            //
            setupInputs();
            ath.Show();

        }

        public void setupInputs() {

            ath.nomInput.TextChanged += nomChanged;
            ath.descripcioInput.TextChanged += descripcioChanged;
            ath.capacitatInput.TextChanged += capacitatChanged;
            ath.suplementInput.TextChanged += suplementChanged;

            ath.afegirB.Click += afegirClick;

        }

        private void afegirClick(object sender, EventArgs e)
        {

            TipusHabitacioRepository.InsertTipus(th);
            ath.Close();

        }

        private void suplementChanged(object sender, EventArgs e)
        {

            try
            {

                Suplement = Decimal.Parse(ath.suplementInput.Text);
                if (checkIfEmptyOrNull(Suplement))
                {
                    Suplement = 0;
                }

            }
            catch (Exception ex)
            {

                Suplement = 0;
                ath.suplementInput.Text = "";

            }

            checkTipus();

        }

        private void capacitatChanged(object sender, EventArgs e)
        {

            try
            {

                Capacitat = Int32.Parse(ath.capacitatInput.Text);
                if (checkIfEmptyOrNull(Capacitat))
                {
                    Capacitat = 0;
                }

            }
            catch (Exception ex)
            {

                Capacitat = 0;
                ath.capacitatInput.Text = "";

            }

            checkTipus();
        }

        private void descripcioChanged(object sender, EventArgs e)
        {
            Descripcio = ath.descripcioInput.Text;
            if (checkIfEmptyOrNull(Descripcio))
            {
                Descripcio = null;
            }

            checkTipus();
        }

        private void checkTipus()
        {

            try
            {

                // int capacitat, string descripcio, decimal? suplementPersona, string nom
                th = new TipusHabitacio(Capacitat, Descripcio, Suplement, Nom);

                Console.WriteLine(th.ToString());
                bool tipusValid = false;

                if (Nom != null && Descripcio != null && Suplement != 0 && Capacitat != 0)
                {
                    tipusValid = true;
                }

                ath.afegirB.Enabled = tipusValid;

                Console.WriteLine(tipusValid);

            }
            catch (Exception ex)
            {
                //
            }

        }

        private void nomChanged(object sender, EventArgs e)
        {
            Nom = ath.nomInput.Text;
            if (checkIfEmptyOrNull(Nom))
            {
                Nom = null;
            }

            checkTipus();
        }
    }
}
