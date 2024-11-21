using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Activity_10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * DSA Activity 10.1 - Baltazar, Mark Daves L.
             * Program Description: A program that lets users perform basic set operations with HashSet<int>. 
             * After generating two sets of unique random numbers, users can execute operations like Union 
             * and Intersection until they exit, facilitating an interactive exploration of set theory.
             */

            while (true)
            {
                HashSet<int> setA = new HashSet<int>();
                HashSet<int> setB = new HashSet<int>();
                Random random = new Random();

                Console.Write("Enter first number: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                int n2 = int.Parse(Console.ReadLine());

                for (int i = 0; i < n1; i++) { setA.Add(random.Next(1, 10)); }
                for (int i = 0; i < n2; i++) { setB.Add(random.Next(1, 10)); }

                ShowSet("A"); ShowResult(setA);
                Console.WriteLine();
                ShowSet("B"); ShowResult(setB);

                Menu();
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: setA.UnionWith(setB); Operation("1"); ShowResult(setA); NewSpace(); break;
                    case 2: setA.IntersectWith(setB); Operation("2"); ShowResult(setA); NewSpace(); break;
                    case 3: setA.ExceptWith(setB); Operation("3"); ShowResult(setA); NewSpace(); break;
                    case 4: setA.SymmetricExceptWith(setB); Operation("4"); ShowResult(setA); NewSpace(); break;
                    case 5: Console.WriteLine("\nExiting program..."); Console.ReadKey(); return;
                    default: Console.WriteLine("Invalid choice! Try again.\n"); break;
                }
            }
        }
        static void Menu()
        {
            Console.WriteLine("\n\nCHOOSE OPERATION");
            Console.WriteLine("[1] Union");
            Console.WriteLine("[2] Intersection");
            Console.WriteLine("[3] Difference");
            Console.WriteLine("[4] Symmetric Difference");
            Console.WriteLine("[5] Exit");
        }
        static void ShowResult(HashSet<int> name)
        {
            Console.Write("{ ");
            foreach (var i in name) { Console.Write($"{i} "); }
            Console.Write("}");
        }
        static void ShowSet(string set)
        {
            Console.Write($"Set {set}: ");
        }
        static void Operation(string operation)
        {
            if (operation == "1") { Console.Write("Union: "); }
            else if (operation == "2") { Console.Write("Intersection: "); }
            else if (operation == "3") { Console.Write("Difference: "); }
            else if (operation == "4") { Console.Write("Symmetric Difference: "); }
        }
        static void NewSpace()
        {
            Console.WriteLine("\n");
        }
    }
}
