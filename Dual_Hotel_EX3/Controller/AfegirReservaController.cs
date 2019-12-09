using Dual_Hotel_EX3.Model;
using Dual_Hotel_EX3.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dual_Hotel_EX3.Controller
{

    public class AfegirReservaController
    {

        List<Hoste> hostes;

        AfegirReserva ar = new AfegirReserva();

        public AfegirReservaController() {

            //

            getHostes();
            ar.Show();

        }

        private void getHostes() {

            hostes = HosteRepository.getHostes();
            fillHostesCombobox();

        }

        private void fillHostesCombobox()
        {

            foreach (Hoste h in hostes) {
                ar.SeleccionaHosteInput.Items.Add(h);
            }

        }
    }
}
