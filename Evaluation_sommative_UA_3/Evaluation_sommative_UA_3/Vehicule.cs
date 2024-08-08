using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Vehicule
{
    public string Marque { get; set; }
    public string Modele { get; set; }
    public int Annee { get; set; }
    public string Couleur { get; set; }
    public bool Disponible { get; set; }
    public double PrixLocationHeure { get; set; }
    public double PrixLocationJour { get; set; }

    public Vehicule(string marque, string modele, int annee, string couleur, bool disponible, double prixLocationHeure, double prixLocationJour)
    {
        Marque = marque;
        Modele = modele;
        Annee = annee;
        Couleur = couleur;
        Disponible = disponible;
        PrixLocationHeure = prixLocationHeure;
        PrixLocationJour = prixLocationJour;
    }

    public virtual void AfficherDetails()
    {
        Console.WriteLine($"Marque: {Marque}, Modèle: {Modele}, Année: {Annee}, Couleur: {Couleur}, Disponible: {Disponible}, Prix/Heure: {PrixLocationHeure}, Prix/Jour: {PrixLocationJour}");
    }
}
