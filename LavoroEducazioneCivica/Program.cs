using System;

namespace LavoroEducazioneCivica
{
    public class Program
    {
        static void Main(string[] args)
        {
            string stringa = "";
            int numero = 0;

            //stringa = "ABC";
            //numero = 2;

            Console.Write(FunzioneUno(stringa.ToUpper(), numero));
            Console.Write("\n");
            Console.Write(FunzioneDue(stringa.ToUpper(), numero));
            Console.Write("\n");
            Console.Write(FunzioneTre(stringa.ToUpper(), numero));

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

        public static string FunzioneDue(string stringa, int numero)    //impossibilità di inserire numeri superiori a 26
        {
            string stringaCriptata = "";

            foreach (char c in stringa)
            {
                if (char.IsLetter(c))
                {
                    char carattereCriptato = (char)(((int)c - numero  - 65 + 26) % 26 + 65);
                    stringaCriptata += carattereCriptato;
                }
                else
                {
                    stringaCriptata += c;
                }
            }
            return stringaCriptata;
        }
        public static int FunzioneTre(string stringa, int numero)    //impossibilità di inserire numeri superiori a 26
        {
            int numeroCalcolato = 0;
            foreach (char c in stringa)
            {
                if (char.IsLetter(c))
                {
                    numeroCalcolato += ((int)c - 64);
                }
            }
            return numeroCalcolato * numero;
        }

        public static int FunzioneQuattro(string stringa, int numero)    //impossibilità di inserire numeri superiori a 26
        {
            int numeroCalcolato = 0;
            return numeroCalcolato * numero;
        }
    }
}



