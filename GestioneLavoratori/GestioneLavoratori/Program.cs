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
            bool controllo = false;//variabile bool controllo inserimento informazioni lavoratore
            bool exists = true; //variabile bool di controllo inserimento lavoratore
            //creazione array di tipo LavoratoreDipendente
            LavoratoreDipendente[] lavoratoriDipendenti = new LavoratoreDipendente[3];
            LavoratoreAutonomo[] lavoratoriAutonomi = new LavoratoreAutonomo[3];

            Console.WriteLine("INSERMINETO LAVORATORI" + System.Environment.NewLine +
                              "-----------R1Q17------------" + System.Environment.NewLine);

            //CICLO INSERIMENTO LAVORATORI DIPENDENTI
            for (int i = 0; i < 3; i++)
            {
                exists = false;
                do
                {
                    //con la nuova logica non servirà inizializzare ogni volta l'oggetto all'interno dell'array

                    //mi creo un oggetto LavoratoreDipendente (attenzione, non un array) in cui salvare l'input dell'utente
                    LavoratoreDipendente lvD = new LavoratoreDipendente();

                    //assegno i singoli valori alle proprietà del mio oggetto lv (sostituisco lavoratoriDipendenti[i] con lv)
                    Console.WriteLine("Inserisci nome lavoratore dipendente" + (i + 1) + ": ");
                    string nomeLD = Console.ReadLine();
                    lvD.Nome = nomeLD;

                    Console.WriteLine("Inserisci cognome lavoratore dipendente " + (i + 1) + ": ");
                    string cognomeLD = Console.ReadLine();
                    lvD.Cognome = cognomeLD;

                    controllo = false;
                    do
                    {
                        try
                        {
                            Console.WriteLine("Inserisci età lavoratore dipendente " + (i + 1) + ": ");
                            int etàLD = Int32.Parse(Console.ReadLine());
                            lvD.Età = etàLD;
                            controllo = true;
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine("Riprova: ");
                            controllo = false;
                        }
                    } while (controllo == false);

                    controllo = false;
                    do
                    {
                        try
                        {
                            Console.WriteLine("Inserisci RAL lavoratore dipendente " + (i + 1) + ": ");
                            int ralLD = Int32.Parse(Console.ReadLine());
                            lvD.Ral = ralLD;
                            controllo = true;
                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine("Riprova: ");
                            Console.WriteLine(ex.Message);
                        }
                    } while (controllo == false);

                    controllo = false;
                    do
                    {
                        try
                        {
                            Console.WriteLine("Inserisci anno assunzione lavoratore dipendente " + (i + 1) + ": ");
                            int annoAssunzioneLD = Int32.Parse(Console.ReadLine());
                            lvD.AnnoAssunzione = annoAssunzioneLD;
                            controllo = true;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Riprova: ");
                            Console.WriteLine(ex.Message);
                        }
                    } while (controllo == false);
                    Console.WriteLine(System.Environment.NewLine);


                    foreach (var lavoratore in lavoratoriDipendenti)
                    {
                        exists = true;
                        if (lvD.Equals(lavoratore)) // in questa riga verifico se il mio oggetto "lvD" inserito dall'utente sia uguale all'oggetto "lavoratore"
                        {
                            Console.WriteLine("lavoratore già inserito, RIPETI INSERIMENTO" + System.Environment.NewLine);              
                            break; //interrompo il ciclo, ho già trovato che l'elemento esiste già, non serve che "perdo tempo" facendogli finire il ciclo
                        }
                        else
                        {
                            exists = false;                          
                        }
                    }

                    if(exists==false)
                    {
                            lavoratoriDipendenti[i] = lvD;
                            //associo il mio lv alla posizione i-esima dell'array. NB: è un problema che sia reference type?
                            Console.WriteLine("lavoratore inserito correttamente" + System.Environment.NewLine);
                    }

                } while (exists == true);
            }
          
            //CICLO INSERIMENTO LAVORATORI AUTONOMI
            for (int i = 0; i < 3; i++)
            {
                LavoratoreAutonomo lvA = new LavoratoreAutonomo();

                Console.WriteLine("Inserisci nome lavoratore autonomo" + (i + 1) + ": ");
                string nomeLA = Console.ReadLine();
                lvA.Nome = nomeLA;

                Console.WriteLine("Inserisci cognome lavoratore autonomo " + (i + 1) + ": ");
                string cognomeLA = Console.ReadLine();
                lvA.Cognome = cognomeLA;

                controllo = false;
                do
                {
                    try
                    {
                        Console.WriteLine("Inserisci età lavoratore autonomo " + (i + 1) + ": ");
                        int etàLA = Int32.Parse(Console.ReadLine());
                        lvA.Età = etàLA;
                        controllo = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Riprova: ");
                        Console.WriteLine(ex.Message);
                    }
                } while (controllo == false);


                controllo = false;
                do { 
                    try
                    {
                        Console.WriteLine("Inserisci RAL lavoratore autonomo " + (i + 1) + ": ");
                        int ralLA = Int32.Parse(Console.ReadLine());
                        lvA.Ral = ralLA;
                        Console.WriteLine(System.Environment.NewLine);
                        controllo = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Riprova: ");
                        Console.WriteLine(ex.Message);
                    }
                } while (controllo == false);


               
                foreach (var lavoratore in lavoratoriAutonomi)
                {
                    if (lvA.Equals(lavoratore)) // in questa riga verifico se il mio oggetto "lvD" inserito dall'utente sia uguale all'oggetto "lavoratore"
                    {
                        exists = true; //imposto la mia variabile di controllo a true
                        break; //interrompo il ciclo, ho già trovato che l'elemento esiste già, non serve che "perdo tempo" facendogli finire il ciclo
                    }
                }

                if (exists)
                {
                    Console.WriteLine("lavoratore già inserito" + System.Environment.NewLine);
                    /* Aggiungere logica che magari chiede di inserire un altro lavoratore dato che quello inserito esiste già.
                     * Suggerimento: per farlo in maniera elegante e funzionale, si potrebbe creare un metodo privato "CreateLavoratoreDip" che potrebbe occuparsi di chiedere all'utente tutte le info
                     * Bisognerebbe modificare un po' la struttura del main in modo che chieda i dettagli di un nuovo lavoratore finché non ne sono stati aggiunti 3 o il numero che preferisci (suggerimento: si può usare un ciclo do-while)
                    */
                }
                else
                {
                    Console.WriteLine("lavoratore inserito correttamente" + System.Environment.NewLine);
                    lavoratoriAutonomi[i] = lvA; //associo il mio lv alla posizione i-esima dell'array. NB: è un problema che sia reference type?
                }

            }

            Console.WriteLine("Scegli ordinamento lavoratori:" + System.Environment.NewLine + System.Environment.NewLine
                             + "Per Stipendio = 1 + INVIO" + System.Environment.NewLine
                             + "PerAnzianità = 2 + INVIO" + System.Environment.NewLine
                             + "Premi qualsiasi tasto + INVIO per visualizzarli normalmente");
            string x = Console.ReadLine();

            //CONTROLLO ORDINAMENTI
        if(x=="1")
            {
                Console.WriteLine(System.Environment.NewLine + "ORDINAMENTO LAVORATORI PER STIPENDIO" + System.Environment.NewLine +
                              "-----------------------" + System.Environment.NewLine);
                                
                //ORDINAMENTO PER STIPENDIO
                LavoratoreDipendente[] dipendentiOrdinati = lavoratoriDipendenti.OrderBy
                (lavDipendenti => lavDipendenti.StipendioMensile()).ToArray();

            LavoratoreAutonomo[] autonomiOrdinati = lavoratoriAutonomi.OrderBy
                (lavAutonomi => lavAutonomi.StipendioMensile()).ToArray();
            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(System.Environment.NewLine + "Lavoratori dipendenti ordinati per stipendio:"
                    + dipendentiOrdinati[i].GetDettaglioLavoratore());
            }
            
            for (int i = 0; i < 3; i++)
            {
                 Console.WriteLine(System.Environment.NewLine + "Lavoratori autonomi ordinati per stipendio: "
                     + (i + 1) + ": " + autonomiOrdinati[i].GetDettaglioLavoratore());
            }
        }

        if (x == "2")
        {
                Console.WriteLine(System.Environment.NewLine + "ORDINAMENTO LAVORATORI PER ANZIANITA'" + System.Environment.NewLine +
                              "-----------------------" + System.Environment.NewLine);

                //ORDINAMENTO PER ANZIANITA'
                LavoratoreDipendente[] dipendentiOrdinati = lavoratoriDipendenti.OrderBy
                    (lavDipendenti => lavDipendenti.CalcolaAnzianità()).ToArray();

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(System.Environment.NewLine + "Dettagli lavoratore dipendente "
                        + (i + 1) + ": " + dipendentiOrdinati[i].GetDettaglioLavoratore());
                }

                for (int i = 0; i < 3; i++) //lavoratori autonomi non viene ordinato perchè non ha l'anzianità
                {
                    Console.WriteLine(System.Environment.NewLine + "Dettagli lavoratore autonomo "
                        + (i + 1) + ": " + lavoratoriAutonomi[i].GetDettaglioLavoratore());
                }
         }

         else
         {
                Console.WriteLine(System.Environment.NewLine + "ORDINAMENTO LAVORATORI PER INSERIMENTO" + System.Environment.NewLine +
                              "-----------------------" + System.Environment.NewLine);
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
            Console.ReadLine();
        }
    }
}
