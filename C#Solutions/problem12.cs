using System;



namespace AllProblems
{
    public static class Problem12
    {
        public static void Solve()
        {
            Console.WriteLine("Solution to Problem 12:Interger to Roman Convertion");
            
            Console.WriteLine("Enter the numbers to convert Roman Number");
            int num = int.Parse(Console.ReadLine());

            string roman = integerToRoman(num);
            
            Console.WriteLine("Roman Number: " + roman);
            
        }

        

        public static string integerToRoman(int num)
        {
           int n1;
        List<char> roman = new List<char>();

        while( num > 0){
    
            if (num >= 1000){
                n1 = num / 1000;
                num = num % 1000;
        
                for(int i = 0; i< n1; i++){
                    roman.Add('M');
                }
            }
            else if (num >= 100 && num < 1000 ){
                n1 = num / 100;
                num = num % 100;
                if(n1 < 4){
                    for(int i = 0; i< n1; i++){
                    roman.Add('C');
                     }
                }
                else if(n1 == 4){
                    roman.Add('C');
                    roman.Add('D');

                }
                else if(n1 == 5){
                    roman.Add('D');
        
                }
                else if (n1 > 5 && n1 < 9){
                    roman.Add('D');
                    for(int i = 6; i <= n1;i++){
                    roman.Add('C');

                    }
                 }
                else if(n1 == 9){
                    roman.Add('C');
                    roman.Add('M');
                }

            }
            else if (num >= 10 && num < 100){
                n1 = num / 10;
                num = num % 10;
                if(n1 < 4){
                    for(int i = 0; i< n1; i++){
                    roman.Add('X');
                    }
                }
                else if(n1 == 4){
                    roman.Add('X');
                    roman.Add('L');
                }
                else if(n1 == 5){
                    roman.Add('L');
        
                }
                else if (n1 > 5 && n1 < 9){
                    roman.Add('L');
                    for(int i = 6; i <= n1;i++){
                    roman.Add('X');

                    }
                }
                else if(n1 == 9){
                    roman.Add('X');
                    roman.Add('C');
                }

            }
            else if (num < 10){
                n1 = num;
                num = 0;
                if(n1 < 4){
                    for(int i = 0; i< n1; i++){
                    roman.Add('I');
                    }
                }
                else if(n1 == 4){
                    roman.Add('I');
                    roman.Add('V');
                }
                else if(n1 == 5){
                    roman.Add('V');
                }
                else if (n1 > 5 && n1 < 9){
                    roman.Add('V');
                    for(int i = 6; i <= n1;i++){
                    roman.Add('I');
                    }
                }
                else if(n1 == 9){
                    roman.Add('I');
                    roman.Add('X');
                }
            }
            else {
                break;
            }
        }
        string romanNumeral = new string(roman.ToArray());
        return romanNumeral;
            
        }

        
    }
}

