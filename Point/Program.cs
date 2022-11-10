using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, n;
            //instanciation d'un objet Point
            Point p = new Point();                   
            Console.Out.Write("Donner l'abscisse: ");
            A = double.Parse(Console.In.ReadLine());
            Console.Out.Write("Donner l'ordonne: ");
            B = double.Parse(Console.In.ReadLine());
            //l'appel des méthodes sur l'objet p
            p.setAbscisse(A);
            p.setOrdonne(B);
            n = p.Distance();
            Console.Out.WriteLine("La distance du point (" + p.getAbscisse() + "," + p.getOrdonne() + ") est: " + n);
            Console.ReadKey();
            
        }
    }
}
