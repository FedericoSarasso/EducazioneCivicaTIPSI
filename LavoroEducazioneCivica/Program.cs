using System;

namespace LavoroEducazioneCivica
{
    public class Program
    {
        static void Main(string[] args)
        {
            string stringa = "";
            int numero = 0;

            //stringa = "ABCDEFGHIJKLOPQRSTUVWXYZ";
            //numero = 27;

            Console.Write(FunzioneUno(stringa.ToUpper(), numero));


            Console.ReadLine();
        }

        public static string FunzioneUno(string stringa, int numero)
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

        public static string FunzioneDue(string stringa, int numero)
        {
            string stringaCriptata = "";
            return stringaCriptata;
        }
    }
}



