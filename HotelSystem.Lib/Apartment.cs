using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Lib
{
    public class Apartment
    {
        public int Id { get; set; }
        public int ApartmentNumber { get; set; }
        public int NumberOfRooms { get; set; }
        public int Floor { get; set; }
        public List<ApartmentType> ApartmentType { get; set; }
        public List<Employee> Employee { get; set; }

        public Apartment(int id, int apartmentnumber, int numofrooms, 
            int floor, List<ApartmentType> apartmenttype, List<Employee> employee)
        {
            Id = id;
            ApartmentNumber = apartmentnumber;
            NumberOfRooms = numofrooms;
            Floor = floor;
            ApartmentType = apartmenttype;
            Employee = employee;
        }
    }
}
