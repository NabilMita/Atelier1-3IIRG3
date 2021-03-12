using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    class Client
    {
        readonly string nom, prenom, adresse;
        public Client()
        {
            this.nom = "";
            this.prenom = "";
            this.adresse = "";
        }
        public Client(string n, string p, string a)
        {
            this.nom = n;
            this.prenom = p;
            this.adresse = a;
        }
        public void afficher()
        {
            Console.WriteLine("| NOM: \t" + this.nom + "\n| PRENOM: \t" + this.prenom + "\n|ADRESSE: \t" + this.adresse);
        }
    }
}
