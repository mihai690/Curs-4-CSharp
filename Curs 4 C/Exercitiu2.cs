using System;
using System.Collections.Generic;
using System.Text;

namespace Curs_4_C
{
    class Exercitiu2
    /*Creati un obiect / clasa Imobil ce contine variabilele: 
     * tipCasa de tip String (apartament, casa, vila etc), nrEtaje de tip int, pret de tip double. 
     * Declarati variabilele, metodele accesor set si get 
     * si constructori care sa va ajute la crearea instantelor acestui obiect. 
     * Apelati clasa Imobil in Program.cs sau o clasa cu metoda Main, 
     * utilizand constructorii si metodele set si get din clasa Imobil.
 */
    {
        public static void Main(String[] args)
        {
            Imobil i1 = new Imobil();
            i1.tipCasa = "apartament";
            i1.nrEtaje = 0;
            i1.pret = 65000;

            Console.WriteLine("Imobilul 1 este de tip: " + i1.tipCasa + " si costa " + i1.pret + " euro.");

            Imobil i2 = new Imobil("casa");
            i2.nrEtaje = 1;
            i2.pret = 120000;

            Console.WriteLine("Pretul imobilului 2 este de: " + i2.pret + " euro.");

            Imobil i3 = new Imobil("vila", 2);
            i3.pret = 200000;

            if (i2.pret > i3.pret)
            {
                Console.WriteLine("Imobilul 2 este mai scump, cu o valoare de " + i2.pret + " euro.");
            }
            else
            {
                Console.WriteLine("Imobilul 3 este mai scump, avand o valoare de " + i3.pret + " euro.");
            }

            Console.WriteLine();
            Console.WriteLine(i1.informatiiImobil());

            Console.WriteLine();
            Console.WriteLine(i2.informatiiImobil());

            Console.WriteLine();
            Console.WriteLine(i3.informatiiImobil());
        }
        }
    }

