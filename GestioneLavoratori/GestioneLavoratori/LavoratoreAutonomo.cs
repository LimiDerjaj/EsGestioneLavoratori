using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
    class LavoratoreAutonomo : Lavoratore
    {
    
        /// <summary>
        /// metodo costruttore lavoratore autonomo
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="cognome"></param>
        /// <param name="età"></param>
        /// <param name="ral"></param>
    public LavoratoreAutonomo(string nome, string cognome, int età, int ral) : base(nome, cognome, età, ral)
    {
    }

    public LavoratoreAutonomo()
        {
        }

        /// <summary>
        /// informazioni lavoratore autonomo
        /// </summary>
        /// <returns>string informazioni</returns>
        public override string GetDettaglioLavoratore()
        {
            return base.GetDettaglioLavoratore()+ "Tassa: " + CalcoloTassa()+"$" + Environment.NewLine;
        }

        /// <summary>
        /// calcolo tassa lavoratore autonomo
        /// </summary>
        /// <returns>int tassa</returns>
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