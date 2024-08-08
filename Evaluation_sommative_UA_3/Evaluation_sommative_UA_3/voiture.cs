using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class voiture : Vehicule
{
    public int NombrePortes { get; set; }

    public voiture(string marque, string modele, int annee, string couleur, bool disponible, double prixLocationHeure, double prixLocationJour, int nombrePortes)
        : base(marque, modele, annee, couleur, disponible, prixLocationHeure, prixLocationJour)
    {
        NombrePortes = nombrePortes;
    }

    public override void AfficherDetails()
    {
        base.AfficherDetails();
        Console.WriteLine($"Nombre de portes: {NombrePortes}");
    }
}
