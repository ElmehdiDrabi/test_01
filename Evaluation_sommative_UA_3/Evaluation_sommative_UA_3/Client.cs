using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Client
{
    public string Nom { get; set; }
    public string Courriel { get; set; }
    public string Adresse { get; set; }
    public int Telephone { get; set; }
    private List<ContratLocation> contratsLocation;

    public Client(string nom, string courriel, string adresse, int telephone)
    {
        Nom = nom;
        Courriel = courriel;
        Adresse = adresse;
        Telephone = telephone;
        contratsLocation = new List<ContratLocation>();
    }

    public void AjouterContratLocation(ContratLocation contrat)
    {
        contratsLocation.Add(contrat);
    }

    public void AfficherInfos()
    {
        Console.WriteLine($"Nom: {Nom}, Courriel: {Courriel}, Adresse: {Adresse}, Téléphone: {Telephone}");
    }

    public void AfficherLocations()
    {
        Console.WriteLine($"Locations pour {Nom}:");
        foreach (var contrat in contratsLocation)
        {
            Console.WriteLine($"Contrat Num: {contrat.NumeroContrat}, Objet: {contrat.ObjetContrat}, Actif: {contrat.Actif}");
        }
    }
}

