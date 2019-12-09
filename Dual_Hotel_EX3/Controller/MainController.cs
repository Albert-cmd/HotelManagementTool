using Dual_Hotel_EX3.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dual_Hotel_EX3.Controller
{
    class MainController : CommonController
    {

        Menuprincipal m;

        public MainController() {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            m = new Menuprincipal();

            //

            Application.Run(m);

        }

    }
}
