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
            List<int> GewaehlteZahlen = new List<int>();
            t = 6000;
            while (t > 0)
            {
                Console.WriteLine("Geben sie Rotationszahl ein, Sie haben noch {0} Sekunden:", t);

                int.TryParse(Console.ReadLine(),out int b);
                a = b;
                Zeitrunterzaehlen();

                GewaehlteZahlen.Add(a);


            }

            Console.WriteLine("Diese Zahlen haben Sie gewählt:");

            //Console.WriteLine();
            foreach (int Rotation in GewaehlteZahlen)
            {
                Console.WriteLine(Rotation);
            }
            Console.ReadLine();



        }

            
        public static int a { get; set; }
        public static int t { get; set; }

        public static void Zeitrunterzaehlen()
        {
            switch (a)
            {
                case 1:
                    t -= 500;
                    break;
                case 2:
                    t -= 500;
                    break;
                case 3:
                    t -= 500;
                    break;
                case 4:
                    t -= 2250;
                    break;
                case 5:
                    t -= 1500;
                    break;
                case 6:
                    t -= 1500;
                    break;
                case 7:
                    t -= 1500;
                    break;
                case 8:
                    t -= 2750;
                    break;
                case 9:
                    t -= 1500;
                    break;
                case 10:
                    t -= 1500;
                    break;
                case 11:
                    t -= 1750;
                    break;
                case 12:
                    t -= 1750;
                    break;
                default:
                    break;

            }
        }
    }      
    
}
