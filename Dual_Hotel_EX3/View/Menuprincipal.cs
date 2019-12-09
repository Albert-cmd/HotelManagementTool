using Dual_Hotel_EX3.Controller;
using Dual_Hotel_EX3.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dual_Hotel_EX3.View
{
    public partial class Menuprincipal : Form
    {
        public Menuprincipal()
        {
            InitializeComponent();

        }

        private void AfegirClientsB_Click(object sender, EventArgs e)
        {
            AfegirClient ac = new AfegirClient();
            ac.Show();
        }

        private void AfegirHostesB_Click(object sender, EventArgs e)
        {
            AfegirHosteController ahc = new AfegirHosteController();
   
        }

        private void UltimesReservesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClientsB_Click(object sender, EventArgs e)
        {

            ClientsController cc = new ClientsController();

        }

        private void HostesB_Click(object sender, EventArgs e)
        {

            HostesController hc = new HostesController();

        }

        private void AfegirReservaB_Click(object sender, EventArgs e)
        {

            AfegirReservaController arc = new AfegirReservaController();

        }

        private void ReservesB_Click(object sender, EventArgs e)
        {



        }

        private void AfegirTemporadaB_Click(object sender, EventArgs e)
        {
            AfegirTemporadaController atc = new AfegirTemporadaController();
        }
    }
}
