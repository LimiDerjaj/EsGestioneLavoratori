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

            Console.WriteLine("INSERMINETO LAVORATORI" + System.Environment.NewLine +
                              "-----------------------" + System.Environment.NewLine);

            //CICLO INSERIMENTO LAVORATORI DIPENDENTI
            for (int i = 0; i < 3; i++)
            {
                lavoratoriDipendenti[i] = new LavoratoreDipendente();

                Console.WriteLine("Inserisci nome lavoratore dipendente" + (i + 1) + ": ");
                string nomeLD = Console.ReadLine();
                lavoratoriDipendenti[i].Nome = nomeLD;

                Console.WriteLine("Inserisci cognome lavoratore dipendente " + (i + 1) + ": ");
                string cognomeLD = Console.ReadLine();
                lavoratoriDipendenti[i].Cognome = cognomeLD;

                Console.WriteLine("Inserisci età lavoratore dipendente " + (i + 1) + ": ");
                int etàLD = Int32.Parse(Console.ReadLine());
                lavoratoriDipendenti[i].Età = etàLD;

                Console.WriteLine("Inserisci RAL lavoratore dipendente " + (i + 1) + ": ");
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

            
            

            Console.WriteLine("Scegli ordinamento lavoratori:" + System.Environment.NewLine
                             + "Per Stipendio = 1 + INVIO" + System.Environment.NewLine
                             + "PerAnzianità = 2 + INVIO" + System.Environment.NewLine
                             + "Premi qualsiasi tasto + INVIO per visualizzarli normalmente");
            string x = Console.ReadLine();




            //CONTROLLO ORDINAMENTI
            if(x=="1")
            { 
            //ORDINAMENTO PER STIPENDIO
            LavoratoreDipendente[] sortedDipendenti = lavoratoriDipendenti.OrderBy
                (lavDipendenti => lavDipendenti.StipendioMensile()).ToArray();

            LavoratoreAutonomo[] sortedAutonomi = lavoratoriAutonomi.OrderBy
                (lavAutonomi => lavAutonomi.StipendioMensile()).ToArray();
            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(System.Environment.NewLine + "Lavoratori dipendenti ordinati per stipendio:"
                    + sortedDipendenti[i].GetDettaglioLavoratore());
            }
            
            for (int i = 0; i < 3; i++)
            {
                 Console.WriteLine(System.Environment.NewLine + "Lavoratori autonomi ordinati per stipendio: "
                     + (i + 1) + ": " + sortedAutonomi[i].GetDettaglioLavoratore());
            }
            }

            if (x == "2")
            {
                //ORDINAMENTO PER ANZIANITA'
                LavoratoreDipendente[] sortedDipendenti = lavoratoriDipendenti.OrderBy
                    (lavDipendenti => lavDipendenti.CalcolaAnzianità()).ToArray();

                //LavoratoreAutonomo[] sortedAutonomi = lavoratoriAutonomi.OrderBy
                    //(lavAutonomi => lavAutonomi.StipendioMensile()).ToArray();

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(System.Environment.NewLine + "Dettagli lavoratore dipendente "
                        + (i + 1) + ": " + sortedDipendenti[i].GetDettaglioLavoratore());
                }

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(System.Environment.NewLine + "Dettagli lavoratore autonomo "
                        + (i + 1) + ": " + lavoratoriAutonomi[i].GetDettaglioLavoratore());
                }
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(System.Environment.NewLine + "Dettagli lavoratore dipendente "
                        + (i + 1) + ": " + lavoratoriDipendenti[i].GetDettaglioLavoratore());
                }

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(System.Environment.NewLine + "Dettagli lavoratore autonomo "
                        + (i + 1) + ": " + lavoratoriAutonomi[i].GetDettaglioLavoratore());
                }
            }


            /*for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(System.Environment.NewLine + "Dettagli lavoratore autonomo "
                    + (i + 1) + ": " + lavoratoriAutonomi[i].GetDettaglioLavoratore());
                Console.WriteLine(System.Environment.NewLine + "Dettagli lavoratore dipendente "
                    + (i + 1) + ": " + lavoratoriDipendenti[i].GetDettaglioLavoratore());               
            }*/

            Console.ReadLine();
        }
    }
}
