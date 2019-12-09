using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dual_Hotel_EX3.Controller
{
    public class CommonController
    {

        public bool checkIfEmptyOrNull(object val) {

            if (val.Equals("") || val == null)
            {
                return true;
            }
            else {
                return false;
            }

        }

    }
}
