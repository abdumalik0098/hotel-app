using HotelSystem.Lib;

namespace HotelSystem.Memory
{
    public class ClientRepository 
    {

        public List<Client> Clients = new List<Client>()
        {
            new Client(001, "Петр Петрович", 237489, "12-09-1988", "муж."),
            new Client(002, "Олег Петрович", 374658, "14-03-1998", "муж.")
        };

        public void AddClient(Client client)
        {
            Clients.Add(client);
        }

        public void Delete(int index)
        {
            if (index >= 0 && index < Clients.Count) Clients.RemoveAt(index);
        }
    }
}