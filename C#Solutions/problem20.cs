using System;
using System.ComponentModel.DataAnnotations;

namespace AllProblems
{
    public static class Problem20
    {
        public static void Solve()
        {
            Console.WriteLine("Solution to Problem 20");
            
            Console.WriteLine("Give a string to validate:");
            string s = Console.ReadLine();
            bool result = IsValid(s);
            if (result == true)
                Console.WriteLine("The given string is: True");
            else
                Console.WriteLine("The given string is: False");
            
        }

        

        public static bool IsValid(string s)
        {
            // Dictionary for matching parentheses, brackets, and braces.
            Dictionary<char, char> dict1 = new Dictionary<char, char>
            {
            {'(', ')'}, {'{', '}'}, {'[', ']'}
             };

            // Stack to hold opening brackets
            Stack <char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if(dict1.ContainsKey(c)){
                    stack.Push(c);
                }
                
                else if(dict1.ContainsValue(c)){
                    if(stack.Count== 0 || dict1[stack.Peek()] != c){
                        return false;
                    }
                    stack.Pop();
                }
            }
            if(stack.Count == 0){
                return true;
            }
            else {
                return false;
            }


            

            
        }

        
    }
}
