using System;

namespace EsercitazioneAscii
{
    class Program
    {
        static void Main(string[] args)
        {
            int resto;
            string nconvertito = "";

            Console.WriteLine("inserisci la base in cui vuoi convertire:");
            int BaseConvertita = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inserisci un numero decimale:");
            int decimale = Convert.ToInt32(Console.ReadLine());
            while (decimale > 0)
            {

                resto = decimale % BaseConvertita;
                if (resto == 15)
                {
                    nconvertito += "F";
                }
                else if (resto == 14)
                {
                    nconvertito += "E";
                }
                else if (resto == 13)
                {
                    nconvertito += "D";
                }
                else if (resto == 12)
                {
                    nconvertito += "C";
                }
                else if (resto == 11)
                {
                    nconvertito += "B";
                }
                else if (resto == 10)
                {
                    nconvertito += "A";
                }
                else
                {
                    nconvertito = Convert.ToString(resto) + nconvertito;
                }
                decimale = decimale / BaseConvertita;
            }
            Console.WriteLine($"il numero binario è {nconvertito}");
        }
    }
}
