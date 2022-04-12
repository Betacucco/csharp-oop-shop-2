using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Shop_2
{
    internal class SacchettoFrutta : Prodotto
    {
        private int numeroPezziDiFrutta;
        private const int numeroMassimoDiPezzi = 5;
        private string provenienza;

        public SacchettoFrutta(string nomeFrutta, string descrizione, int numeroPezzi, string provenienza) : base(nomeFrutta, descrizione)
        {
            this.numeroPezziDiFrutta = numeroPezzi;
            this.provenienza = provenienza;

        }

        public void Mangia(int fruttaMangiata)
        {
            if (this.numeroPezziDiFrutta - fruttaMangiata > 0)
            {
                this.numeroPezziDiFrutta = this.numeroPezziDiFrutta - fruttaMangiata;
                Console.WriteLine("Ho mangiato " + fruttaMangiata + " di frutta!");
            }
            else
            {
                Console.WriteLine("Mi dispiace hai finito i pezzi di frutta");
                this.numeroPezziDiFrutta = 0;
            }
        }

        public void AggiungiFrutta(int fruttaDaAggiungere)
        {
            if (this.numeroPezziDiFrutta + fruttaDaAggiungere <= numeroMassimoDiPezzi)
            {
                this.numeroPezziDiFrutta = this.numeroPezziDiFrutta + fruttaDaAggiungere;
                Console.WriteLine("Ho aggiunto " + fruttaDaAggiungere + " di frutta al sacchetto!");
            }
            else
            {
                Console.WriteLine("Non posso aggiungere questo quantitativo di frutta. Ma ti restituisco il sacchetto pieno!");
                this.numeroPezziDiFrutta = numeroMassimoDiPezzi;
            }
        }

        public void SvuotaSacchetto()
        {
            this.numeroPezziDiFrutta = 0;
            Console.WriteLine("Sacchetto svuotato!");
        }

        public override void StampaProdotto()
        {
            Console.WriteLine("--------SACCHETTO DI FRUTTA----------");
            Console.WriteLine("Nome esteso del sacchetto: " + base.PadLeft() + " - " + base.nome);
            Console.WriteLine("Numero pezzi: " + this.numeroPezziDiFrutta);
            Console.WriteLine("Provenienza: " + this.provenienza);
        }
    }
}
