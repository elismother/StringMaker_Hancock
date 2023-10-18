using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMaker_Hancock_Project
{
    internal class StringMaker
    {
        private string _string;
        public string Reverse (string s)
        {
            Stack<char> charStack = new Stack<char>();
            foreach (char c in s)
            {
                    charStack.Push(c);
            }
            s = "";
            foreach (char c in charStack)
            {
                    s = s + c;
            }
            return s;
        }

        public string Reverse (string s, bool PreserveCaseLocation)
        {
            int count = -1;
            char lowerChar;
            char upperCase;

            Stack<char> charStack = new Stack<char>();
            Queue<int> intQueue = new Queue<int>();
            foreach (char c in s)
            {
                count++;
                if (char.IsUpper(c))
                {
                    intQueue.Enqueue(count);
                }
                if (char.IsLetter(c))
                {
                    lowerChar = char.ToLower(c);
                    charStack.Push(lowerChar);
                }
                else
                {
                    charStack.Push(c);
                }
            }
            s = "";
            count = -1;
            foreach (char c in charStack)
            {
                count++;
                if (intQueue.Contains(count))
                {
                    upperCase = char.ToUpper(c);
                    s = s + upperCase;
                }
                else
                {
                    s = s + c;
                }
            }
            return s;
        }

        public bool Symmetric (string s)
        {
            Queue<char> charQueue = new Queue<char>();
            string reversedString = this.Reverse(s);
            foreach (char c in s)
            {
                charQueue.Enqueue(c);
            }
            
            for (int i = 0; i < reversedString.Length; i++)
            {
                if (!(charQueue.Dequeue() == reversedString[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public override string ToString()
        {

            string s = "ok";

            return s;
        }
    }
}
