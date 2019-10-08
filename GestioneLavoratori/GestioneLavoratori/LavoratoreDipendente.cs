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


        //base permette di fare il riferimento alla classe padre (LAVORATORE)
        public LavoratoreDipendente(string nome, string cognome, int età,int ral, int annoAssunzione) : base(nome, cognome, età, ral)
        {
            AnnoAssunzione = annoAssunzione;
        }

        public LavoratoreDipendente()
        {
        }
      
         //METODO CALCOLA ANZIANITA DATE NOW-DATA ASSUNZIONE
         public int CalcolaAnzianità()
        {
            return DateTime.Now.Year - AnnoAssunzione;
        }
        //Metodo getDettaglioLavoratore per DIPENDENTI (PRENDE DA LAVORATORE BASE E AGGIUNGE ANZIANITA)
        public override string GetDettaglioLavoratore()
        {
            return base.GetDettaglioLavoratore()
                +"Anni anzianità: "+ CalcolaAnzianità() + Environment.NewLine
                +"Tassa: "+ CalcoloTassa() + "$"+ Environment.NewLine;
        }

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
