using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Shop_2
{
  
    internal class Acqua : Prodotto
    {
        //Attributi
        public double litri { get; set; }
        private int ph;
        private string sorgente; 
        public const double massimaCapienzaBottiglia = 1.5;
        public static double galloni = 3.785;

        //Overloading del Costruttore di Prodotto 
        public Acqua(string nomeAcqua, string descrizione, double litri, int ph, string sorgente) : base(nomeAcqua, descrizione)
        {
            this.sorgente = sorgente;
            this.litri = litri;
            this.ph = ph;

        }

        public void MaxCapienza()
        {
            if(this.litri > massimaCapienzaBottiglia)
            {
                throw new ArgumentOutOfRangeException("litri", "Il suo valore e' maggiore della massima capienza!");
            }
        }

        //Metodo che beve acqua
        public void Bevi(double litriDaBere)
        {
            if (litriDaBere < 0)
            {
                throw new ArgumentOutOfRangeException("litriDaBere", "Il suo valore e' negativo!");
            }

            if (this.litri - litriDaBere > 0)
            {
                this.litri = this.litri - litriDaBere;
                Console.WriteLine("glu glu glu, ho bevuto " + litriDaBere + "l");
            }
            else
            { 
                this.litri = 0;
                throw new ArgumentOutOfRangeException("litri", "l'acqua bevuta e' maggiore di quella presente nella bottiglia.");
            }
        }

        //Metodo che riempie la bottiglia di acqua
        public void Riempi(double litriDaAggiungere)
        {
            if(this.litri + litriDaAggiungere <= massimaCapienzaBottiglia)
            {
                this.litri = this.litri + litriDaAggiungere;
                Console.WriteLine("Ho aggiunto acqua alla mia bottiglia!" + litriDaAggiungere);
            } else
            {
                Console.WriteLine("Non posso aggiungere questo quantitativo di acqua. Ma ti restituisco la bottiglia piena!");
                this.litri = massimaCapienzaBottiglia;
            }
        }
        
        //Metodo che svuota la bottiglia di acqua
        public void Svuota()
        {
            this.litri = 0;
            Console.WriteLine("Bottiglia svuotata!");
        }

        //Override del metodo di stampa dalla superclasse Prodotto
        public override void StampaProdotto()
        {
            Console.WriteLine("--------ACQUA----------");
            Console.WriteLine("Nome esteso della bevanda: " + base.PadLeft() + " - " + base.nome + " - " + this.litri + " litri");
            Console.WriteLine("Sorgente acqua: " + this.sorgente);
            Console.WriteLine("Il PH dell'acqua: " + this.ph);
            Console.WriteLine("Litri contenuti: " + this.litri);
            Console.WriteLine("Litri in galloni: " + ConvertiInGalloni(this.litri));
        }

        //Metodo statico per convertire i litri in galloni
        public static double ConvertiInGalloni(double litri)
        {
            double contenutoInGalloni = litri * galloni;
            return contenutoInGalloni;
        }
    }
}
