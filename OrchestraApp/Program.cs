using System;
using OrchestraApp.Model;

namespace OrchestraApp

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Orchestra!");

            Orchestra orchestra = new();   //Guitar myGuitar = new();
            orchestra.Play();              //Console.WriteLine(myGuitar.Play());
        }
    }
}