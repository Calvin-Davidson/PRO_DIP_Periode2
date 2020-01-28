using System;

namespace PopulationControl
{
    public class Person
    {
        private string[] OogKleuren = { "groen", "blauw", "geel", "bruin", "zwart" };
        private string naam = "None";
        private string OogKleur = "None";

        private int leeftijd = -10;

        private string geboorteland = "None";

        private int BSN = 0;


        public string getNaam() {
            return this.naam;
        }

        public void setNaam(string n) {
        string[] args = n.Split(" ");
        Console.WriteLine("DE NAAM IS " +args.Length + " ARGUMENTEN LANG");
        if (args.Length >= 4) { 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("De naam mag MAX uit 4 woorden bestaan");
            Console.ResetColor();
        } else {
        this.naam = n;
            }
        }

        public string getOogkleur() {
            return OogKleur;
        }
        public void setOogkleur(string k) {
            bool mag = false;
            foreach(string s in OogKleuren) {
                if (k == s) {
                    mag = true;
                }
            }
            if (mag == true) {
            this.OogKleur = k;
            mag = false;
            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Deze oog kleur mag niet");
            Console.ResetColor();
                        mag = false;

            }
        }
        public int getLeeftijd() {
            return leeftijd;
        }

        public void setLeeftijd(int l) {

            if (l > 0 && l < 110) {
            this.leeftijd = l;
            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hmm de leeftijd klopt niet helemaal.");
            Console.ResetColor();

            }
        }

        public string getland() {
            return geboorteland;
        }

        public void setLand(string l) {
            bool mag = false;
            foreach (string s in CountryList.LIST) {
                if (l.Equals(s)) {
                    mag = true;
                }
            }
            if (mag == true) {
            this.geboorteland = l;
        } else {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hmm. Ik herken het land niet");
            Console.ResetColor();

        }
        }

        public int getBSN() {
            return BSN;
        }
        public void setBSN(string bsn) {
            
            if (bsn.Length.Equals(9)) {
            int number = Convert.ToInt32(bsn);
            this.BSN = number;
            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hmm de BSN nummer is te lang of te kort!");
            Console.ResetColor();

            }
        }
    }
}