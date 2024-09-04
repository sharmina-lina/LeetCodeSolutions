using System;
using System.Xml.XPath;

namespace AllProblems
{
    public static class Problem14
    {
        public static void Solve()
        {
            Console.WriteLine("Solution to Problem 14: Longest common prefix");
            
        // Prompt the user to enter a list of strings
        Console.WriteLine("Enter a list of strings separated by commas (e.g., flower,flow,flight):");
        
        // Read the input from the console
        string input = Console.ReadLine();
        
        // Split the input string by commas to get individual strings
        string[] strs = input.Split(',');

        // For example, finding the longest common prefix
        string prefix = FindLongestCommonPrefix(strs);
        Console.WriteLine($"Longest Common Prefix: {prefix}");
            
            
            
        }

        

        public static string FindLongestCommonPrefix(string[] strs)
        {   
            if (strs == null || strs.Length == 0){
            return "";
            }
            
             else {
                Array.Sort(strs);
                string firstStr = strs[0];
                string lastStr = strs[strs.Length -1];
                int i = 0;
                while(i < firstStr.Length && i < lastStr.Length && firstStr[i]==lastStr[i]) {
                    i +=1;

                }
               
            return firstStr.Substring(0,i);
        
            
            }
        }

        
    }
}
