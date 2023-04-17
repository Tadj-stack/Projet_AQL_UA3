using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_hotels
{
    internal class Hotel
    {
        // le Nom de l hotel et la liste des client de l'hotel 
        public string NomDeHotel { get; set; }
        public List<Client> Clients { get; set; }
        //un contructeur qui intialise le nom de l'hotel et la liste des client 
        public Hotel(string nomDeHotel, List<Client> clients)
        {
            NomDeHotel = nomDeHotel;
            Clients = clients;
        }
        //La redefinition de la methode toString
        public override string ToString()
        {
            return $"Le Nom de l'Hotel :{NomDeHotel}\n**************";
        }


        //Methode pour ajouter un client a la liste des client de l'hotel 
        public void AjouterClient(Client client)
        {



            //une condition pour verifier si le client se trouve deja dans la liste des clients 
            if (!Clients.Contains(client))
            {

                Clients.Add(client);
            }
            else { Console.WriteLine($"Le client {client.Nom} {client.Prenom} existe deja dans la liste des clients"); }

        }
        //Methode permet de supprimer un client a la liste des client de l'hotel
        public void SuppurimerClient(Client client)
        {

            //une condition pour verifier si le client se trouve deja dans la liste des clients 
            if (Clients.Contains(client))

            {
                Clients.Remove(client);
            }
            else { Console.WriteLine($"Le client {client.Nom} {client.Prenom} n'existe pas dans la liste des clients"); }
        }




    }
}
