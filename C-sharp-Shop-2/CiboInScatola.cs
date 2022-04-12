using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Shop_2
{
        // SOTTOCLASSE SEMPLICE che estende Prodotto
        internal class CiboInScatola : Prodotto
        {
            // ATTRIBUTI DI CIBO IN SCATOLA
            private double peso;
            

            // COSTRUTTORE DI CIBO IN SCATOLA
            public CiboInScatola(string nome, string descrizione, double peso) : base(nome, descrizione)
            {
                this.peso = peso;
            }

            
        }
}

