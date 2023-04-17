using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Gestion_hotels
{
    internal class Client
    {
       //creation des propriete de la classe client sans attributs parceque il n y a pas des contraints sur les attributs





        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string NbCarte { get; set; }
        public int NbChambre { get; set; }


        //creation d'un constructeur qui intialise tout les atributs 
        public Client(string nom, string prenom, string email, string nbCarte, int nbChambre)
        {
            Nom = nom;
            Prenom = prenom;
            Email = email;
            NbCarte = nbCarte;
            NbChambre = nbChambre;
        }

        //La redefinition de la methode toString pour convertir un client a une chaine de charactere
        public override string ToString()
        {
            return $"Le Nom de Client :{Nom}\n" +
                $"Le Prenom de client :{Prenom}\n" +
                $"L'Email du client :{Email}" +
                $"\n******************************";
        }


        //la redefinition de la methode equals pour comparer l'objet courant avec l'objet passer en paramtere
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (!(obj is Client)) return false;
            Client client = obj as Client;
            return client.Nom.Equals(Nom) && client.Prenom.Equals(Prenom) && client.Email.Equals(Email);
        }

    }
}

