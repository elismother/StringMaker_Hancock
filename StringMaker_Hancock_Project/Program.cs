// Brittany Hancock
// IT113
// NOTES:  none
// BEHAVIORS NOT IMPLEMENTED AND WHY: n/a

using System.Runtime.InteropServices;

namespace StringMaker_Hancock_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringMaker StringManager = new();
            Console.WriteLine(StringManager.Reverse("Sunbeam Tiger"));
            Console.WriteLine(StringManager.ToString());
            Console.WriteLine(StringManager.Reverse("Sunbeam Tiger", true));
            Console.WriteLine(StringManager.Equals("Sunbeam Tiger"));
            Console.WriteLine(StringManager.Symmetric("ABBA"));
            Console.WriteLine(StringManager.Symmetric("ABA"));
            Console.WriteLine(StringManager.Symmetric("ABba"));
        }
    }
}