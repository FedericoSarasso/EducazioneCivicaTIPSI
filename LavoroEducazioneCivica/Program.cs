using System;

namespace LavoroEducazioneCivica
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringa = "";
            int numero = 0;

            //stringa = "ciao";
            //numero = 10;

            Console.Write(funzioneUno(stringa.ToUpper(), numero));


            Console.ReadLine();
        }

        static string funzioneUno(string stringa, int numero)
        {
            string stringaCriptata = "";

            foreach (char c in stringa)
            {
                if (char.IsLetter(c))
                {
                    char carattereCriptato = (char)(((int)c + numero - 65) % 26 + 65);
                    stringaCriptata += carattereCriptato;
                }
                else
                {
                    stringaCriptata += c;
                }
            }
            return stringaCriptata;
        }
    }
}



