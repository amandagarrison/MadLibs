using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            string noun;
            string adjective;
            string noun2;
            string adverb;
            string maleFriend;
            string adjective2;

            Console.Write("Enter a noun: ");
            noun = Console.ReadLine();

            Console.Write("Enter an adjective: ");
            adjective = Console.ReadLine();

            Console.Write("Enter another noun: ");
            noun2 = Console.ReadLine();

            Console.Write("Enter an adverb: ");
            adverb = Console.ReadLine();

            Console.Write("Enter a male friend's name: ");
            maleFriend = Console.ReadLine();

            Console.Write("Enter another adjective: ");
            adjective2 = Console.ReadLine();
            
            Console.WriteLine("My Last Meal");
            Console.WriteLine("For my last meal, I ate a " + noun + ". It was " + adjective + ". For my seasoning, I put " + noun2 + " on it and ate it " + adverb + ". I shared it with my friend " + maleFriend + ". He thought it was the best food that he ever tasted and was " + adjective2 + " about it.");

            Console.ReadLine();

        }
    }
}
