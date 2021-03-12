using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    class Compte
    {
        readonly int numCpt;
        static int cpt;
        Client titulaire;
        MAD solde;
        static MAD plafond;
        static Compte() // Constructeur statique, on ne peut pas l'appeler, sert à initialiser tt les attributs statiques de la classe
        {
            cpt = 0;
            plafond = new MAD(30000);
        }
        public Compte(Client titu, MAD s)
        {
            this.numCpt = cpt++;
            this.titulaire = titu;
            this.solde = s;    
        }
        public bool crediter(MAD somme)
        {
            if (somme.estPositif()) {
                this.solde+=somme;
                return true;
            }
            return false;
        }
        public bool debiter(MAD somme)
        {
            if (somme.estPositif() && solde.estPositif() && plafond.supPLAFOND(somme))
            {
                this.solde -= somme;
                return true;
            }
            return false;
        }
        public bool verser(Compte C, MAD somme)
        {
            if (C.solde.estPositif())
            {
                if (this.debiter(somme))
                    return C.crediter(somme);
            }
            return false;
        }

        public void consulter()
        {
            Console.WriteLine("| Num Compte: \t " + this.numCpt);
            Console.WriteLine("| Titulaire Compte:");
            this.titulaire.afficher();
            Console.WriteLine("| Plafond du Compte:");
            plafond.afficher();
            Console.WriteLine("\n| Solde du Compte:");
            this.solde.afficher();
        }
    }
}
