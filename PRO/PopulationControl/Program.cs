using System;

namespace PopulationControl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Heyy, welke bij het registratie systeem.");
            Console.WriteLine("Wat is uw naam?");
            string naam = Console.ReadLine();
            
            Console.WriteLine("Wat is uw OogKleur?");
            string OogKleur = Console.ReadLine();

            Console.WriteLine("Wat is uw Leeftijd?");
            string Leeftijd = Console.ReadLine();

            Console.WriteLine("Wat is uw Geboorteland?");
            string land = Console.ReadLine();

            Console.WriteLine("Wat is uw BSN?");
            string bsn = Console.ReadLine();

            Person p = new Person();
            Console.Clear();
            p.setNaam(naam);
            p.setOogkleur(OogKleur);
            p.setLeeftijd(Convert.ToInt32(Leeftijd));
            p.setLand(land);
            p.setBSN(bsn);
            
            if (personIsGoed(p)) {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("-----------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Helemaal top alles is goed gegaan!");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("-----------------------------------------------------");
                    Console.ResetColor();
                } else {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("-----------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Hmm, Niet alles blijkt te kloppen probeer het opnieuw\n Hierboven zie je wat allemaal fout was, Je mag gewoon nog is proberen!");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("-----------------------------------------------------");
                    Console.ResetColor();
                }
                
            
            bool personIsGoed(Person person) {
                if (person.getNaam() != "None") {
                    if (person.getOogkleur() != "None") {
                        if (person.getLeeftijd() != -10) {
                            if (person.getland() != "None") {
                                if (person.getBSN() != 0) {
                                    return true;
                                }
                            }
                        }
                    }
                }
                return false;
                       }
                    }
                }
            }
                    

