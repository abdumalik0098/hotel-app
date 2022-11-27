using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Lib
{
    public class Employee:Person
    {
        
        public string? Post { get; set; }

        public Employee(int id, string fullname, int passportid, string post)
            :base(id, fullname, passportid)
        {
            Id = id;
            FullName = fullname;
            PassportId = passportid;
            Post = post;
        }
    }
}
