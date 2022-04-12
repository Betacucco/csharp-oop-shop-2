using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Shop_2
{
    internal class Elettrodomestico : Prodotto
    {
        // ATTRIBUTI
        private bool provaFunzionamento;

        // COSTRUTTORE DI CIBO IN SCATOLA
        public Elettrodomestico(string nome, string descrizione, double prezzo, int iva) : base(nome, descrizione, prezzo, iva)
        {
            provaFunzionamento = true;
        }

        //Metodo ceh controlla se e' rotto
        public void Rotto()
        {
            this.provaFunzionamento = false;
        }

        //Metodo per lo sconto se compri subito
        public double SeInFunzioneCompro()
        {
            double PrezzoSeComproSubito = PrezzoSenzaIva();

            if (this.provaFunzionamento)
            {
                Console.WriteLine("Funziona, lo compro");
                return PrezzoSeComproSubito;
            }
            else
            {
                Console.WriteLine("Non funziona, non lo compro");
                return 0;
            }
        }

        //Override del metodo togliendo l'iva come sconto
        public override double PrezzoSenzaIva()
        {
            double totale;
            double percentualePrezzoSenzaIva;
            percentualePrezzoSenzaIva = (100 - base.iva);
            totale = base.prezzo * percentualePrezzoSenzaIva / 100;
            Console.WriteLine("Il prezzo senza iva di " + base.nome + " è: " + totale + " euro.");
            return totale;
        }

        //Override della stampa di prodotto
        public override void StampaProdotto()
        {
            Console.WriteLine("--------ELETTRODOMESTICO----------");
            Console.WriteLine("Nome esteso dell'elettrodomestico: " + base.PadLeft() + " - " + base.nome);
            Console.WriteLine("Descrizione elettrodomestico: " + base.descrizione);
            Console.WriteLine("Prezzo: " + base.prezzo);
            Console.WriteLine("IVA: " + base.iva);
            Console.WriteLine("Prezzo se compri: " + SeInFunzioneCompro());
        }
    }
}
