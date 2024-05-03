using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Test etmək istənilən ay günlərini və bölücü rəqəmi daxil edin:");
        string inputStr = Console.ReadLine();
        string[] inputArray = inputStr.Split(' ');
        int result = 0;


        if (inputArray.Length > 1)
        {
            int divisorInt = int.Parse(inputArray[inputArray.Length - 1]);

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                string inputSingleStr = inputArray[i];
                int inputSingleInt = int.Parse(inputSingleStr);

                //reverse prosesi
                string numStr = inputSingleStr;
                char[] charArray = numStr.ToCharArray();
                Array.Reverse(charArray);
                string reversedStr = new string(charArray);
                int reversedSingleInt = int.Parse(reversedStr);

                double subtraction = inputSingleInt - reversedSingleInt;
                double multipler = subtraction / divisorInt;

                if(multipler % 1 == 0){
                    result++;
                } 
            }
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Səhv giriş: Dəstəklənməyən input daxil edildi.");
        }
    }
}

//parse null aldiqda argumentNullException