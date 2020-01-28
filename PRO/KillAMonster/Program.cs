using System;
using System.Collections;
using System.Collections.Generic;
namespace KillAMonster
{
    class Program
    {
        static void Main(string[] args)
        {
        List<Monster> monsters = new List<Monster>();
        ArrayList deadMonsters = new ArrayList();
        // Initialize the objects
        monsters.Add(new Monster());
        monsters.Add(new Monster());
        monsters.Add(new Monster());
        monsters.Add(new Monster());
        monsters.Add(new Monster());
        // to set values for the radius 
        monsters[0].setHP(100);
        monsters[0].setnaam("Jef");

        monsters[1].setHP(100);
        monsters[1].setnaam("Bob");

        monsters[2].setHP(100);
        monsters[2].setnaam("Robbin");

        monsters[3].setHP(100);
        monsters[3].setnaam("Jermo");

        monsters[4].setHP(100);
        monsters[4].setnaam("Lizzzzzz");
        // for loop to display areas 
        while(true) {
        ShowHP();
        WriteDeadMonsters();

        Console.WriteLine("Type 'attack (naam)' om een monster aan te vallen.");
        string PlayerInput = Console.ReadLine();
        args = PlayerInput.Split(" ");
        if (args[0] == "Attack" || args[0] == "attack") {
        string input = args[1];
        foreach (Monster m in monsters) {
            if (input.Equals(m.getnaam())) {
            m.setHP(m.getHP() - 25);

            if (m.getHP() == 0) {
                deadMonsters.Add(m.getnaam());
                m.setisDead(true);
                }
            }
        }
    }
}
        void ShowHP() {
        Console.Clear();
        for (int i = 0; i < monsters.Count; i++)  
        {
            if (monsters[i].getIsDead() != true) {
            Console.WriteLine(monsters[i].getnaam() + " zijn hp is: "+  monsters[i].getHP());
                    }   
                }
            }
        void WriteDeadMonsters() {
            Console.WriteLine();
            foreach(String s in deadMonsters) {
                Console.Write(" * " + s);
            }
            Console.WriteLine();
        }
        }
    }
}
