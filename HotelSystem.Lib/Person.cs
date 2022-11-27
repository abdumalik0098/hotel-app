using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Lib
{
    public class Person
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public int PassportId { get; set; }
        public Person(int id, string fullname, int passportid)
        {
            Id = id;
            FullName = fullname;
            PassportId = passportid;
        }
    }
}
