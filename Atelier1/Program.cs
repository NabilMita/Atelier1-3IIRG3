using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    class Program
    {
        static void Main(string[] args)
        {
            Client user = new Client("MITA", "NABIL", "RUE LA FONTAINE, PARIS");
            MAD Solde = new MAD(8900);
            Compte C = new Compte(user, Solde);

            Client user2 = new Client("TEST", "BOT", "RUE LA MACHINE, MAROC");
            MAD Solde2 = new MAD(5000);
            Compte C2 = new Compte(user2, Solde2);

            C.consulter();
            Console.WriteLine("\nEntrez le solde à créditer: ");
            double NvSolde = double.Parse(Console.ReadLine());
            Console.WriteLine("\n| Operation => CREDITER: \n");
            MAD NouvSolde = new MAD(NvSolde);
            C.crediter(NouvSolde);
            C.consulter();
            Console.WriteLine("\n| Operation => DEBITER: \n");
            MAD SoldeDebit = new MAD(2000);
            C.debiter(NouvSolde);
            C.consulter();
            Console.WriteLine("\n| Operation => VERSEMENT: \n");
            C.verser(C2, SoldeDebit);
            C.consulter();
            C2.consulter();

            Console.ReadKey();
        }
    }
}
