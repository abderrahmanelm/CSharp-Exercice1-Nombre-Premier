using System;

namespace VerifNombrePremier
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombre, a=0;

            Console.Write("Entrez un nombre: ");
            nombre = int.Parse(Console.ReadLine());

            for (int i=1; i <= nombre; i++) {
                if (nombre % i == 0) a++;
            }

            if (a == 2) {
                Console.WriteLine(nombre + " est un nombre premier.");
            }

            else {
                Console.WriteLine(nombre + " n'est pas un nombre premier.");
            }
        }
    }
}
