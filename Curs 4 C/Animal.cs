using System;
using System.Collections.Generic;
using System.Text;

namespace Curs_4_C_Mentee
{
    public class Animal
    {
        public string tipAnimal { get; set; }
        public string culoare { get; set; }
        public int varsta { get; set; }

        public string informatiiAnimal()
        {
            return "tipAnimal: " + tipAnimal + "\nCuloare: " + culoare + "\nVarsta: " + varsta;
        }

        public Animal()
        {
            tipAnimal = "";
            culoare = "";
            varsta = 0;
        }

        public Animal(string tipAnimal)
        {
            this.tipAnimal = tipAnimal;
            culoare = "";
            varsta = 4;
        }

        public Animal(string tipAnimal, string culoare, int varsta)
        {
            this.tipAnimal = tipAnimal;
            this.culoare = culoare;
            this.varsta = varsta;
        }
    }
}
