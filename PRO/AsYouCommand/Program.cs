using System;
using System.Collections;
namespace AsYouCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoe groot moet de lijst zijn");
            string grooten = Console.ReadLine();

            Console.WriteLine("Hoe groot mag het max worden");
            string max = Console.ReadLine();
            

            Console.WriteLine(lijst(Convert.ToInt32(grooten), Convert.ToInt32(max)));
            string lijst(int grooten, int max)
            {
                string msg = "";
                ArrayList lijst = new ArrayList();
                for(int i = 0; i < grooten; i++)
                {
                    Random r = new Random();
                    int number = r.Next(max);
                    lijst.Add(number);
                }
                foreach(int i in lijst)
                {
                    msg += " " + i;
                }
                return msg;
            }
        }
    }
}
