using System;
using System.IO;
using System.Threading;
using gravaRegistros;

namespace TorresDeHanoi
{
    public class TorreDeHanoi
    {
        public string incio;
        public string fim;
        public int hanoiId;
        
        int numdisco;

        public TorreDeHanoi()
        {
            numdiscos = 0;
        }

        public TorreDeHanoi(int novoValor)
        {
            numdiscos = novoValor;
        }

        public int numdiscos
        {
            get { return numdisco; }
            set
            {
                if (value > 0)
                    numdisco = value;
            }
        }

        public void inicia()
        {
            gravaRegistro gravaInicio = new gravaRegistro();
            gravaInicio.inicio = incio;
            gravaInicio.fim = fim;

            gravaInicio.gravaRestInicio();
        }

        public void finaliza()
        {
            gravaRegistro gravaFim = new gravaRegistro();
            gravaFim.inicio = incio;
            gravaFim.fim = fim;
            gravaFim.gravaRestFim();
            gravaFim.gravaLogFim();
        }

        public void moveTorre(int num, int de, int vai, int outra)
        {
            if (num > 0)
            {
                moveTorre(num - 1, de, outra, vai);

                gravaRegistro grava = new gravaRegistro();
                grava.inicio = incio;
                grava.num = num;
                grava.de = de;
                grava.vai = vai;
                grava.gravaRest();
                grava.gravaLog();

                Console.WriteLine("Mover disco {0} da torre {1} para torre {2}", num, de, vai);

                //using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + @"\log.txt", true))
                //{
                //    writer.WriteLine("Mover disco {0} da torre {1} para torre {2}", num, de, vai);
                //}

                moveTorre(num - 1, outra, vai, de);
            }
        }

        public void moveTorre(int num, int de, int vai, int outra, Action<int, int, int, int> callback)
        {
            if (num == 1)
            {
                callback(hanoiId, num - 1, de - 1, vai - 1);
                Thread.Sleep(1000);
            }else {
                moveTorre(num - 1, de, outra, vai, callback);

                gravaRegistro grava = new gravaRegistro();
                grava.inicio = incio;
                grava.num = num;
                grava.de = de;
                grava.vai = vai;
                grava.gravaRest();
                grava.gravaLog();

                //Console.WriteLine("Mover disco {0} da torre {1} para torre {2}", num, de, vai);

                //using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + @"\log.txt", true))
                //{
                //    writer.WriteLine("Mover disco {0} da torre {1} para torre {2}", num, de, vai);
                //}
                
                moveTorre(num - 1, outra, vai, de, callback);
            }
        }
    }
}
