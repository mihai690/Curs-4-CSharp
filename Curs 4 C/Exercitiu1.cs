using System;
using System.Collections.Generic;
using System.Text;

namespace Curs_4_C_Mentee
{
    class Exercitiu1
    /*Creati un obiect Animal cu caracteristicile: 
     * tipAnimal de tip String (caine, pisica, iepure etc), culoare de tip String, varsta de tip int. 
     * Clasa va contine declararea variabilelor, metode de tip accesor (set si get) si 3 constructori.
     * In Program.cs sau o clasa cu metoda Main creati 3 instante ale clasei Animal in metoda main.
     */
    {

        public static void Main(String[] args)
        {
            Animal a1 = new Animal();
            a1.informatiiAnimal();
            a1.tipAnimal = "catel";
            a1.culoare = "maro";
            a1.varsta = 10;

            Console.WriteLine();
            Console.WriteLine("TipAnimal: " + a1.tipAnimal + "\nCuloare: " + a1.culoare + "\nVarsta: " + a1.varsta);

            Animal a2 = new Animal("pisica");
            a2.culoare = "alba";
            a2.varsta = 4;

            Console.WriteLine();
            Console.WriteLine("TipAnimal: " + a2.tipAnimal + "\nCuloare: " + a2.culoare + "\nVarsta: " + a2.varsta);

            Animal a3 = new Animal("iepure", "alb", 2);
            Console.WriteLine();
            Console.WriteLine("TipAnimal: " + a3.tipAnimal + "\nCuloare: " + a3.culoare + "\nVarsta: " + a3.varsta);

         
        }

    }
}
