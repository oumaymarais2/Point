using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    internal class Point
    {
        //L'attribut Abscisse
        private double Abscisse;            
        //L'attribut Ordonne
        private double Ordonne;             
        //Le getter d' Abscisse
        public double getAbscisse()        
        {
            return Abscisse;
        }
        //Le setter d' Abscisse
        public void setAbscisse(double A)  
        {
            Abscisse = A;
        }

        //Le getter de  Ordonne
        public double getOrdonne()          
        {
            return Ordonne;
        }
        //Le setter de  Ordonne
        public void setOrdonne(double B)    
        {
            Ordonne = B;
        }
        //Le constructeur par défaut
        public Point()                    
        {
        }
        //Le constructeur d'initialisation
        public Point(double A, double B)  
        {
            Abscisse = A;
            Ordonne = B;
        }
        //La méthode Distance
        public double Distance()              
        {
            return Math.Sqrt(Abscisse * Abscisse + Ordonne * Ordonne);
        }
        
    }
}
