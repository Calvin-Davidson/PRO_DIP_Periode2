using System;
using System.Collections;
using System.IO;
namespace SteamWritter
{
    class Program
    {
    public static ArrayList msg = new ArrayList();

        static void Main(string[] args)
        {
        while (true) {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
             Console.WriteLine("Type wat u wilt doen u kunt kiezen uit\n'clear', 'addline', 'setonly'");
             Console.ResetColor();
            string input = Console.ReadLine();

            switch(input) {
                case "clear":
                File.WriteAllText(@"C:\Users\calvi\OneDrive\Documenten\ma\bewijzenmap\periode1.2\pro2\achievements\brons\SteamWritter\message.txt", " ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Succesvol de file gecleared");
                break;

                case "addline":
                input = Console.ReadLine();

                if(addLine(input)) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Succesvol");
                } else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Something went wrong");
                }
                
                break;
                case "setonly":
                input = Console.ReadLine();
                
                if(setOnly(input)) {
                Console.WriteLine("Succesvol");
                Console.ForegroundColor = ConsoleColor.Green;
                } else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Something went wrong");
                }
                break;
            }
        }
    }
         private static bool addLine(string message) 
            {
                using (System.IO.StreamWriter file = 
                new System.IO.StreamWriter(@"C:\Users\calvi\OneDrive\Documenten\ma\bewijzenmap\periode1.2\pro2\achievements\brons\SteamWritter\message.txt", true))
                {
                    if (file != null) {
                	file.WriteLine(message);
                    return true;
                    } else {
                        return false;
                    }
                }
            }

                     private static bool setOnly(string message) 
            {
                if (message != null) {
                File.WriteAllText(@"C:\Users\calvi\OneDrive\Documenten\ma\bewijzenmap\periode1.2\pro2\achievements\brons\SteamWritter\message.txt", " ");
                return true;
                    } else {
                        return false;
                    }
                }
            }
        }

