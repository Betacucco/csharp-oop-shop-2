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

        public void Bevi(double litriDaBere)
        {
            if (this.litri - litriDaBere > 0)
            {
                this.litri = this.litri - litriDaBere;
                Console.WriteLine("glu glu glu, ho bevuto " + litriDaBere + "l");
            }
            else
            {
                Console.WriteLine("glu glu glu, mi dispiace hai finito la bottiglia");
                this.litri = 0;
            }
        }

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
        
        public void Svuota()
        {
            this.litri = 0;
            Console.WriteLine("Bottiglia svuotata!");
        }

        public override void StampaProdotto()
        {
            Console.WriteLine("--------ACQUA----------");
            Console.WriteLine("Nome esteso della bevanda: " + base.PadLeft() + " - " + base.nome + " - " + this.litri + " litri");
            Console.WriteLine("Sorgente acqua: " + this.sorgente);
            Console.WriteLine("Il PH dell'acqua: " + this.ph);
            Console.WriteLine("Litri contenuti: " + this.litri);
            Console.WriteLine("Litri in galloni: " + ConvertiInGalloni(this.litri));
        }

        public static double ConvertiInGalloni(double litri)
        {
            double contenutoInGalloni = litri * galloni;
            return contenutoInGalloni;
        }
    }
}
