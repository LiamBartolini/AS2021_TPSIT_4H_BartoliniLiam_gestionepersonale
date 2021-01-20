using System;
using AS2021_TPSIT_4H_BartoliniLiam_listaAttesa.Models;

namespace AS2021_TPSIT_4H_BartoliniLiam_listaAttesa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista attesa, Bartolini Liam");

            Cameriere cameriere = new Cameriere();

            Console.WriteLine(cameriere.PrenotazioneTavolo(4));
            
            Sms messaggio = new Sms();

            Console.WriteLine("Tavoli Liberi (L):");
            cameriere.LiberazioneTavolo();

            Console.WriteLine(messaggio.ConfermaPrenotazione("Paolo"));

            messaggio.ContattareCliente();

            Console.ReadLine();
        }
    }
}