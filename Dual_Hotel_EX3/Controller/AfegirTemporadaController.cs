using Dual_Hotel_EX3.Model;
using Dual_Hotel_EX3.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dual_Hotel_EX3.Controller
{
    public class AfegirTemporadaController
    {

        public AfegirTemporada at = new AfegirTemporada();
        public Temporada temporada;

        public bool valid = false;

        public bool nomvalid = false;
        public List<Temporada> temporades;

        public string NomTemporada { get; set; }
        public string Multiplicador { get; set; }
        public DateTime DataInici { get; set; }
        public DateTime DataFinal { get; set; }

        public AfegirTemporadaController() {

            //

            at.Show();

            at.nomTemporadaInput.TextChanged += nomTemporadaChanged;
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

        public void checkTemporada() {



        }
    }
}
