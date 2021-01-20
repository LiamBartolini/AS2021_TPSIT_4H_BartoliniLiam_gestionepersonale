using System;

namespace AS2021_TPSIT_4H_BartoliniLiam_listaAttesa.Models
{
    class Cameriere
    {
        int _numeroPersone;
        string _numeroTelefono;
        string _nomeCliente;
        int _nMinuti;

        public int NumeroPersone
        {
            get
            {
                return _numeroPersone;
            }

            set
            {
                _numeroPersone = value;
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
        public int NMinuti
        {
            get
            {
                return _nMinuti;
            }

            private set
            {
                _nMinuti = value;
            }
        }

        public Cameriere()
        {
            Random rn = new Random();
            NMinuti = rn.Next(15, 120);
        }

        public string PrenotazioneTavolo(int nP) => 
            $"Il tavolo per {nP} persone sarà libero tra {NMinuti} minuti";

        public void LiberazioneTavolo()
        {
            char[,] tavoli = new char[10, 10];
            Random rn = new Random();

            for (int i = 0; i < tavoli.GetLength(0); i++)
            {
                for (int j = 0; j < tavoli.GetLength(1); j++)
                {
                    int r = rn.Next(0, 2);
                    if (r == 0)
                        tavoli[i, j] = 'O';
                    else
                        tavoli[i, j] = 'L';
                }
            }

            StampaSchemaTavoli(tavoli);
        }

        private void StampaSchemaTavoli(char[,] tavoli)
        {
            for (int i = 0; i < tavoli.GetLength(0); i++)
            {
                for (int j = 0; j < tavoli.GetLength(1); j++)
                {
                    Console.Write($"{tavoli[i, j]}    ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}