using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
    class LavoratoreAutonomo : Lavoratore
    {
    
    public LavoratoreAutonomo(string nome, string cognome, int età, int ral) : base(nome, cognome, età, ral)
    {
    }

    public LavoratoreAutonomo()
        {
        }


        public override string GetDettaglioLavoratore()
        {
            return base.GetDettaglioLavoratore()+ "Tassa: " + CalcoloTassa()+"$" + Environment.NewLine;
        }

        public override int CalcoloTassa()
        {
            int risultato;
            if(Ral<50000)
            {
                risultato = 0;
            }
            else
            {
                risultato = (Ral * 30) / 100;
            }
            return risultato;
        }
    }
}


/* Aggiungere logica che magari chiede di inserire un altro lavoratore dato che quello inserito esiste già.
 * Suggerimento: per farlo in maniera elegante e funzionale, si potrebbe creare un metodo privato "CreateLavoratoreDip" che potrebbe occuparsi di chiedere all'utente tutte le info
 * Bisognerebbe modificare un po' la struttura del main in modo che chieda i dettagli di un nuovo lavoratore finché non ne sono stati aggiunti 3 o il numero che preferisci (suggerimento: si può usare un ciclo do-while)
*/
