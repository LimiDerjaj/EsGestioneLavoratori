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
