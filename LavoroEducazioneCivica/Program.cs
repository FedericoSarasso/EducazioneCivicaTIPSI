using System;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;


namespace LavoroEducazioneCivica
{
    public class Global
    {
        public static int contatore = 0;
    }
    public class Program
    {
        static void Main(string[] args)
        {
            string stringa = "";
            int numero = 0;

            stringa = "ABC";
            numero = 1;

            Console.Write(FunzioneUno(stringa.ToUpper(), numero));
            Console.Write("\n");
            Console.Write(FunzioneDue(stringa.ToUpper(), numero));
            Console.Write("\n");
            Console.Write(FunzioneTre(stringa.ToUpper(), numero));
            Console.Write("\n");
            Console.Write(FunzioneQuattro(stringa.ToUpper(), numero));
            Console.Write("\n");
            Console.Write(FunzioneCinque(stringa.ToUpper(), numero));
            Console.Write("\n");
            Console.Write(Global.contatore);
            Console.Write("\n");
            Console.Write(FunzioneSei(stringa.ToUpper()));
            Console.Write("\n");

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
            numero = numero % 26;
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
        public static int FunzioneTre(string stringa, int numero)    
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

        public static double FunzioneQuattro(string stringa, int numero) 
        {
            double numeroCalcolato = 0.0;
            foreach (char c in stringa)
            {
                if (char.IsLetter(c))
                {
                    numeroCalcolato += ((int)c - 64);
                }
            }
            return Math.Round(numeroCalcolato / numero);
        }

        public static int FunzioneCinque(string stringa, int numero)
        {
            Global.contatore += 1;
            int tempNumero = numero;
            string tempStringa = stringa;
            if(tempNumero % 2 == 0)
            {
                
                return FunzioneTre(tempStringa, tempNumero);
            }
            else
            {
                double result = FunzioneQuattro(tempStringa, tempNumero);
                return Convert.ToInt16(result);
            }
        }

        public static int FunzioneSei(string stringa)
        {
            int tempNumero = Global.contatore;
            string tempStringa = stringa;
            return FunzioneCinque(stringa, tempNumero);
        }
    }
}



