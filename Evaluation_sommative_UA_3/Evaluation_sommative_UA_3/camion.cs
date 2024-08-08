using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_sommative_UA_3
{
    public class camion : Vehicule
    {
        public double CapaciteCharge { get; set; }
        public int NombreEssieux { get; set; }

        public camion(string marque, string modele, int annee, string couleur, bool disponible, double prixLocationHeure, double prixLocationJour, double capaciteCharge, int nombreEssieux)
            : base(marque, modele, annee, couleur, disponible, prixLocationHeure, prixLocationJour)
        {
            CapaciteCharge = capaciteCharge;
            NombreEssieux = nombreEssieux;
        }

        public override void AfficherDetails()
        {
            base.AfficherDetails();
            Console.WriteLine($"Capacité de charge: {CapaciteCharge} kg, Nombre d'essieux: {NombreEssieux}");
        }
    }
}
