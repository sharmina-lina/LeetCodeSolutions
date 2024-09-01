using System;

namespace AllProblems
{
    public static class Problem17
    {
        public static void Solve()
        {
            Console.WriteLine("Solution to Problem 17");
            
            Console.WriteLine("Enter digits to get the combination:");
            string digits = Console.ReadLine();
            List<string> result = letterCombinationNumber(digits);
            if (result.Count > 0)
            {
                Console.WriteLine("Letter combination of Numbers: " + string.Join(", ", result));
            }
            else
            {
                Console.WriteLine("No combinations found.");
            }
        }

        

        public static List<string> letterCombinationNumber(string digits)
        {
            Dictionary<char, string> dict1 = new Dictionary<char, string>
            {
            {'1', ""}, {'2', "abc"}, {'3', "def"}, {'4', "ghi"},
            {'5', "jkl"}, {'6', "mno"}, {'7', "pqrs"}, {'8', "tuv"}, {'9', "wxyz"}
             };

            List<string> arr_out = new List<string>();
            if(string.IsNullOrEmpty(digits)){
                arr_out = [];
            }
            else{
                List <string> groups = digits.Select(d => dict1[d]).ToList();
                GenerateCombinations(groups, 0, "", arr_out);
                string.Join(',', arr_out);

            }

            return arr_out;
        }

        static void GenerateCombinations(List<string> groups, int index, string current, List<string> result)
        {
        if (index == groups.Count)
            {
                result.Add(current);
                return;
            }

            foreach (char c in groups[index])
            {
                GenerateCombinations(groups, index + 1, current + c, result);
            }
        }
    }
}
