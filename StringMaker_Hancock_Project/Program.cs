// Brittany Hancock
// IT113
// NOTES:  notes the instructor should read
// BEHAVIORS NOT IMPLEMENTED AND WHY:

using System.Runtime.InteropServices;

namespace StringMaker_Hancock_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringMaker StringManager = new StringMaker();
            Console.WriteLine(StringManager.Reverse("Sunbeam Tiger"));
            Console.WriteLine(StringManager.Reverse("Sunbeam Tiger", true));
            Console.WriteLine(StringManager.Symmetric("ABBA"));
            Console.WriteLine(StringManager.Symmetric("ABA"));
            Console.WriteLine(StringManager.Symmetric("ABba"));
            Console.WriteLine(StringManager.ToString("Dan"));

        }
    }
}