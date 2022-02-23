using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAgendaLista
{
    internal class Agenda
    {
        //public Contato Anterior { get; set; }
        //public Contato Registro { get; set; }  
        //public Contato Proximo { get; set; }
        public Contato Cabeca { get; set; }
        public Contato Cauda { get; set; }

        public Agenda()
        {
            //Anterior = null;
           //Registro = null;
           //Proximo = null;
            Cabeca = null;
            Cauda = null;

        }

        public void push(Contato novoContato)
        {
            if (Vazio())
            {
                Cabeca = novoContato;
                //Registro = novoContato;
                Cauda = novoContato;
            }
            else
            {
                Cauda.Proximo = novoContato;
                Cauda = novoContato;
                OrdenarAgenda();
            }             
        }

        public void PrintAgenda()
        {
            Contato aux = Cabeca;
            do
            {
                Console.WriteLine(aux.ToString());
                aux = aux.Proximo;
            } while (aux != null);
        }

        public bool Vazio()
        {
            if(Cabeca == null && Cauda == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void OrdenarAgenda()
        {
            /*
             Contato referencia = Cabeca;
             Contato comparacao = Cabeca.Proximo;
             do
             {
                 do
                 {
                     if (String.Compare(referencia.Nome, comparacao.Nome) >= 0)
                     {
                         comparacao = comparacao.Proximo;
                         referencia = referencia.Proximo;

                         Contato suporte = referencia;
                         referencia = comparacao;
                         comparacao = suporte.Anterior;

                     }
                     comparacao = comparacao.Proximo;
                 }while (comparacao != null);
                 referencia = referencia.Proximo;    
             } while (referencia != null);
            */

            for (Contato referencia = Cabeca; referencia != null; referencia = referencia.Proximo)
            {
                for (Contato comparacao = referencia.Proximo; comparacao != null; comparacao = comparacao.Proximo)
                {
                    if (referencia.Nome.CompareTo(comparacao.Nome) > 0)
                    {
                        Contato suporte = new Contato(referencia.Nome, referencia.Email, referencia.Telefones);
                        suporte.Nome = referencia.Nome;
                        suporte.Email = referencia.Email;
                        suporte.Telefones = referencia.Telefones;
                        referencia.Nome = comparacao.Nome;
                        referencia.Email = comparacao.Email;
                        referencia.Telefones = comparacao.Telefones;
                        comparacao.Nome = suporte.Nome;
                        comparacao.Email = suporte.Email;
                        comparacao.Telefones = suporte.Telefones;
                    }
                }
            }

        }




        /*
        public override string ToString()
        {
            return Cauda.ToString();
        }
        */



    }
}
