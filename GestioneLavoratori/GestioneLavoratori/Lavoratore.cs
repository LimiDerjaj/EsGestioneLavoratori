using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
   /* enum Sesso  //ENUM SOLO VALORI NUMERICI CREA UN TIPO PER UNA VARIABILE CHE PUO CONTENERE SOLO QUESTI VALORI
    {
        N = 0,
        M = 1,
        F = 2,
    }*/
    class Lavoratore
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Età { get; set; }
        public int Ral { get; set; }
        //public Sesso Genere { get; set; }        

        public Lavoratore() //costruttore di default se non ne è presente nessuno, se ne è presente uno bisogna aggiungerlo
        {
        }

        //2 costruttore
        public Lavoratore(string nome, string cognome, int età, int ral)//assegnare ai valori 
                                                                                                //della proprietà i valori che gli passiamo
        {
            Nome = nome;//se i due parametri avevano lo stesso nome si aggiungeva this. al primo parametro(valori classe)
            Cognome = cognome;
            Età = età;
            Ral = ral;
        }

        //3 costruttore
        /*
        public Lavoratore(string nome, string cognome, DateTime datanascita)//costruttore più snello 
        {
            //proprietà che posso calcolarmi le calcolo direttamente nel costruttore
            Nome = nome;
            Cognome = cognome;

            var annoAttuale = DateTime.Now.Year; //calcolare l'età nel costruttore
            var annoAnnoNascita = datanascita.Year;//per avere un costruttore più snello
            Età = annoAttuale - annoAnnoNascita;
        }*/

        public Lavoratore(string nome, string cognome)//COSTRUTTORE UTILIZZATO SULLA CLASSE STUDENTE
        {
            Nome = nome;
            Cognome = cognome;
        }

        public virtual string GetDettaglioLavoratore()//static main vede solo metodi statici della stessa classe                                                          //pero di un altra classe anche istanziabile (istanza l'oggetto)
        {
            string result;
            result =
                  System.Environment.NewLine
                + this.Nome + System.Environment.NewLine //PER ANDARE A CAPO
                + this.Cognome + System.Environment.NewLine
                + this.Età + System.Environment.NewLine
                + this.Ral + System.Environment.NewLine;
            return result;
        }
    }
}
