using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dual_Hotel_EX3.Model
{
    public class TemporadaRepository
    {

        private static hotelEntities dataContext = new hotelEntities();

        private List<Temporada> _temporades { get; set; }

        public List<Temporada> temporades
        {
            get
            {
                return _temporades;
            }
            set
            {
                _temporades = value;
            }
        }

        public TemporadaRepository()
        {

            temporades = GetTemporadas();

        }

        public static List<Temporada> GetTemporadas()
        {

            try
            {
                List<Temporada> temporades = dataContext.Temporadas.ToList();
                return temporades;
            }
            catch (Exception ex) {
                List<Temporada> temporades = new List<Temporada>();
                return temporades;
            }

        }

        public static Temporada getTemporada(int IDTemporada)
        {
            try
            {
                Temporada t = dataContext.Temporadas.Where(x => x.IDTemporada == IDTemporada).SingleOrDefault();
                return t;
            }
            catch (Exception ex) {
                Temporada t = new Temporada();
                return t;
            }
        }

        public static Temporada InsertTemporada(Temporada t)
        {

            dataContext.Temporadas.Add(t);
            dataContext.SaveChanges();
            return getTemporada(t.IDTemporada);

        }

    }
}
