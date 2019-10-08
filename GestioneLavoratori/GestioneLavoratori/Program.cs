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
            //creazione array di tipo LavoratoreDipendente
            LavoratoreDipendente[] lavoratoriDipendenti = new LavoratoreDipendente[3];
            LavoratoreAutonomo[] lavoratoriAutonomi = new LavoratoreAutonomo[3];

            Console.WriteLine("INSERMINETO LAVORATORI" + System.Environment.NewLine+
                              "-----------------------" + System.Environment.NewLine);

            //CICLO INSERIMENTO LAVORATORI DIPENDENTI
            for (int i=0; i<3;i++)
            {
            lavoratoriDipendenti[i] = new LavoratoreDipendente();

            Console.WriteLine("Inserisci nome lavoratore dipendente"+(i+1)+": ");
            string nomeLD = Console.ReadLine();
            lavoratoriDipendenti[i].Nome = nomeLD;

            Console.WriteLine("Inserisci cognome lavoratore dipendente " + (i+1) + ": ");
            string cognomeLD = Console.ReadLine();
            lavoratoriDipendenti[i].Cognome = cognomeLD;

            Console.WriteLine("Inserisci età lavoratore dipendente " + (i+1) + ": ");
            int etàLD = Int32.Parse(Console.ReadLine());
            lavoratoriDipendenti[i].Età = etàLD;

            Console.WriteLine("Inserisci RAL lavoratore dipendente " + (i+1) + ": ");
            int ralLD = Int32.Parse(Console.ReadLine());
            lavoratoriDipendenti[i].Ral = ralLD;

            Console.WriteLine("Inserisci anno assunzione lavoratore dipendente " + (i + 1) + ": ");
            int annoAssunzioneLD = Int32.Parse(Console.ReadLine());
            lavoratoriDipendenti[i].AnnoAssunzione = annoAssunzioneLD;
                Console.WriteLine(System.Environment.NewLine);
            }

                //CICLO INSERIMENTO LAVORATORI AUTONOMI
            for (int i = 0; i < 3; i++)
            {
                lavoratoriAutonomi[i] = new LavoratoreAutonomo();

                Console.WriteLine("Inserisci nome lavoratore autonomo" + (i + 1) + ": ");
                string nomeLA = Console.ReadLine();
                lavoratoriAutonomi[i].Nome = nomeLA;

                Console.WriteLine("Inserisci cognome lavoratore autonomo " + (i + 1) + ": ");
                string cognomeLA = Console.ReadLine();
                lavoratoriAutonomi[i].Cognome = cognomeLA;

                Console.WriteLine("Inserisci età lavoratore autonomo " + (i + 1) + ": ");
                int etàLA = Int32.Parse(Console.ReadLine());
                lavoratoriAutonomi[i].Età = etàLA;

                Console.WriteLine("Inserisci RAL lavoratore autonomo " + (i + 1) + ": ");
                int ralLA = Int32.Parse(Console.ReadLine());
                lavoratoriAutonomi[i].Ral = ralLA;
                Console.WriteLine(System.Environment.NewLine);
            }

            /*for (int i=0;i<3;i++)
            { 
                Console.WriteLine(System.Environment.NewLine+"Dettagli lavoratore dipendente " 
                    +(i+1)+": "+lavoratoriDipendenti[i].GetDettaglioLavoratore());
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(System.Environment.NewLine + "Dettagli lavoratore autonomo "
                    + (i + 1) + ": " + lavoratoriAutonomi[i].GetDettaglioLavoratore());
            }*/

            Console.WriteLine("Scegli ordinamento lavoratori:"+ System.Environment.NewLine 
                             +"Per Stipendio = 1"+ System.Environment.NewLine
                             +"PerAnzianità = 2" + System.Environment.NewLine 
                             +"Premi qualsiasi tasto per visualizzarli normalmente");


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(System.Environment.NewLine + "Dettagli lavoratore autonomo "
                    + (i + 1) + ": " + lavoratoriAutonomi[i].GetDettaglioLavoratore());
                Console.WriteLine(System.Environment.NewLine + "Dettagli lavoratore dipendente "
                    + (i + 1) + ": " + lavoratoriDipendenti[i].GetDettaglioLavoratore());
            }

            Console.ReadLine();
        }
    }
}
