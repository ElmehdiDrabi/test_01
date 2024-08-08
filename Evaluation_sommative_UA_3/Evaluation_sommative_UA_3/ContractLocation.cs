using Evaluation_sommative_UA_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class ContratLocation
{
    private int v1;
    private voiture voiture;
    private string v2;
    private DateTime now;
    private DateTime dateTime;
    private int v3;
    private Moto moto;

    public int NumeroContrat { get; set; }
    public string ObjetContrat { get; set; }
    public string TermesContrat { get; set; }
    public DateTime DebutContrat { get; set; }
    public DateTime FinContrat { get; set; }
    public double Montant { get; set; }
    public bool Actif { get; private set; }

    public ContratLocation(int numeroContrat, string objetContrat, string termesContrat, DateTime debutContrat, DateTime finContrat, double montant)
    {
        NumeroContrat = numeroContrat;
        ObjetContrat = objetContrat;
        TermesContrat = termesContrat;
        DebutContrat = debutContrat;
        FinContrat = finContrat;
        Montant = montant;
        Actif = false;
    }

    public ContratLocation(int v1, voiture voiture, string v2, DateTime now, DateTime dateTime, int v3)
    {
        this.v1 = v1;
        this.voiture = voiture;
        this.v2 = v2;
        this.now = now;
        this.dateTime = dateTime;
        this.v3 = v3;
    }

    public ContratLocation(int v1, Moto moto, string v2, DateTime now, DateTime dateTime, int v3)
    {
        this.v1 = v1;
        this.moto = moto;
        this.v2 = v2;
        this.now = now;
        this.dateTime = dateTime;
        this.v3 = v3;
    }

    public void ActiverContrat()
    {
        Actif = true;
        Console.WriteLine("Le contrat est activé.");
    }

    public void DesactiverContrat()
    {
        Actif = false;
        Console.WriteLine("Le contrat est désactivé.");
    }
}
