using HotelSystem.Memory;
using HotelSystem.Lib;

Console.WriteLine("Hotel System");

ClientRepository clientRepository = new ClientRepository();

foreach (var item in clientRepository.Clients)
{
    Console.WriteLine(item.Info());
}

int id = Convert.ToInt32(Console.ReadLine());
string? fullname = Console.ReadLine();
int passport = Convert.ToInt32(Console.ReadLine());
string? datebirth = Console.ReadLine();
string? gender = Console.ReadLine();

Client client = new Client(id, fullname, passport, datebirth, gender);

clientRepository.AddClient(client);
Console.WriteLine("Delete: ");
int index = Convert.ToInt32(Console.ReadLine());
clientRepository.Delete(index);

foreach (var item in clientRepository.Clients)
{
    Console.WriteLine(item.Info());
}
