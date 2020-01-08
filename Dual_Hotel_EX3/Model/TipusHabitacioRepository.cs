using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dual_Hotel_EX3.Model
{
    class TipusHabitacioRepository
    {

        private static hotelEntities dataContext = new hotelEntities();

        public static TipusHabitacio getTipusHabitacio(int IDTipus)
        {
            try
            {
                TipusHabitacio th = dataContext.TipusHabitacios.Where(x => x.IDTipus == IDTipus).SingleOrDefault();
                return th;
            }
            catch (Exception ex) {
                TipusHabitacio th = new TipusHabitacio();
                return th;
            }
        }

        public static List<TipusHabitacio> getTipusHabitacions()
        {
            try
            {
                List<TipusHabitacio> tipus = dataContext.TipusHabitacios.ToList();
                return tipus;
            }
            catch (Exception ex) {
                List<TipusHabitacio> tipus = new List<TipusHabitacio>();
                return tipus;
            }
        }

        public static TipusHabitacio InsertTipus(TipusHabitacio th)
        {

            dataContext.TipusHabitacios.Add(th);
            dataContext.SaveChanges();
            return getTipusHabitacio(th.IDTipus);

        }

    }
}
