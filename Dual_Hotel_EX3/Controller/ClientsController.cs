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
    public class ClientsController : CommonController
    {

        Clients cl = new Clients();

        public ClientsController() {

            //

            fillClientsGrid();

            cl.Show();

        }

        private void fillClientsGrid()
        {

            try
            {
                cl.clientsGrid.ColumnCount = 2;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            cl.clientsGrid.Columns[0].Name = "Nom del client";
            cl.clientsGrid.Columns[0].DataPropertyName = "nom";
            cl.clientsGrid.Columns[0].Width = 250;
            cl.clientsGrid.Columns[1].Name = "idClient";
            cl.clientsGrid.Columns[1].DataPropertyName = "idClient";
            cl.clientsGrid.Columns[1].Visible = false;

            cl.clientsGrid.AutoGenerateColumns = false;

            cl.clientsGrid.DataSource = ClientsRepository.getClients();

        }
    }
}
