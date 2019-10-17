using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
    class LavoratoreDipendente : Lavoratore //CLASSE STUDENTE EREDITA DA CLASSE PERSONA PARAMETRI E METODI
    {
        //EREDITA I PARAMETRI DI PERSONA E SI POSSONO AGGIUNGERE ALTRI PARAMETRI DICHIARANDOLI (VALGONO SOLO SU STUDENTI)
        public int AnnoAssunzione { get; set; }


        /// <summary>
        /// metodo costruttore lavoratore dipendente
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="cognome"></param>
        /// <param name="età"></param>
        /// <param name="ral"></param>
        /// <param name="annoAssunzione"></param>
        public LavoratoreDipendente(string nome, string cognome, int età,int ral, int annoAssunzione) : base(nome, cognome, età, ral)
        {
            AnnoAssunzione = annoAssunzione;
        }

        public LavoratoreDipendente()
        {
        }
      
         /// <summary>
         /// Calcola anzianità lavorativa
         /// </summary>
         /// <returns>Int anzianità</returns>
         public int CalcolaAnzianità()
        {
            return DateTime.Now.Year - AnnoAssunzione;
        }


        /// <summary>
        /// Informazioni lavoratore dipendente
        /// </summary>
        /// <returns>string con informazioni del lavoratore</returns>
        public override string GetDettaglioLavoratore()
        {
            return base.GetDettaglioLavoratore()
                +"Anni anzianità: "+ CalcolaAnzianità() + Environment.NewLine
                +"Tassa: "+ CalcoloTassa() + "$"+ Environment.NewLine;
        }

        /// <summary>
        /// Calcolo tassa lavoratore dipendente
        /// </summary>
        /// <returns>Int tassa</returns>
        public override int CalcoloTassa()
        {
            int risultato;
            if (Ral <= 6000)
            {
                risultato = 0;
            }
            else
            if(Ral<=15000)
            {
                risultato = (Ral * 15) / 100;
            }
            else
            if(Ral<=25000)
            {
                risultato = (Ral * 30) / 100;
            }
            else
            if (Ral <= 35000)
            {
                risultato = (Ral * 40) / 100;
            }
            else
            risultato = (Ral * 50) / 100;
            return risultato;
        }
    }
}
