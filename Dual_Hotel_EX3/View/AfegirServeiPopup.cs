using Dual_Hotel_EX3.Controller;
using Dual_Hotel_EX3.Model;
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
    public partial class AfegirServeiPopup : Form
    {

        public AfegirReservaController arc;
        public List<Servei> serveis;

        public Servei serveiselected = new Servei();

        public AfegirServeiPopup(AfegirReservaController arc, List<Servei> serveis)
        {
            this.arc = arc;
            InitializeComponent();
            fillServeisBox();
        }

        private void fillServeisBox()
        {

            try
            {
                this.serveis = this.arc.serveis;
                serveisBox.DataSource = this.serveis;
            }
            catch (Exception ex) {
                //
            }

        }

        private void ServeisBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.serveiselected = (Servei)serveisBox.SelectedItem;
        }

        private void AfegirServeiB_Click(object sender, EventArgs e)
        {
            this.arc.serveisSelected.Add(serveiselected);
            this.arc.updateServeis();
            this.Close();
        }
    }
}
