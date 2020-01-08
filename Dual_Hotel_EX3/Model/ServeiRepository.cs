using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dual_Hotel_EX3.Model
{
    class ServeiRepository
    {

        private static hotelEntities dataContext = new hotelEntities();

        public static Servei getServei(int IDServei)
        {
            try
            {
                Servei s = dataContext.Serveis.Where(x => x.IDServei == IDServei).SingleOrDefault();
                return s;
            }
            catch (Exception ex)
            {
                Servei s = new Servei();
                return s;
            }

        }

        public static List<Servei> getServeis()
        {
            try
            {
                List<Servei> serveis = dataContext.Serveis.ToList();
                return serveis;
            }
            catch (Exception ex)
            {
                List<Servei> serveis = new List<Servei>();
                return serveis;
            }
        }

        public static Servei InsertServei(Servei s)
        {

            dataContext.Serveis.Add(s);
            dataContext.SaveChanges();
            return getServei(s.IDServei);

        }

    }
}
