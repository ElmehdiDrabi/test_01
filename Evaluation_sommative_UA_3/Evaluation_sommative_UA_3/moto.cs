using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_sommative_UA_3
{
    public class Moto : Vehicule
    {
        public string TypeMoto { get; set; }
        public int Cylindree { get; set; }

        public Moto(string marque, string modele, int annee, string couleur, bool disponible, double prixLocationHeure, double prixLocationJour, string typeMoto, int cylindree)
            : base(marque, modele, annee, couleur, disponible, prixLocationHeure, prixLocationJour)
        {
            TypeMoto = typeMoto;
            Cylindree = cylindree;
        }

        public override void AfficherDetails()
        {
            base.AfficherDetails();
            Console.WriteLine($"Type de moto: {TypeMoto}, Cylindrée: {Cylindree}");
        }
    }
}
