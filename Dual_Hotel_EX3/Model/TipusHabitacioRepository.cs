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
            TipusHabitacio th = dataContext.TipusHabitacios.Where(x => x.IDTipus == IDTipus).SingleOrDefault();
            return th;
        }

        public static List<TipusHabitacio> getTipusHabitacions()
        {
            List<TipusHabitacio> tipus = dataContext.TipusHabitacios.ToList();
            return tipus;
        }

        public static TipusHabitacio InsertTipus(TipusHabitacio th)
        {

            dataContext.TipusHabitacios.Add(th);
            dataContext.SaveChanges();
            return getTipusHabitacio(th.IDTipus);

        }

    }
}
