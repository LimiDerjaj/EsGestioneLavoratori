﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratori
{
    //abstract
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


        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Età { get; set; }
        public int Ral { get; set; }     

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

        public virtual string GetDettaglioLavoratore()//static main vede solo metodi statici della stessa classe                                                          //pero di un altra classe anche istanziabile (istanza l'oggetto)
        {
            string result;
            result =
                  System.Environment.NewLine
                +"Nome: "+ this.Nome + System.Environment.NewLine //PER ANDARE A CAPO
                +"Cognome: "+ this.Cognome + System.Environment.NewLine
                +"Età: "+ this.Età + System.Environment.NewLine
                +"RAL: "+ this.Ral + "$"+System.Environment.NewLine
                + "Stipendio mensile: " + StipendioMensile() + "$"+System.Environment.NewLine;
            return result;
        }


        public virtual int StipendioMensile()
        {
            return this.Ral / 12;
        }

        public virtual int CalcoloTassa() {
            int risultato;
            risultato = 0;
            return risultato;
        }
        
    }
}
