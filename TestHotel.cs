namespace Gestion_hotels
{
    internal class TestHotel
    {
        static void Main(string[] args)
        {
            //creation des client 
            Client client1 = new Client("Smith", "John", "john.smith@gmail.com", "1234 5678 9012 3456", 2);
            Client client2 = new Client("Johnson", "Emily", "emily.johnson@yahoo.com", "9876 5432 1098 7654", 12);
            Client client3 = new Client("Garcia", "Luis", "luisgarcia@hotmail.com", "5678 9012 3456 7890", 31);
            Client client4 = new Client("Kim", "David", "david.kim@gmail.com", "4321 0987 6543 2109", 15);
            Client client5 = new Client("Lee", "Anna", "anna.lee@hotmail.com", "2468 1357 5791 8642", 25);
            Client client6 = new Client("Patel", "Raj", "rajpatel@gmail.com", "1111 2222 3333 4444", 27);
            Client client7 = new Client("Wong", "Jennifer", "jennifer.wong@yahoo.com", "9999 8888 7777 6666", 16);
            Client client8 = new Client("Singh", "Amar", "amar.singh@hotmail.com", "5555 6666 7777 8888", 11);
            Client client9 = new Client("Rodriguez", "Maria", "maria.rodriguez@gmail.com", "4444 5555 6666 7777", 18);
            Client client10 = new Client("Park", "James", "james.park@yahoo.com", "8888 7777 6666 5555", 37);
            Client client11 = new Client("Chen", "Mei", "mei.chen@hotmail.com", "3333 4444 5555 6666", 28);
            Client client12 = new Client("Davis", "Michael", "michael.davis@gmail.com", "7777 8888 9999 0000", 46);
            Client client13 = new Client("Wilson", "Sarah", "sarah.wilson@hotmail.com", "6666 7777 8888 9999", 39);
            Client client14 = new Client("Brown", "Emma", "emma.brown@gmail.com", "1234 5678 9012 3456", 41);
            Client client15 = new Client("mohammed", "assas", "moh.assas@gmail.com", "1234 5678 9012 3456", 14);
            Client client16 = new Client("tadj", "eddine", "edd.tell@gmail.com", "1234 5678 9012 3456", 100);

            //Liste des clients 

            List<Client> CLients = new List<Client>{ client1 , client2, client3, client4 , client5, client6 , client7, client8, client9 ,client10, client11, client12
                ,client12,client13,client14,client15};


            //creation de l hotel
            Hotel hotel = new Hotel("Arc En Ciel", CLients);


            hotel.AjouterClient(client16);


            hotel.AjouterClient(client10);


            hotel.SuppurimerClient(client12);


            //affichage de le hotel "test toString"
            Console.WriteLine(hotel);

            //l'affichage des clients de l hotel
            foreach (Client client in CLients)
            {
                Console.WriteLine(client);
            }
        }
    }
}