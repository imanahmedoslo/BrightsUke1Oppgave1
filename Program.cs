using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightsUke1Oppgave1
{
    internal class Program
    {
        public static string Farge = "";
        public static int i = 0;
        static void Main(string[] args)
        {
            printFrukt();
        }
        public static void printFrukt()
        {

            Console.WriteLine("Welcome! please choose the color of the fruit you want to see! hint:" +
                " we only have  yellow, red, or orange ");

            while (Farge is string && i == 0)
            {
                Farge = Console.ReadLine();
                switch (Farge.ToLower())
                {
                    case "yellow":
                        Console.WriteLine("you`ve got yourself a banana!");
                        break;
                    case "red":
                        Console.WriteLine("you`ve got yourself an apple");
                        break;
                    case "orange":
                        Console.WriteLine("you`ve got yourself an orange");
                        break;
                    case "stop":
                        Console.WriteLine(" this program will now shut down.");
                        i = 1;
                        break;

                    default:
                        Console.WriteLine("I do not have anything for you, sorry T_T");
                        break;


                }

            }
            i = 0;

        }
    }
}
