using System;



namespace AllProblems
{
    public static class Problem13
    {
        public static void Solve()
        {
            Console.WriteLine("Solution to Problem 13:Roman to Integer Convertion");
            
            Console.WriteLine("Enter the Roman to convert  into Integer");
            string romanNum = Console.ReadLine();

            int intNum = romanToInt(romanNum);
            
            Console.WriteLine("Integer Number after conversion from Roman: " + intNum);
            
        }

        

        public static int romanToInt(string romanNum)
        {
           Dictionary<char, int> romanInt
            = new Dictionary<char, int>() {
                  { 'I', 1 }, { 'V', 5 }, { 'X', 10 },
                      { 'L', 50 }, { 'C', 100 },
                      { 'D', 500 },
                  {
                      'M', 1000
                  }
              };
            int num = 0;
            int i = 0;
            while (i < romanNum.Length){
                if(i+1 < romanNum.Length && (romanInt[romanNum[i]] < romanInt[romanNum[i+1]])){
                    num += (romanInt[romanNum[i+1]]- romanInt[romanNum[i]]);
                    i += 2;

                }
                
                else {
                    num += romanInt[romanNum[i]];
                    i += 1;

                }
                

            }
            
            return num;            
        }

        
    }
}

