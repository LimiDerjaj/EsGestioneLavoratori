using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
    class Program
    {
        static void Main(string[] args)
        {
            //creazione array
            LavoratoreDipendente[] lavoratoriDipendenti = new LavoratoreDipendente[5];
            //LavoratoreDipendente ld1 = new LavoratoreDipendente();
            //lavoratoriDipendenti[0] = new LavoratoreDipendente();
            //lavoratoriDipendenti[1] = new LavoratoreDipendente();
            //lavoratoriDipendenti[2] = new LavoratoreDipendente();
            //lavoratoriDipendenti[3] = new LavoratoreDipendente();
            //lavoratoriDipendenti[4] = new LavoratoreDipendente();

            for(int i=0; i<5;i++)
            {
                //LAVORATORE 1
            lavoratoriDipendenti[i] = new LavoratoreDipendente();

            Console.WriteLine("Inserisci nome lavoratore "+(i+1)+": ");
            string nomeLD = Console.ReadLine();
            lavoratoriDipendenti[i].Nome = nomeLD;

            Console.WriteLine("Inserisci cognome lavoratore" + (i+1) + ": ");
            string cognomeLD = Console.ReadLine();
            lavoratoriDipendenti[i].Cognome = cognomeLD;

            Console.WriteLine("Inserisci età lavoratore: " + (i+1) + "");
            int etàLD = Int32.Parse(Console.ReadLine());
            lavoratoriDipendenti[i].Età = etàLD;

            Console.WriteLine("Inserisci RAL lavoratore: " + (i+1) + "");
            int ralLD = Int32.Parse(Console.ReadLine());
            lavoratoriDipendenti[i].Ral = ralLD;

            Console.WriteLine("Inserisci anno assunzione lavoratore: " + (i + 1) + "");
            int annoAssunzioneLD = Int32.Parse(Console.ReadLine());
            lavoratoriDipendenti[i].AnnoAssunzione = annoAssunzioneLD;
            }
            for (int i=0;i<5;i++)
            { Console.WriteLine("Dettagli lavoratore "+(i+1)+": "+lavoratoriDipendenti[i].GetDettaglioLavoratore());  }
            /*
            //LAVORATORE 2
            Console.WriteLine("Inserisci nome lavoratore: ");
            string nome2 = Console.ReadLine();
            lavoratoriDipendenti[1].Nome = nome2;

            Console.WriteLine("Inserisci cognome lavoratore: ");
            string cognome2 = Console.ReadLine();
            lavoratoriDipendenti[1].Cognome = cognome2;

            Console.WriteLine("Inserisci età lavoratore: ");
            int età2 = Int32.Parse(Console.ReadLine());
            lavoratoriDipendenti[1].Età = età2;

            Console.WriteLine("Inserisci RAL lavoratore: ");
            int ral2 = Int32.Parse(Console.ReadLine());
            lavoratoriDipendenti[1].Ral = ral2;

            //LAVORATORE 3
            Console.WriteLine("Inserisci nome lavoratore: ");
            string nome3 = Console.ReadLine();
            lavoratoriDipendenti[2].Nome = nome3;

            Console.WriteLine("Inserisci cognome lavoratore: ");
            string cognome3 = Console.ReadLine();
            lavoratoriDipendenti[2].Cognome = cognome3;

            Console.WriteLine("Inserisci età lavoratore: ");
            int età3 = Int32.Parse(Console.ReadLine());
            lavoratoriDipendenti[2].Età = età3;

            Console.WriteLine("Inserisci RAL lavoratore: ");
            int ral3 = Int32.Parse(Console.ReadLine());
            lavoratoriDipendenti[2].Ral = ral3;

            //LAVORATORE 4
            Console.WriteLine("Inserisci nome lavoratore: ");
            string nome4 = Console.ReadLine();
            lavoratoriDipendenti[3].Nome = nome4;

            Console.WriteLine("Inserisci cognome lavoratore: ");
            string cognome4 = Console.ReadLine();
            lavoratoriDipendenti[3].Cognome = cognome4;

            Console.WriteLine("Inserisci età lavoratore: ");
            int età4 = Int32.Parse(Console.ReadLine());
            lavoratoriDipendenti[3].Età = età4;

            Console.WriteLine("Inserisci RAL lavoratore: ");
            int ral4 = Int32.Parse(Console.ReadLine());
            lavoratoriDipendenti[3].Ral = ral4;

            //LAVORATORE 4
            Console.WriteLine("Inserisci nome lavoratore: ");
            string nome5 = Console.ReadLine();
            lavoratoriDipendenti[4].Nome = nome5;

            Console.WriteLine("Inserisci cognome lavoratore: ");
            string cognome5 = Console.ReadLine();
            lavoratoriDipendenti[4].Cognome = cognome5;

            Console.WriteLine("Inserisci età lavoratore: ");
            int età5 = Int32.Parse(Console.ReadLine());
            lavoratoriDipendenti[4].Età = età5;

            Console.WriteLine("Inserisci RAL lavoratore: ");
            int ral5 = Int32.Parse(Console.ReadLine());
            lavoratoriDipendenti[4].Ral = ral5;*/

            Console.ReadLine();
        }
    }
}
