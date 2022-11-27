namespace HotelSystem.Lib
{
    public class Client:Person
    {
        public string? DateOfBirth { get; set; }
        public string? Gender { get; set; }

        public Client(int id, string fullname, int passportid, string dateofbirth, string gender)
            :base(id, fullname, passportid)
        {
            Id = id;
            FullName = fullname;
            PassportId = passportid;
            DateOfBirth = dateofbirth;
            Gender = gender;
        }

        public string Info()
        {
            return $"Id: {Id} \n" +
                $"Fullname: {FullName} \n" +
                $"Passport: {PassportId} \n" +
                $"Date of Birth: {DateOfBirth} \n" +
                $"Gender: {Gender}\n";
        }


    }
}