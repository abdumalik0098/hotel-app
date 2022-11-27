using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Lib
{
    public class ApartmentType
    {
        public int Id { get; set; }
        public string? Type { get; set; }
        public int Price { get; set; }

        public ApartmentType(int id, string type, int price)
        {
            Id = id;
            Type = type;
            Price = price;
        }
    }
}
