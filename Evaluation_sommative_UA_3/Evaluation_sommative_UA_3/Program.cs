using Evaluation_sommative_UA_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // Creation des vehicules
        voiture voiture = new voiture("Toyota", "Corolla", 2020, "Rouge", true, 15.0, 100.0, 4);
        Moto moto = new Moto("Yamaha", "MT-07", 2021, "Bleu", true, 10.0, 70.0, "Sport", 689);
        camion camion = new camion("Mercedes", "Actros", 2019, "Blanc", true, 20.0, 150.0, 20000, 3);

        // Affichage des details des vehicules
        voiture.AfficherDetails();
        moto.AfficherDetails();
        camion.AfficherDetails();

        // Creation d'un client
        Client client = new Client("Jean Dupont", "jean.dupont@hotmail.com", "123 Rue du rondpoint", 123456789);

        // Creation de contrats de location
        ContratLocation contrat1 = new ContratLocation(1, voiture, "Location de voiture pour une semaine", DateTime.Now, DateTime.Now.AddDays(7), 700);
        ContratLocation contrat2 = new ContratLocation(2, moto, "Location de moto pour trois jours", DateTime.Now, DateTime.Now.AddDays(3), 210);

        // Activation des contracts
        contrat1.ActiverContrat();
        contrat2.ActiverContrat();

        // Ajout des contrats au client
        client.AjouterContratLocation(contrat1);
        client.AjouterContratLocation(contrat2);

        // Affichage des informations du client et de ses locations
        client.AfficherInfos();
        client.AfficherLocations();
    }
}
