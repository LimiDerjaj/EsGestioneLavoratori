using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
    class LavoratoreDipendente : Lavoratore //CLASSE STUDENTE EREDITA DA CLASSE PERSONA PARAMETRI E METODI
    {
       // public string Nome { get; set; }
      //  public string Cognome { get; set; }
      //  public int Età { get; set; }
        //public Sesso Genere { get; set; }
       // public double Ral { get; set; }
        //EREDITA I PARAMETRI DI PERSONA E SI POSSONO AGGIUNGERE ALTRI PARAMETRI DICHIARANDOLI (VALGONO SOLO SU STUDENTI)

        public int AnnoAssunzione { get; set; }


        //base permette di fare il riferimento alla classe padre (LAVORATORE)
        public LavoratoreDipendente(string nome, string cognome, int età,int ral) : base(nome, cognome, età, ral)
        {
            AnnoAssunzione = 2012;
        }

        public LavoratoreDipendente()
        {
        }

        public LavoratoreDipendente(string nome, string cognome, int annoAssunzione)//costruttore più snello 
        {
            //proprietà che posso calcolarmi le calcolo direttamente nel costruttore
            {
                //proprietà che posso calcolarmi le calcolo direttamente nel costruttore
                AnnoAssunzione = AnnoAssunzione;

                //var annoAttuale = DateTime.Now.Year; //calcolare l'età nel costruttore
                //var annoAssunzione = annoAssunzione.Year;//per avere un costruttore più snello
                int anzianitò = DateTime.Now.Year - annoAssunzione;
            }

        
    }
        public int CalcolaAnzianità()
        {
            return DateTime.Now.Year - AnnoAssunzione;
        }

        //METODO CALCOLA ANZIANITA DATE NOW-DATA ASSUNZIONE
    }
}
