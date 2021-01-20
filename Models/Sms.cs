using System;
using System.Threading.Tasks;

namespace AS2021_TPSIT_4H_BartoliniLiam_listaAttesa.Models
{
    class Sms : Cameriere
    {
        int _numMinuti;
        string _nomeCliente;
        string _numeroTelefono;
        
        public int NumMinuti
        {
            get
            {
                return _numMinuti;
            }

            set
            {
                _numMinuti = value;
            }
        }
        public string NomeCliente
        {
            get
            {
                return _nomeCliente;
            }

            set
            {
                _nomeCliente = value;
            }
        }
        public string NumeroTelefono
        {
            get
            {
                return _numeroTelefono;
            }

            set
            {
                _numeroTelefono = value;
            }
        }
        
        public Sms()
        {
            //prendo il numero di minuti generato attraverso l'eridarietà
            NumMinuti = NMinuti;
        }

        async public void ContattareCliente()
        {
            Random rn = new Random();
            
            for (int i = 0; i < 5; i++)
                await Messaggio($"Mancano {NumMinuti -= rn.Next(0, (NumMinuti / 2))} minuti alla liberazione del tavolo!");

            await Messaggio($"Il tavolo è libero hai {rn.Next(0, NumMinuti)} minuti per arrivare!");
        }

        async Task Messaggio(string messaggio)
        {
            await Task.Delay(5000);
            Console.WriteLine(messaggio);
        }

        public string ConfermaPrenotazione(string nome) =>
            $"Messaggio di conferma per la prenotazione a nome di '{nome}'";
    }
}