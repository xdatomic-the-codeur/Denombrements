using System;

namespace Denombrements
{
    class Program
    {
        /// <summary>
        /// Main program execution
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int choix = 1;
            while (choix != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                choix = int.Parse(Console.ReadLine());

                if (choix == 0)
                {
                    Environment.Exit(0);
                }
                switch (choix)
                {
                    case 1:
                        {
                            // le nombre d'éléments à gérer
                            Console.Write("nombre total d'éléments à gérer = ");
                            // saisir le nombre
                            int nombreElements = int.Parse(Console.ReadLine());
                            // calcul de resultat
                            long resultat = 1;
                            for (int k = 1; k <= nombreElements; k++)
                                resultat *= k;
                            Console.WriteLine(nombreElements + "! = " + resultat);
                        }
                        break;

                    case 2:
                        {
                            // le nombre d'éléments à gérer
                            Console.Write("nombre total d'éléments à gérer = ");
                            // saisir le nombre
                            int nombreElements = int.Parse(Console.ReadLine());
                            // le sous ensemble
                            Console.Write("nombre d'éléments dans le sous ensemble = ");
                            // saisir le nombre
                            int nombreSousElements = int.Parse(Console.ReadLine());
                            // calcul de resultat
                            long resultat = 1;
                            for (int k = (nombreElements - nombreSousElements + 1); k <= nombreElements; k++)
                                resultat *= k;
                            //Console.WriteLine("résultat = " + (r1 / r2));
                            Console.WriteLine("A(" + nombreElements + "/" + nombreSousElements + ") = " + resultat);
                        }
                        break;

                    case 3:
                        {
                            // le nombre d'éléments à gérer
                            Console.Write("nombre total d'éléments à gérer = ");
                            // saisir le nombre
                            int nombreElements = int.Parse(Console.ReadLine());
                            // le sous ensemble
                            Console.Write("nombre d'éléments dans le sous ensemble = ");
                            int n = int.Parse(Console.ReadLine()); 
                            // calcul de r1
                            long r1 = 1;
                            r1 = Multiplication((nombreElements - n + 1), nombreElements, r1);
                            // calcul de r2
                            long r2 = 1;
                            r2 = Multiplication(1, n, r2);
                            // calcul de r3
                            Console.WriteLine("C(" + nombreElements + "/" + n + ") = " + (r1 / r2));
                        }
                        break;

                    default:
                        Console.WriteLine("Veuillez saisir un nombre dans la plage indiquée !");
                        break;
                }

            }
            Console.ReadLine();
        }

        static long Multiplication(int start, int nombre, long multiplieur)
        {
            for(int k = start; k <= nombre; k++)
            {
                multiplieur *= k;
            }

            return multiplieur;
        }
    }
}
