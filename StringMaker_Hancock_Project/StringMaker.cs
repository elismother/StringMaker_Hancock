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
            _string = s;
            Stack<char> charStack = new();
            foreach (char c in s)
            {
                    charStack.Push(c);
            }
            s = "";
            foreach (char c in charStack)
            {
                    s += c;
            }
            return s;
        }

        public string Reverse (string s, bool PreserveCaseLocation)
        {
            _string = s;
            if (!PreserveCaseLocation)
            {
                Reverse(s);
            }
            else
            {
                int count = -1;
                char lowerChar;
                char upperCase;

                Stack<char> charStack = new();
                Queue<int> intQueue = new();
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
                        s += upperCase;
                    }
                    else
                    {
                        s += c;
                    }
                }
            }
            return s;
        }

        public bool Symmetric (string s)
        {
            _string = s;
            Queue<char> charQueue = new();
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
            if (_string == null||_string == "")
            {
                return "-1";
            }
            int value = 0;
            int trim;
            string s = _string;
            string concat = "";
            string final = "";
            foreach (char c in s)
            {
                value += (int)c;
            }
            while (value > 0)
            {
                trim = value % 10;
                concat += trim;
                value /= 10;
            }
            concat = Reverse(concat);

            foreach (char c in concat)
            {
                if (c == '-')
                {
                    final = "Negative ";
                }
                if (c == '1')
                {
                    final += "One ";
                }
                if (c == '2')
                {
                    final += "Two ";
                }
                if (c == '3')
                {
                    final += "Three ";
                }
                if (c == '4')
                {
                    final += "Four ";
                }
                if (c == '5')
                {
                    final += "Five ";
                }
                if (c == '6')
                {
                    final += "Six ";
                }
                if (c == '7')
                {
                    final += "Seven ";
                }
                if (c == '8')
                {
                    final += "Eight ";
                }
                if (c == '9')
                {
                    final += "Nine ";
                }
            }
            if (final[^1] == ' ')
            {
                final = final.Trim();
            }
            return final;
        }

        public override bool Equals(object? obj)
        {
            if (obj is string stringValue)
            {
                if (stringValue == _string)
                {
                    return true;
                }
            }
            return false;
        }
    }
}