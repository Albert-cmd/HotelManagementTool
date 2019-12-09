using Dual_Hotel_EX3.View;
using Dual_Hotel_EX3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dual_Hotel_EX3.Controller
{
    public class HostesController : CommonController
    {

        Hostes hl = new Hostes();

        public HostesController()
        {

            //

            fillHostesGrid();

            hl.Show();

        }

        private void fillHostesGrid()
        {

            try
            {
                hl.hostesGrid.ColumnCount = 7;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            hl.hostesGrid.Columns[0].Name = "Nom complet";
            hl.hostesGrid.Columns[0].DataPropertyName = "nom";
            hl.hostesGrid.Columns[0].Width = 200;

            hl.hostesGrid.Columns[1].Name = "DNI / Passaport";
            hl.hostesGrid.Columns[1].DataPropertyName = "DNIPasaport";
            hl.hostesGrid.Columns[1].Width = 150;

            hl.hostesGrid.Columns[2].Name = "Telèfon";
            hl.hostesGrid.Columns[2].DataPropertyName = "Telefon";

            hl.hostesGrid.Columns[3].Name = "Població";
            hl.hostesGrid.Columns[3].DataPropertyName = "Poblacio";

            hl.hostesGrid.Columns[4].Name = "Codi Postal";
            hl.hostesGrid.Columns[4].DataPropertyName = "Codipostal";

            hl.hostesGrid.Columns[5].Name = "Adreça";
            hl.hostesGrid.Columns[5].DataPropertyName = "Adreca";

            hl.hostesGrid.Columns[6].Name = "idClient";
            hl.hostesGrid.Columns[6].DataPropertyName = "idClient";
            hl.hostesGrid.Columns[6].Visible = false;

            hl.hostesGrid.AutoGenerateColumns = false;

            hl.hostesGrid.DataSource = HosteRepository.getHostes();

        }
    }
}
