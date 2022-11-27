using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Lib
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public string? ArrivalDate { get; set; }
        public string? DepartureDate { get; set; }
        public List<Client> Client { get; set; }
        public List<Apartment> Apartment { get; set; }

        public Order(int id, int oredernumber, string arrivaldate, 
            string departuredate, List<Client> client, List<Apartment> apartment
            )
        {
            Id = id;
            OrderNumber = oredernumber;
            ArrivalDate = arrivaldate;
            DepartureDate = departuredate;
            Client = client;
            Apartment = apartment;
        }
    }
}
