using System.IO;

namespace gravaRegistros
{
    public class gravaRegistro
    {

        public int num;
        public int de;
        public int vai;
        public string inicio;
        public string fim;

        public void gravaRestInicio()
        {
            using (
                StreamWriter writer =
                    new StreamWriter(
                        Directory.GetCurrentDirectory() + @"\" +
                        inicio.Replace("-", "").Replace(" ", "").Replace(":", "") + ".rest", true))
            {
                writer.WriteLine("<inicio> cabeçalho da mensagem </incio>");
            }
        }

        public void gravaRest(/*int num, int de, int vai , string inicio*/)
        {
            using (StreamWriter writer =
                new StreamWriter(
                    Directory.GetCurrentDirectory() + @"\" +
                        inicio.Replace("-", "").Replace(" ", "").Replace(":", "") + ".rest", true))
            {
                writer.WriteLine("  <movimentos> Mover disco {0} da torre {1} para torre {2}; </movimentos>", num, de, vai);
            }
        }

        public void gravaRestFim()
        {

            using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + @"\" +
                        inicio.Replace("-", "").Replace(" ", "").Replace(":", "") + ".rest", true))
            {
                writer.WriteLine("<fim> quantidade de discos {0}, inicio: {1}, Fim: {2}; </fim>", num, inicio, fim);
            }
        }

        public void gravaLog()
        {
            using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + @"\log.txt", true))
            {
                writer.WriteLine("Mover disco {0} da torre {1} para torre {2}", num, de, vai);
            }
        }
        public void gravaLogFim()
        {

            using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + @"\log.txt", true))
            {
                writer.WriteLine("Quantidade de discos {0}, inicio: {1}, Fim: {2}; </fim>", num, inicio, fim);
                writer.WriteLine("--------------------------------------------------------");
                writer.WriteLine("");
            }
        }
    }
}
