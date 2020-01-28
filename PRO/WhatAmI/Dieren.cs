using System;

namespace WhatAmI
{
public struct Dieren
{
    public string Soort;
    public Dieren(string soort)
    {
        Soort = soort;
        
        Console.WriteLine("Ik ben een: " + soort);
        
        }
    }
}
