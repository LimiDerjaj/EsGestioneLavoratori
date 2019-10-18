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

        /// <summary>
        /// informazioni lavoratore
        /// </summary>
        /// <returns></returns>
        public virtual string GetDettaglioLavoratore()                                                          //pero di un altra classe anche istanziabile (istanza l'oggetto)
        {
            string result;
            result = string.Format(
                  System.Environment.NewLine
                + "Nome: {0:N}" + Environment.NewLine + "Cognome: {0:C}" + Environment.NewLine
                + "Età: {0:E}" + Environment.NewLine
                + "RAL: {0:R} $" + Environment.NewLine, this);               
            return result;
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            var result = string.Empty;
            if (string.IsNullOrEmpty(format))
            {
                result = Nome + " " + Cognome + " " + Età + " "+ Ral;//d piccolo formato data corta
            }
            else if (format == "N")
            {
                result = Nome;
            }
            else if (format == "C")
            {
                result = Cognome;
            }
            else if (format == "E")
            {
                result = Età.ToString();
            }
            else if (format == "R")
            {
                result = Ral.ToString();
            }
            else
            {
                throw new FormatException("Il formato richiesto non è previsto");
            }

            return result;
        }

    }
}
