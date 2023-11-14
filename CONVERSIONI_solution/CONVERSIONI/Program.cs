using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONVERSIONI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int scelta;
            do
            {
                do
                {
                    menu();
                    Console.Write("scelta ->");
                    scelta = Convert.ToInt32(Console.ReadLine());
                } while (scelta < 0 || scelta > 5);

                switch (scelta)
                {
                    case 1: // Da decimale a binario
                        Console.WriteLine("Da binario a decimale \n");
                    {
                        int dec, bit;
                        string output = ""; //dichiaro stringa vuota

                        do
                        {
                            Console.Write("Inserisci il decimale: ");
                            dec = Convert.ToInt32(Console.ReadLine());
                        } while (dec < 0);

                        do
                        {
                            bit = dec % 2;
                            output = bit.ToString() + output; //concateno
                            dec = dec / 2;
                        } while (dec != 0);

                        Console.Write(output);
                        Console.ReadKey();
                    }
                        break;
                    case 2: // Da binario a decimale
                        Console.WriteLine("Da decimale a binario \n");
                    {
                        int n, esp = 0, dec = 0, bit, pot;

                        do
                        {
                            Console.Write("Inserisci il numero di bit: ");
                            n = Convert.ToInt32(Console.ReadLine());
                        } while (n <= 0);

                        for (int i = 0; i < n; i++)
                        {
                            do
                            {
                                Console.Write("Inserisci un bit (dal - al +): ");
                                bit = Convert.ToInt32(Console.ReadLine());
                            } while (bit != 0 && bit != 1);

                            if (bit == 1)
                            {
                                pot = 1;
                                for (int j = 1; j <= esp; j++)
                                    pot *= 2;
                                dec += pot;
                            }

                            esp++;
                        }

                        Console.WriteLine("Il decimale corrispondete è " + dec);
                        Console.ReadKey();
                    }
                        break;
                    case 3: // Da decimale a esadecimale
                        Console.WriteLine("Da decimale a esadecimale \n");
                    {
                        int dec, resto;
                        string output = ""; //dichiaro stringa vuota
                        string ch = "";

                        do
                        {
                            Console.Write("Inserisci il decimale: ");
                            dec = Convert.ToInt32(Console.ReadLine());
                        } while (dec < 0);

                        do
                        {
                            resto = dec % 16;
                            if (resto > 9)
                            {
                                switch (resto)
                                {
                                    case 10:
                                        ch = "A";
                                        break;
                                    case 11:
                                        ch = "B";
                                        break;
                                    case 12:
                                        ch = "C";
                                        break;
                                    case 13:
                                        ch = "D";
                                        break;
                                    case 14:
                                        ch = "E";
                                        break;
                                    case 15:
                                        ch = "F";
                                        break;
                                }

                                output = ch + output;
                            }
                            else
                                output = resto.ToString() + output; //concateno

                            dec = dec / 16;
                        } while (dec != 0);

                        Console.Write(output);
                        Console.ReadKey();
                    }
                        break;
                    case 4: // Da esadecimale a decimale
                        Console.WriteLine("Da esadecimale a decimale \n");
                    {
                        int n; //lunghezza dell'esadecimale in input
                        int dec, x = 0, pot;
                        char cifra;

                        do
                        {
                            Console.Write("Inserisci la lunghezza: ");
                            n = Convert.ToInt32(Console.ReadLine());
                        } while (n < 0);

                        dec = 0;
                        for (int i = 0; i < n; i++)
                        {
                            do
                            {
                                Console.Write("Inserisci una cifra (dal - a +): ");
                                cifra = Convert.ToChar(Console.ReadLine());
                            } while (!((cifra > '0' && cifra <= '9') ||
                                       (cifra >= 'A' && cifra <= 'F')));

                            if (cifra >= '0' && cifra <= '9')
                                x = Convert.ToInt32(cifra) - 48; //perche il codice aschii non parte da 0 ma da 48
                            else
                            {
                                switch (cifra)
                                {
                                    case 'A':
                                        x = 10;
                                        break;
                                    case 'B':
                                        x = 11;
                                        break;
                                    case 'C':
                                        x = 12;
                                        break;
                                    case 'D':
                                        x = 13;
                                        break;
                                    case 'E':
                                        x = 14;
                                        break;
                                    case 'F':
                                        x = 15;
                                        break;
                                } // End Switch
                            } // End Else

                            pot = Convert.ToInt32(Math.Pow(16, i));

                            dec += (x * pot);
                        } // End For

                        Console.Write("Decimale corrispondente è: " +
                                      dec.ToString());
                        Console.ReadKey();
                    }
                        break;
                    case 5:
                    {
                        string esa;
                        int posizione;
                        //input del valore in esadecimale (string)
                        Console.Write("Inserisci un numero esadecimale: ");
                        esa = Console.ReadLine();
                        // riporta a maiuscolo tutta la stringa esadecimale
                        esa = esa.ToUpper();
                        // composizione della forma binaria del numero
                        for (posizione = 0; posizione < esa.Length; posizione++)
                        {
                            switch (esa[posizione])
                            {
                                case '0':
                                    Console.Write("0000");
                                    break;
                                case '1':
                                    Console.Write("0001");
                                    break;
                                case '2':
                                    Console.Write("0010");
                                    break;
                                case '3':
                                    Console.Write("0011");
                                    break;
                                case '4':
                                    Console.Write("0100");
                                    break;
                                case '5':
                                    Console.Write("0101");
                                    break;
                                case '6':
                                    Console.Write("0110");
                                    break;
                                case '7':
                                    Console.Write("0111");
                                    break;
                                case '8':
                                    Console.Write("1000");
                                    break;
                                case '9':
                                    Console.Write("1001");
                                    break;
                                case 'A':
                                    Console.Write("1010");
                                    break;
                                case 'B':
                                    Console.Write("1011");
                                    break;
                                case 'C':
                                    Console.Write("1100");
                                    break;
                                case 'D':
                                    Console.Write("1101");
                                    break;
                                case 'E':
                                    Console.Write("1110");
                                    break;
                                case 'F':
                                    Console.Write("1111");
                                    break;
                            }
                        }

                        Console.WriteLine();
                        Console.WriteLine("Premi un tasto per conrinuare...");
                        Console.ReadKey();
                    }
                        break;
                    case 6:
                    {
                        //Da testo a binario
                        Console.WriteLine("Da testo a binario \n");
                        {
                            string testo = String.Empty;
                            do
                            {
                                Console.Write("Inserisci il testo: ");
                                testo = Console.ReadLine();
                            } while (testo.Length == 0);

                            foreach (char c in testo)
                            {
                                Console.Write(Convert.ToString(c, 2).PadLeft(8, '0'));
                            }

                            Console.ReadKey();
                        }
                    }
                        break;
                }

                Console.Clear();
            } while (scelta != 0);

            Console.WriteLine("Il programma è terminato");
            Console.ReadKey();
        }

        static void menu()
        {
            Console.Clear();
            Console.WriteLine("MENU'");
            Console.WriteLine("1. Da decimale a binario'");
            Console.WriteLine("2. Da binario a decimale'");
            Console.WriteLine("3. Da decimale a esadecimale'");
            Console.WriteLine("4. Da esadecimale a decimale'");
            Console.WriteLine("5. Da esadecimale a binario");
            Console.WriteLine("6. Da testo a binario");
            Console.WriteLine("0. Esci'");
        }
    }
}