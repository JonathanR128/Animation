using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReihenfolgeVonRotationenFestlegen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> GewaehlteZahlen = new List<double>();
            t = 6000;
            while (t > 0)
            {
                Console.WriteLine("Geben sie Rotationszahl ein, Sie haben noch {0} Sekunden:", t);

                double.TryParse(Console.ReadLine(),out double b);
                a = b;
                Zeitrunterzaehlen();

                GewaehlteZahlen.Add(a);


            }

            Console.WriteLine("Diese Zahlen haben Sie gewählt:");

            //Console.WriteLine();
            foreach (double Rotation in GewaehlteZahlen)
            {
                Console.WriteLine(Rotation);
            }
            Console.ReadLine();



        }

            
        public static double a { get; set; }
        public static double t { get; set; }

        public static void Zeitrunterzaehlen()
        {

            
            if (a == 1)
            {
                t += -500;
            }
            if (a == 2)
            {
                t += -500;
            }
            if (a == 3)
            {
                t += -500;
            }
            if (a == 3.1)
            {
                t += -500;
            }
            if (a == 4)
            {
                t += -2250;
            }
            if (a == 4.1)
            {
                t += -2250;
            }
            if (a == 5)
            {
                t += -1250;
            }
            if (a == 5.1)
            {
                t += -1500;
            }
            if (a == 6)
            {
                t += -1500;
            }
            if (a == 6.1)
            {
                t += -1750;
            }
            if (a == 6.2)
            {
                t += -1750;
            }
            if (a == 7)
            {
                t += -1750;
            }
            if (a == 7.1)
            {
                t += -1750;
            }
            if (a == 7.2)
            {
                t += -1750;
            }
            if (a == 7.3)
            {
                t += -2500;
            }
            if (a == 8)
            {
                t += -2750;
            }
            if (a == 8.1)
            {
                t += -2000;
            }
            if (a == 8.2)
            {
                t += -2250;
            }
            if (a == 8.3)
            {
                t += -3250; ;
            }
            if (a == 9)
            {
                t += -1750;
            }
            if (a == 9.1)
            {
                t += -2000;
            }
            if (a == 9.2)
            {
                t += -2250;
            }
            if (a == 10)
            {
                t += -1500;
            }
            if (a == 11)
            {
                t += -1750;
            }
            if (a == 11.1)
            {
                t += -1500;
            }
            if (a == 11.2)
            {
                t += -1250;
            }
            if (a == 12)
            {
                t += -1750;
            }
            if (a == 12.1)
            {
                t += -3000;
            }
            if (a == 13)
            {
                t += -750;
            }
            if (a == 13.1)
            {
                t += -750;
            }
            if (a == 14)
            {
                t += -750;
            }
            if (a == 14.1)
            {
                t += -750;
            }
            if (a == 15)
            {
                t += -1750;
            }
        }
        
    }      
    
}
