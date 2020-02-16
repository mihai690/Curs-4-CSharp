using System;
using System.Collections.Generic;
using System.Text;

namespace Curs_4_C
{
    public class Imobil
    {
        public string tipCasa { get; set; }
        public int nrEtaje { get; set; }
        public double pret { get; set; }

        public string informatiiImobil() { 
            return "tipCasa: " + tipCasa + "\nnrEtaje: " + nrEtaje + "\nPret: " + pret;
        }

        public Imobil() {
            tipCasa = "";
            nrEtaje = 0;
            pret = 0;
        }

        public Imobil(string tipCasa) {
            this.tipCasa = tipCasa;
            nrEtaje = nrEtaje;
            pret = pret;
        }

        public Imobil(string tipCasa, int nrEtaje) {
            this.tipCasa = tipCasa;
            this.nrEtaje = nrEtaje;
            pret = pret;
        }
    }
}
