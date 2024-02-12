using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FP_seria_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //P1();
            //P2();
            //P3();
            //P4();
            //P5();
            //P6();
            //P7();
            //P8();
            //P9();
            //P10();
            //P11();
            //P12();
            //P13();
            //P14();
            //P15();
            //P16();
            //prob 17
            //int a, b;
            //Console.WriteLine("Dati cele 2 nr: ");
            //a = int.Parse(Console.ReadLine());
            //b = int.Parse(Console.ReadLine());
            //CMMDC(a, b);
            //CMMMC(a, b);
            //P18();
            //P19();
            //P20();
            //P21();

        }
        private static void P1()
        {
            float a, b, x;
            Console.WriteLine("Dati a si b: ");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                    Console.WriteLine("Ecuatie nedeterminata");
                else
                    Console.WriteLine("Ecuatie imposibila");
            }
            else
            {
                x = (-b) / a;
                Console.WriteLine("Numarul x e egal cu: " + x);
            }
        }
        private static void P2()
        {
            double a, b, c, x1, x2;
            double delta, aux;
            Console.WriteLine("Dati a,b,c: ");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());
            delta = b * b - 4 * a * c;
            aux = Math.Sqrt(delta);
            if (delta > 0)
            {
                x1 = (-b + aux) / 2*a;
                x2 = (-b - aux) / 2*a;
                Console.WriteLine("Solutiile ecuatiei sunt: " + x1 + "," + x2);
            }
            else
                if (delta == 0)
            {
                x1 = x2 = (-b) / 2 * a;
                Console.WriteLine("Solutia ecuatiei este: " + x1);
            }
            else
                if (delta < 0)
                Console.WriteLine("Ecuatia nu are solutii reale");
        }
        private static void P3()
        {
            int n, k;
            Console.WriteLine("Dati n si k: ");
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            if (n % k == 0)
                Console.WriteLine("Numarul n se divide cu k");
            else
                Console.WriteLine("Numarul n nu se divide cu k");
        }
        private static void P4()
        {
            int y;
            Console.WriteLine("Dati y(anul): ");
            y = int.Parse(Console.ReadLine());
            if (y % 100 != 0 && y % 4 == 0)
            {
                Console.WriteLine($"{y} e an bisect");
            }
            else
                if (y % 400 == 0)
                Console.WriteLine($"{y} e an bisect");
            else
                Console.WriteLine($"{y} nu e an bisect");
        }
        private static void P5()
        {
            int numar, cifra, k, aux = 0;

            Console.WriteLine("Dati numarul si a k cifra: ");
            numar = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            while (numar > 0)
            {
                cifra = numar % 10;
                numar = numar / 10;
                aux++;
                if (aux == k)
                {
                    Console.WriteLine(cifra);
                }
            }
        }
        private static void P6()
        {
            int a, b, c;
            Console.WriteLine("Dati a,b,c: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (a < b + c && b < a + c && c < a + b)
                Console.WriteLine($"{a},{b},{c} pot fi lungimile lat unui tr");
            else
                Console.WriteLine($"{a},{b},{c} nu pot fi lungimile lat unui tr");
        }
        private static void P7()
        {
            int a, b, value;
            Console.WriteLine("Dati a si b: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            value = a;
            a = b;
            b = value;
            Console.WriteLine("Rezultatul este: " + a + "," + b);
        }
        private static void P8()
        {
            int a, b;
            Console.WriteLine("Dati a si b: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            (a, b) = (b, a);
            Console.WriteLine("Rezultatul este: " + a + "," + b);
        }
        private static void P9()
        {
            int n, d;
            Console.WriteLine("Dati n: ");
            n = int.Parse(Console.ReadLine());
            if (n == 0)
                Console.WriteLine("Introduceti alt numar");
            for (d = 1; d * d <= n; d++)
                if (n % d == 0)
                {
                    Console.Write($"{d},{n / d}");
                    Console.WriteLine();
                }
        }
        private static void P10()
        {
            int n, d;
            Console.WriteLine("Dati n: ");
            n = int.Parse(Console.ReadLine());
            if (n < 2)
                Console.WriteLine($"{n} nu e prim");
            else
                if (n % 2 == 0 && n != 2)
                Console.WriteLine($"{n} nu e prim");
            else
                for (d = 3; d * d <= n; d++)
                    if (n % d == 0)
                        Console.WriteLine($"{n} nu e prim");
                    else
                        Console.WriteLine($"{n} e prim");
        }
        private static void P11()
        {
            int n, cifra, i, aux = 0;
            Console.WriteLine("Dati n: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                cifra = n % 10;
                n = n / 10;
                Console.Write(cifra + ",");
            }
        }
        private static void P12() 
        {
            int n, a, b, d, numara = 0;
            Console.WriteLine("Dati n,a si b");
            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            for (d = a; d <= b; d++)
            {
                if (n % d == 0)
                    numara++;
            }
            Console.WriteLine(numara);
        }
        private static void P13()
        {
            int y1, y2, numara = 0, i;
            Console.WriteLine("Dati anii: ");
            y1 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());
            for (i = y1 + 1; i <= y2 - 1; i++)
            {
                if (i % 100 != 0 && i % 4 == 0)
                    numara++;
                else
                    if (i % 400 == 0)
                    numara++;
            }
            Console.WriteLine("Intre y1 si y2 sunt " + numara + " ani bisecti");
            ////sau
            //for (i = y1 + 1; i <= y2 - 1; i++)
            //{
            //    if (i % 100 != 0 && i % 4 == 0)
            //        numara++;
            //    else
            //        if (i % 400 == 0)
            //        numara++;
            //}
        }
        private static void P14()
        {
            int n, cifra, p = 0, aux;
            Console.WriteLine("Dati n: ");
            n = int.Parse(Console.ReadLine());
            aux = n;
            while (n > 0)
            {
                cifra = n % 10;
                n = n / 10;
                p = p * 10 + cifra;
            }
            if (p == aux)
            {
                Console.WriteLine($"Numarul {aux} este palindrom");
            }
            else
                Console.WriteLine($"Numarul {aux} nu este palindrom");

        }
        private static void P15()
        {
            int a, b, c;
            Console.WriteLine("Dati cele 3 numere: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (a >= b && a >= c)
                if (b >= c)
                    Console.Write(c + "," + b + "," + a);
                else
                    Console.Write(b + "," + c + "," + a);
            else
                if (b >= c && b >= a)
                if (a >= c)
                    Console.Write(c + "," + a + "," + b);
                else
                    Console.Write(a + "," + c + "," + b);
            else
                if (c >= a && c >= b)
                if (a >= b)
                    Console.WriteLine(b + "," + a + "," + c);
                else
                    Console.WriteLine(a + "," + b + "," + c);
        }
        private static void P16()
        {
            int a, b, c, d, e;
            Console.WriteLine("Dati cele 5 numere: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());
            int aux, i, j;
            for (i = 0; i < 4; i++)
            {
                for (j = i + 1; j < 5; j++)
                {
                    if (a >= b)
                    {
                        aux = a;
                        a = b;
                        b = aux;
                    }
                    if (b >= c)
                    {
                        aux = b;
                        b = c;
                        c = aux;
                    }
                    if (c >= d)
                    {
                        aux = c;
                        c = d;
                        d = aux;
                    }
                    if (d >= e)
                    {
                        aux = d;
                        d = e;
                        e = aux;
                    }
                }
            }
            Console.WriteLine("Numerele in ordine crescatoare sunt: ");
            Console.WriteLine($"{a} {b} {c} {d} {e}");
        }
        private static void CMMDC(int a, int b)
        {
            int r;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            if (a == 0 && b == 0)
                Console.WriteLine("Nu exista un cmmdc");
            else
                Console.WriteLine(a);
        }
        private static void CMMMC(int a, int b)
        {
            int r, p;
            p = a * b;
            do
            {
                r = a % b;
                a = b;
                b = r;
            } while (r != 0);
            Console.WriteLine(p / a);
        }
        private static void P18()
        {
            int n, d = 2, p;
            Console.WriteLine("Dati numarul: ");
            n = int.Parse(Console.ReadLine());
            while (n > 1)
            {
                p = 0;
                while (n % d == 0)
                {
                    p++;
                    n /= d;
                }
                if (p != 0)
                    Console.Write($"{d}^{p} * ");
                d++;
                if (n > 1 && d * d > n)
                    d = n;
            }
        }
        private static void P19()
        {
            Console.Write("Introduceti un numar: ");
            int n = int.Parse(Console.ReadLine());

            string numarString = n.ToString();
            bool ok = true;
            char pcif = '\0'; 
            char dcif = '\0'; 

            foreach (char cifra in numarString)
            {
                if (!Char.IsDigit(cifra))
                {
                    Console.WriteLine("Introduceți un număr valid.");
                    return;
                }

                if (pcif == '\0')
                {
                    pcif = cifra;
                }
                else if (cifra != pcif)
                {
                    if (dcif == '\0')
                    {
                        dcif = cifra;
                    }
                    else if (cifra != dcif)
                    {
                        ok = false;
                        break;
                    }
                }
            }

            if (ok)
            {
                Console.WriteLine("Numărul este format doar din două cifre care se pot repeta.");
            }
            else
            {
                Console.WriteLine("Numărul nu este format doar din două cifre care se pot repeta.");
            }

        }
        private static void P20()
        {
            int m, n;
            Console.WriteLine("Dati m: ");
            m=int.Parse(Console.ReadLine());
            Console.WriteLine("Dati n: ");
            n=int.Parse(Console.ReadLine());
            int parteInt, parteFract;
            parteInt = m / n; 
            parteFract = m % n; 
            Console.Write($"{parteInt},");
            int cifra, rest;
            List<int> resturi = new List<int>();
            List<int> cifre = new List<int>();
            resturi.Add(parteFract);
            bool periodic = false;
            do
            {
                cifra = parteFract * 10 / n;
                cifre.Add(cifra);
                rest = parteFract * 10 % n;
                if (!resturi.Contains(rest))
                {
                    resturi.Add(rest);
                }
                else
                {
                    periodic = true;
                    break;
                }
                parteFract = rest;
            } while (rest != 0);

            if (!periodic)
            {
                foreach (var item in cifre)
                {
                    Console.Write(item);
                }
            }
            else
            {
                for (int i = 0; i < resturi.Count; i++)
                {
                    if (resturi[i] == rest)
                    {
                        Console.Write("(");
                    }
                    Console.Write(cifre[i]);
                }
                Console.WriteLine(")");
            }
        }
        private static void P21()
        {
            Console.WriteLine("Bun venit la jocul de ghicit numere!");
            Console.WriteLine("Alegeti un numar între 1 și 1024.");

            int minim = 1;
            int maxim = 1024;
            int raspuns;

            while (true)
            {

                raspuns = (minim + maxim) / 2;

                Console.Write($"Numarul este mai mare sau egal cu {raspuns}? (Da/Nu): ");
                string input = Console.ReadLine().ToLower();

                if (input == "da")
                {
                    minim = raspuns;
                }
                else if (input == "nu")
                {
                    maxim = raspuns - 1;
                }
                else
                {
                    Console.WriteLine("Va rugam sa raspundeti cu (Da/Nu)");
                    continue;
                }

                if (minim == maxim)
                {
                    Console.WriteLine($"Numarul este {minim}!");
                    break;
                }
            }

            Console.WriteLine("Jocul s-a incheiat");
        
    }
    }
}
