using System;

string stringa = "ciao";
int numero = 10;
Console.Write(funzioneUno(stringa, numero));


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