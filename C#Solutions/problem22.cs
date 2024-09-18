using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.XPath;

namespace AllProblems
{
    public static class Problem22
    {
        public static void Solve()
        {
            Console.WriteLine("Solution to Problem 22: Generate Parenthesis");
            
            Console.WriteLine("Give a number to generate possible parenthesis:");
            int n = int.Parse(Console.ReadLine());
            List<string> result = GenerateParenthesis(n);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            
            
        }

        

        public static List<string> GenerateParenthesis(int n)
        {
            List<string> result = new List<string>();
            generate(result, "", 0, 0, n);
            return result;

        }

        public static void generate(List<string> result, string current, int open, int close, int max ){
            if(current.Length == max*2){
                result.Add(current);
                return;
            }
            if(open < max){
                generate(result, current+'(', open +1, close, max);
            }
            if(close < open){
                generate(result, current+')', open, close+1,max);
            }
        }

        
    }
}
