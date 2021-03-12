using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    class MAD
    {
        double valeur;

        public MAD(double valeur)
        {
            this.valeur=valeur;
        }

        public void afficher()
        {
            Console.Write("|\t\t\t"+ valeur+" MAD");
        }
        public bool supPLAFOND(MAD somme)
        {
            return this.valeur >= somme.valeur;
        }
        public bool estPositif()
        {
            return this.valeur > 0;
        }
        public static MAD operator+(MAD M1, MAD M2)
        {
            MAD MX = new MAD(0);
            MX.valeur = M1.valeur + M2.valeur;
            return MX;
        }
        public static MAD operator-(MAD M1, MAD M2)
        {
            MAD MX = new MAD(0);
            MX.valeur = M1.valeur - M2.valeur;
            return MX;
        }
    }
}
