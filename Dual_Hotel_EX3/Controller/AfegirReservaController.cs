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
        Hoste hosteSelected = new Hoste();

        public List<TipusHabitacio> tipuss = new List<TipusHabitacio>();
        public List<Servei> serveis = new List<Servei>();
        public List<Servei> serveisSelected = new List<Servei>();
        public List<Temporada> temporades = new List<Temporada>();
        public Temporada temporadaSelected = new Temporada();

        public decimal preuServeis = 0;

        TipusHabitacio tipusHab = new TipusHabitacio();

        public AfegirServeiPopup asp;

        int qty = 0;

        decimal importBrut = 0;
        double dies = 1;
        decimal IVA = 0;
        decimal Total = 0;

        DateTime DataInici = new DateTime();
        DateTime DataFinal = new DateTime();

        AfegirReserva ar = new AfegirReserva();

        public AfegirReservaController() {

            //

            inputs();

            getHostes();
            getTipus();
            getServeis();
            getTemporades();

            getDates();

            ar.Show();

        }

        private void inputs() {

            ar.SeleccionaHosteInput.SelectedIndexChanged += hosteChanged;

            ar.SeleccionaTipusInput.SelectedIndexChanged += actualitzarTipus;
            ar.quantitatInput.TextChanged += quantitatChanged;

            ar.SeleccionaTipusInput.SelectedIndexChanged += tipusHabitacioChanged;
            ar.afegirServeiButton.Click += afegirServeiPopupOpen;

            ar.DataIniciInput.ValueChanged += dataChanged;
            ar.DataFinalInput.ValueChanged += dataChanged;

        }

        private void dataChanged(object sender, EventArgs e)
        {

            getDates();

        }

        private void getTemporades() {

            try
            {
                temporades = TemporadaRepository.GetTemporadas();
            }
            catch (Exception ex) {
                temporades = new List<Temporada>();
            }

        }

        private void getDates() {

            try
            {
                DataInici = ar.DataIniciInput.Value;
                DataFinal = ar.DataFinalInput.Value;
                temporadaSelected = calcTemporada();
                Console.WriteLine("TEMPORADA SELECCIONADA: " + temporadaSelected.Nom);
                ar.temporadaInput.Text = temporadaSelected.Nom;
                calcPreus();
            }
            catch (Exception ex) {
                //
            }

        }

        private Temporada calcTemporada()
        {

            Console.WriteLine(DataInici.Day + " " + DataInici.Month);

            foreach (Temporada t in temporades) {

                //Console.WriteLine(t.Nom);

                if (DataInici.Day >= t.DataIniciDay && DataInici.Day <= t.DataFinalDay)
                {

                    if (DataInici.Month == 1 || DataInici.Month == 2 || DataInici.Month == 12) {
                        return temporades[3];
                    } else if (DataInici.Month >= t.DataIniciMonth && DataInici.Month <= t.DataFinalMonth)
                    {
                        Console.WriteLine(t.Nom);
                        return t;
                    }


                }

            }

            return null;

        }

        private void hosteChanged(object sender, EventArgs e)
        {

            getHosteSelected();

        }

        private void getHosteSelected()
        {

            try
            {
                hosteSelected = (Hoste)ar.SeleccionaHosteInput.SelectedItem;
            }
            catch (Exception ex) {
                hosteSelected = new Hoste();
            }

        }

        private void afegirServeiPopupOpen(object sender, EventArgs e)
        {

            asp = new AfegirServeiPopup(this, serveis);
            asp.Show();

        }

        private void tipusHabitacioChanged(object sender, EventArgs e)
        {

            calcPreus();

        }

        private void calcPreus() {

            try
            {

                tipusHab = (TipusHabitacio)ar.SeleccionaTipusInput.SelectedItem;

                importBrut = Math.Round((((Decimal)tipusHab.SuplementPersona * Int32.Parse(ar.quantitatInput.Text)) * temporadaSelected.Multiplicador), 2);
                importBrut = Math.Round(importBrut * (Decimal)calcDies() , 2);

                IVA = Math.Round(((importBrut / 100) * 21),2);
                Total = Math.Round((importBrut + IVA + (Decimal)preuServeis),2);

                updateCamps();
            }
            catch (Exception ex)
            {
                importBrut = 0;
            }

        }

        private double calcDies() {

            this.dies = (DataFinal - DataInici).TotalDays;

            if (this.dies <= 0) {
                this.dies = 1;
            }

            return this.dies;

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

            try
            {
                hostes = HosteRepository.getHostes();
                fillHostesCombobox();
            }
            catch (Exception ex) {
                hostes = new List<Hoste>();
            }

        }

        private void getTipus() {

            try
            {
                tipuss = TipusHabitacioRepository.getTipusHabitacions();

                foreach (TipusHabitacio th in tipuss)
                {
                    ar.SeleccionaTipusInput.Items.Add(th);
                }

                ar.SeleccionaTipusInput.DisplayMember = "nom";
                ar.SeleccionaTipusInput.ValueMember = "nom";
            }
            catch (Exception ex) {
                //

                tipuss = new List<TipusHabitacio>();
            }

        }
        private void getServeis()
        {

            try
            {
                serveis = ServeiRepository.getServeis();

                ar.ServeisList.AutoGenerateColumns = false;
                ar.ServeisList.Columns[0].Width = 200;
                //ar.ServeisList.DataSource = serveis;
            }
            catch (Exception ex) {
                //
                serveis = new List<Servei>();

            }

        }

        public void updateServeis() {

            try
            {
                ar.ServeisList.DataSource = null;
                ar.ServeisList.DataSource = this.serveisSelected;
                preuServeisUpdate();
            }
            catch (Exception ex) {
                //
            }

        }

        private void preuServeisUpdate()
        {

            try {

                preuServeis = 0;
                foreach (Servei s in serveisSelected)
                {
                    preuServeis += (Decimal)s.Preu;
                }
                ar.preuServeisBox.Text = preuServeis.ToString();
                Console.WriteLine(preuServeis);
                calcPreus();

            } catch (Exception ex)
            {
                //
                preuServeis = 0;
            }

        }

        private void fillHostesCombobox()
        {

            try {

                foreach (Hoste h in hostes)
                {
                    ar.SeleccionaHosteInput.Items.Add(h);
                }

                ar.SeleccionaHosteInput.DisplayMember = "Nom";
                ar.SeleccionaHosteInput.ValueMember = "Nom";

            } catch (Exception ex)
            {
                //
            }

        }
    }
}
