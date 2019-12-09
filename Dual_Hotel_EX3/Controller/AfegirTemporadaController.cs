using Dual_Hotel_EX3.Model;
using Dual_Hotel_EX3.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dual_Hotel_EX3.Controller
{
    public class AfegirTemporadaController : CommonController
    {

        public AfegirTemporada at = new AfegirTemporada();
        public Temporada temporada;

        public bool valid = false;

        public bool nomvalid = false;
        public List<Temporada> temporades;

        public string NomTemporada { get; set; }
        public decimal Multiplicador { get; set; }
        public DateTime DataInici { get; set; }
        public DateTime DataFinal { get; set; }

        public AfegirTemporadaController() {

            //

            at.Show();

            at.nomTemporadaInput.TextChanged += nomTemporadaChanged;
            at.multiplicadorInput.TextChanged += multiplicadorChanged;

            at.dateTimeInici.ValueChanged += dateIniciChanged;
            at.dateTimeFinal.ValueChanged += dateFinalChanged;

            at.afegirTemporadaB.Click += AfegirTemporadaClick;
        }

        private void AfegirTemporadaClick(object sender, EventArgs e)
        {

            TemporadaRepository.InsertTemporada(temporada);
            at.Close();

        }

        private void dateFinalChanged(object sender, EventArgs e)
        {
            DataFinal = at.dateTimeFinal.Value;
            checkTemporada();
        }

        private void dateIniciChanged(object sender, EventArgs e)
        {

            DataInici = at.dateTimeInici.Value;
            checkTemporada();

        }

        private void multiplicadorChanged(object sender, EventArgs e)
        {

            Multiplicador = Decimal.Parse(at.multiplicadorInput.Text);
            if (checkIfEmptyOrNull(Multiplicador))
            {
                Multiplicador = 0;
            }

            checkTemporada();
        }

        private void nomTemporadaChanged(object sender, EventArgs e)
        {
            temporades = TemporadaRepository.GetTemporadas();
            NomTemporada = at.nomTemporadaInput.Text.ToString();
            checkTemporadaNom();

        }

        public void checkTemporadaNom() {

            nomvalid = true;

            foreach (Temporada t in temporades) {

                if (t.Nom.ToLower() == NomTemporada.ToLower()) {
                    nomvalid = false;
                }

            }

            if (!nomvalid)
            {

                at.nomErrorLabel.Visible = true;

            }
            else {

                at.nomErrorLabel.Visible = false;

            }

            checkGeneralValid();

        }

        public void checkGeneralValid() {

            if (nomvalid)
            {
                valid = true;
            }
            else {
                valid = false;
            }

            checkTemporada();

        }

        private void checkTemporada()
        {

            try
            {

                // string nom, string dNIPasaport, string telefon, string nacionalitat, string adreca, int codipostal, string poblacio
                temporada = new Temporada(NomTemporada, Multiplicador, DataInici, DataFinal);

                Console.WriteLine(temporada.ToString());
                bool temporadavalida = false;

                if (NomTemporada != null && Multiplicador != 0)
                {
                    temporadavalida = true;
                }

                at.afegirTemporadaB.Enabled = temporadavalida;

                Console.WriteLine(temporadavalida);

            }
            catch (Exception ex)
            {
                //
            }

        }
    }
}
