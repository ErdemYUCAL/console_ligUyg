using System;

namespace console_ligUyg_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title=("lig uygulaması");
            Console.WriteLine("Hello World!");
            Console.WriteLine("futbol lig heyecanına hoşgeldiniz!");

            string fb = "fb", gs = "gs", bjk = "bjk", ts = "ts", svs = "svs", umr = "umr", hat = "hat", kon = "kon";

            int sayac = 1;

            Random gol = new Random();

            int a1, a2, a3;//fb
            int b1, b2, b3;//gs
            int c1, c2, c3;//bjk
            int d1, d2, d3;//ts
            int e1, e2, e3;//svs
            int f1, f2, f3;//umr
            int g1, g2, g3;//hat
            int h1, h2, h3;//kon

            int kazanantakım1, kazanantakım2, kazanantakım3, kazanantakım4, kazanantakım5, kazanantakım6, kazanantakım7;


            if (sayac==1)
            {
                a1 = gol.Next(0, 6);
                b1 = gol.Next(0, 6);
                c1 = gol.Next(0, 6);
                d1 = gol.Next(0, 6);
                e1 = gol.Next(0, 6);
                f1 = gol.Next(0, 6);
                g1 = gol.Next(0, 6);
                h1 = gol.Next(0, 6);
                
                Console.WriteLine("fb " + a1 + "-" + b1 + " gs");

                if (a1 > b1)
                {
                    Console.WriteLine("galibiyet: fb");
                    kazanantakım1 = a1;

                }
                else if (a1 == b1)
                {
                    Console.WriteLine("beraberlik");
                }
                else if (a1 < b1)
                {
                    Console.WriteLine("galibiyet: gs");
                    kazanantakım1 = b1;
                }

                Console.WriteLine("bjk " + c1 + "-" + d1 + " ts");

                if (c1 > d1)
                {
                    Console.WriteLine("galibiyet: bjk");
                    kazanantakım2 = c1;
                }
                else if (c1 == d1)
                {
                    Console.WriteLine("beraberlik");
                }
                else if (c1 < d1)
                {
                    Console.WriteLine("galibiyet: ts");
                    kazanantakım2 = d1;
                }

                Console.WriteLine("svs " + e1 + "-" + f1 + " umr");

                if (e1 > f1)
                {
                    Console.WriteLine("galibiyet: svs");
                    kazanantakım3 = e1;
                }
                else if (e1 == f1)
                {
                    Console.WriteLine("beraberlik");
                }
                else if (e1 < f1)
                {
                    Console.WriteLine("galibiyet: umr");
                    kazanantakım3 = f1;
                }

                Console.WriteLine("hat " + g1 + "-" + h1 + " kon");

                if (g1 > h1)
                {
                    Console.WriteLine("galibiyet: hat");
                    kazanantakım4 = g1;
                }
                else if (g1 == h1)
                {
                    Console.WriteLine("beraberlik");
                }
                else if (g1 < h1)
                {
                    Console.WriteLine("galibiyet: kon");
                    kazanantakım4 = h1;
                }

            }

            if (sayac==2)
            {
                kazanantakım1 = gol.Next(0, 6);
                kazanantakım2 = gol.Next(0, 6);
                kazanantakım3 = gol.Next(0, 6);
                kazanantakım4 = gol.Next(0, 6);

                Console.WriteLine(kazanantakım1);

            }

        }
    }
}
