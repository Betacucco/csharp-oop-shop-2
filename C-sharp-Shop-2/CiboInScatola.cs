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
        public const double pesoMassimoScatoletta = 300;
        private bool apriScatoletta;    

        // COSTRUTTORE DI CIBO IN SCATOLA
        public CiboInScatola(string nome, string descrizione, double peso) : base(nome, descrizione)
        {
            this.peso = peso;
            apriScatoletta = false;
        }

        //Metodo per aprire la scatoletta
        public void AperturaScatoletta()
        {
            apriScatoletta = true;
        }

        //Metodo che mangia dalla scatoletta
        public void Mangia(double contenutoMangiato)
        {
            if (this.peso - contenutoMangiato > 0 && apriScatoletta)
            {
                this.peso = this.peso - contenutoMangiato;
                Console.WriteLine("Ho mangiato " + contenutoMangiato + " grammi dalla scatoletta!");
            }
            else
            {
                Console.WriteLine("Mi dispiace hai finito il contenuto della scatoletta");
                this.peso = 0;
            }
        }

        //Metodo che aggiunge cibo alla scatoletta
        public void AggiungiCibo(int ciboDaAggiungere)
        {
            if ((this.peso + ciboDaAggiungere <= pesoMassimoScatoletta) && apriScatoletta)
            {
                this.peso = this.peso + ciboDaAggiungere;
                Console.WriteLine("Ho aggiunto " + ciboDaAggiungere + " di cibo alla scatoletta!");
            }
            else
            {
                Console.WriteLine("Non posso aggiungere questo quantitativo di cibo. Ma ti restituisco la scatoletta piena!");
                this.peso = pesoMassimoScatoletta;
            }
        }

        //Metodo che svuota scatoletta
        public void SvuotaScatoletta()
        {
            this.peso = 0;
            Console.WriteLine("Scatoletta svuotata!");
        }

        //Override della stampa di prodotto
        public override void StampaProdotto()
        {
            Console.WriteLine("--------SCATOLETTA DI CIBO----------");
            Console.WriteLine("Nome esteso della scatoletta: " + base.PadLeft() + " - " + base.nome);
            Console.WriteLine("Descrizione elettrodomestico: " + base.descrizione);
            Console.WriteLine("Peso della scatoletta: " + this.peso);
        }

    }
}

