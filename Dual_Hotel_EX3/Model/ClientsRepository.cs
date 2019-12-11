using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dual_Hotel_EX3.Model
{
    public class ClientsRepository
    {

        private static hotelEntities1 
            dataContext = new hotelEntities1();

        private List<Client> _clients { get; set; }

        public List<Client> clients
        {
            get
            {
                return _clients;
            }
            set
            {
                _clients = value;
            }
        }

        public ClientsRepository()
        {

            clients = getClients();

        }

        public static List<Client> getClients()
        {

            List<Client> clients = dataContext.Clients.OrderBy(x => x.Nom).ToList();
            return clients;

        }

        public static Client getClient(int IDClient)
        {
            Client c = dataContext.Clients.Where(x => x.IDClient == IDClient).SingleOrDefault();
            return c;
        }

        public static Client InsertClient(Client c)
        {

            dataContext.Clients.Add(c);
            dataContext.SaveChanges();
            return getClient(c.IDClient);

        }

    }
}
