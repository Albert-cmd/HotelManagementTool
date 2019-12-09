using Dual_Hotel_EX3.Model;
using Dual_Hotel_EX3.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dual_Hotel_EX3.Controller
{
    public class AfegirHosteController : CommonController
    {

        AfegirHoste ah = new AfegirHoste();
        List<Hoste> hostes;

        bool dnivalid;
        bool nomvalid;
        bool valid;

        // HOSTE

        public Hoste hoste = null;

        string Nom = null;
        string DNIPasaport = null;
        string Telefon = null;
        string Nacionalitat = null;
        string Adreca = null;
        int Codipostal = 0;
        string Poblacio = null;

        // END HOSTE

        public AfegirHosteController() {

            ah.DNIPassaportInput.TextChanged += CheckIfDNIValid;
            ah.nomCompletInput.TextChanged += CheckIfNomValid;

            ah.telefonInput.TextChanged += telefonInputChanged;
            ah.nacionalitatInput.TextChanged += nacionalitatInputChanged;
            ah.adrecaInput.TextChanged += adrecaInputChanged;
            ah.codiPostalInput.TextChanged += codiPostalInputChanged;
            ah.poblacioInput.TextChanged += poblacioInputChanged;

            ah.afegirClientB.Click += afegirHosteClick;

            hostes = HosteRepository.getHostes();

            ah.Show();
        }

        private void poblacioInputChanged(object sender, EventArgs e)
        {

            Poblacio = ah.poblacioInput.Text;
            if (checkIfEmptyOrNull(Poblacio))
            {
                Poblacio = null;
            }

            checkHoste();
        }

        private void codiPostalInputChanged(object sender, EventArgs e)
        {

            try
            {

                Codipostal = Int32.Parse(ah.codiPostalInput.Text);
                if (checkIfEmptyOrNull(Codipostal))
                {
                    Codipostal = 0;
                }

            }
            catch (Exception ex) {

                Codipostal = 0;
                ah.codiPostalInput.Text = "";

            }

            checkHoste();
        }

        private void adrecaInputChanged(object sender, EventArgs e)
        {

            Adreca = ah.adrecaInput.Text;
            if (checkIfEmptyOrNull(Adreca))
            {
                Adreca = null;
            }

            checkHoste();
        }

        private void nacionalitatInputChanged(object sender, EventArgs e)
        {

            Nacionalitat = ah.nacionalitatInput.Text;
            if (checkIfEmptyOrNull(Nacionalitat))
            {
                Nacionalitat = null;
            }

            checkHoste();

        }

        private void telefonInputChanged(object sender, EventArgs e)
        {

            Telefon = ah.telefonInput.Text;
            if (checkIfEmptyOrNull(Telefon))
            {
                Telefon = null;
            }

            checkHoste();

        }

        // nomCompletInput

        public void checkGeneralValid() {

            if (dnivalid && nomvalid) {
                valid = true;
            } else {
                valid = false;
            }

            checkHoste();

        }

        private void checkHoste()
        {

            try
            {

                // string nom, string dNIPasaport, string telefon, string nacionalitat, string adreca, int codipostal, string poblacio
                hoste = new Hoste(Nom, DNIPasaport, Telefon, Nacionalitat, Adreca, Codipostal, Poblacio);

                Console.WriteLine(hoste.ToString());
                bool hostevalid = false;

                if (Nom != null && DNIPasaport != null && Telefon != null && Nacionalitat != null && Adreca != null
                    && Codipostal != 0 && Poblacio != null) {
                    hostevalid = true;
                }

                ah.afegirClientB.Enabled = hostevalid;

                Console.WriteLine(hostevalid);

            }
            catch (Exception ex)
            {
                //
            }

        }

        public void CheckIfNomValid(Object sender, EventArgs e)
        {

            Nom = ah.nomCompletInput.Text.ToString();
            Console.WriteLine(Nom);

            nomvalid = true;

            try
            {
                foreach (Hoste h in hostes)
                {

                    if (h.Nom.ToLower() == Nom.ToLower())
                    {
                        nomvalid = false;
                    }

                }
            }
            catch (NullReferenceException ex) {
                // NO HI HAN HOSTES
                nomvalid = true;
            }

            if (!nomvalid)
            {
                Nom = null;
                ah.nomErrorLabel.Visible = true;
            }
            else
            {
                ah.nomErrorLabel.Visible = false;
            }

            checkGeneralValid();

        }

        public void CheckIfDNIValid(Object sender, EventArgs e)
        {
            
            DNIPasaport = ah.DNIPassaportInput.Text.ToString();
            Console.WriteLine(DNIPasaport);

            dnivalid = true;

            try
            {
                foreach (Hoste h in hostes)
                {

                    if (h.DNIPasaport.ToLower() == DNIPasaport.ToLower())
                    {
                        dnivalid = false;
                    }

                }
            }
            catch (NullReferenceException ex) {
                // NO HI HAN HOSTES
                dnivalid = true;
            }
            

            if (!dnivalid)
            {
                DNIPasaport = null;
                ah.dniErrorLabel.Visible = true;
            }
            else {
                ah.dniErrorLabel.Visible = false;
            }

            checkGeneralValid();

        }

        private void afegirHosteClick(object sender, EventArgs e)
        {
            HosteRepository.InsertHoste(hoste);
        }
    }
}
