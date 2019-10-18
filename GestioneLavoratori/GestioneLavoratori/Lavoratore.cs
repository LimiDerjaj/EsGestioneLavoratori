using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
    /// <summary>
    /// classe padre Lavoratore
    /// </summary>
     class Lavoratore
    {
        private Lavoratore[] lavoratore = new Lavoratore[3];
        public int Length
        {
            get
            {
                return lavoratore.Length;
            }
        }

        /// <summary>
        /// nome lavoratore inserito
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// cognome lavoratore inserito
        /// </summary>
        public string Cognome { get; set; }
        /// <summary>
        /// età lavoratore inserito
        /// </summary>
        public int Età { get; set; }
        /// <summary>
        /// Ral lavoratore inserito
        /// </summary>
        public int Ral { get; set; }     

        public Lavoratore() //costruttore di default se non ne è presente nessuno, se ne è presente uno bisogna aggiungerlo
        {
        }

        /// <summary>
        /// metodo costruttore lavoratore padre
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="cognome"></param>
        /// <param name="età"></param>
        /// <param name="ral"></param>
        public Lavoratore(string nome, string cognome, int età, int ral)//assegnare ai valori 
                                                                                                //della proprietà i valori che gli passiamo
        {
            Nome = nome;//se i due parametri avevano lo stesso nome si aggiungeva this. al primo parametro(valori classe)
            Cognome = cognome;
            Età = età;
            Ral = ral;
        }

        /// <summary>
        /// Lavoratori uguali se hanno stesso nome, cognome ed età
        /// </summary>
        /// <param name="obj"></param>
        /// <returns> bool type</returns>
        public override bool Equals(object obj)
        {
            bool result = false;
            Lavoratore temp = obj as Lavoratore;

            if (temp != null)
            {
                result = temp.Nome == this.Nome && temp.Cognome == this.Cognome && temp.Età == this.Età;
            }
            return result;
        }

        /// <summary>
        /// informazioni lavoratore
        /// </summary>
        /// <returns></returns>
        public virtual string GetDettaglioLavoratore()                                                          //pero di un altra classe anche istanziabile (istanza l'oggetto)
        {
            string result;
            result =
                  System.Environment.NewLine
                +"Nome: "+ this.Nome + System.Environment.NewLine //PER ANDARE A CAPO
                +"Cognome: "+ this.Cognome + System.Environment.NewLine
                +"Età: "+ this.Età + System.Environment.NewLine
                +"RAL: "+ this.Ral + "$"+System.Environment.NewLine
                + "Stipendio mensile netto: " + StipendioMensile() + "$"+System.Environment.NewLine;
            return result;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Calcolo stipendio mensile lavoratore
        /// </summary>
        /// <returns></returns>
        public virtual int StipendioMensile()
        {
            return this.Ral;
        }

        /// <summary>
        /// calcolo tassa metodo base(non utilizzato, viene fatto l'override)
        /// </summary>
        /// <returns></returns>
        public virtual int CalcoloTassa() {
            int risultato;
            risultato = 0;
            return risultato;
        }
        
    }
}
