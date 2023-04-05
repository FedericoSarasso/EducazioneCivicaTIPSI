using Microsoft.VisualBasic;
using System;
using System.Diagnostics.Metrics;
using System.Globalization;
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
            int funzione;

            //stringa = "ABC";
            //numero = 1;

            Console.Write("1 -> FunzioneUno\n2 -> FunzioneDue\n3 -> FunzioneTre\n4 -> FunzioneQuattro\n5 -> FunzioneCinque\n6 -> FunzioneSei\n");

            while (true)
            {
                try
                {
                    Console.Write("Inserisci un numero compreso tra 1 e 6:\n");
                    funzione = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    funzione = 0;
                }

                switch (funzione)
                {
                    case 1:
                        stringa = CompilazioneStringa();
                        numero = CompilazioneNumero();
                        Console.Write(FunzioneUno(stringa.ToUpper(), numero));
                        Console.Write("\n");
                        break;
                    case 2:
                        stringa = CompilazioneStringa();
                        numero = CompilazioneNumero();
                        Console.Write(FunzioneDue(stringa.ToUpper(), numero));
                        Console.Write("\n");
                        break;
                    case 3:
                        stringa = CompilazioneStringa();
                        numero = CompilazioneNumero();
                        Console.Write(FunzioneTre(stringa.ToUpper(), numero));
                        Console.Write("\n");
                        break;
                    case 4:
                        stringa = CompilazioneStringa();
                        numero = CompilazioneNumero();
                        Console.Write(FunzioneQuattro(stringa.ToUpper(), numero));
                        Console.Write("\n");
                        break;
                    case 5:
                        stringa = CompilazioneStringa();
                        numero = CompilazioneNumero();
                        Console.Write(FunzioneCinque(stringa.ToUpper(), numero));
                        Console.Write("\n");
                        break;
                    case 6:
                        stringa = CompilazioneStringa();
                        Console.Write(FunzioneSei(stringa.ToUpper()));
                        Console.Write("\n");
                        break;
                    default:
                        Console.WriteLine("Errore\n");
                        break;
                }
            }
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

        public static string CompilazioneStringa()
        {
            Console.Write("Inserisci testo: ");
            return (Console.ReadLine());

        }

        public static int CompilazioneNumero()
        {
            try
            {
            Console.Write("Inserisci un numero: ");
            return (int.Parse(Console.ReadLine()));
            }
            catch(Exception e)
            {
                Console.Write("Inserire esclusivamente numeri, assengato 0\n");
                return 0;
            }
        }
    }
}



