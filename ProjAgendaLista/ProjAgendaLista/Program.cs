using System;

namespace ProjAgendaLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 0;

            Agenda agenda = new Agenda();
            //Contato c1;
            //Telefone t1;

            do
            {
                Console.WriteLine("Informe o nome: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Informe o email: ");
                string email = Console.ReadLine();

                Console.WriteLine("Informe o tipo: ");
                string tipo = Console.ReadLine();

                Console.WriteLine("Informe o ddd: ");
                int ddd = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o numero: ");
                int numero = int.Parse(Console.ReadLine());


                agenda.push(new Contato(nome, email, new Telefone(tipo, ddd, numero)));
                //Console.WriteLine(agenda.ToString());
                op = int.Parse(Console.ReadLine());
            } while (op != 123);
            //t1 = new Telefone(tipo, ddd, numero);
            //c1 = new Contato(nome, email, t1);

            agenda.PrintAgenda();
        }         
    }
}
