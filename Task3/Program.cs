using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Marc neçə cupcake yedi?");
        string marcsCupcakesCount = Console.ReadLine();
        int marcsCupcakesCountInt = int.Parse(marcsCupcakesCount);

        if (marcsCupcakesCountInt > 0)
        {
            Console.WriteLine("Cupcake'lərin kalorilərini daxil edin. (nümunə: 1 2 3 4)");
            string inputNums = Console.ReadLine();
            string[] nums = inputNums.Split(' ');

            if (nums.Length == marcsCupcakesCountInt)
            {
                int[] singleCalories = new int[marcsCupcakesCountInt];

                for (int i = 0; i < nums.Length; i++)
                {
                    int singleCalorie = int.Parse(nums[i]);
                    singleCalories[i] = singleCalorie;
                }

                Array.Sort(singleCalories);
                Array.Reverse(singleCalories);

                long minMiles = 0;

                for (int i = 0; i < singleCalories.Length; i++)
                {
                    minMiles += singleCalories[i] * (long)Math.Pow(2, i);
                }

                Console.WriteLine("Minimum məsafə: " + minMiles);
            }
            else
            {
                Console.WriteLine("Səhv giriş: Cupcake sayısi gözlənilən sayıya bərabər deyil.");
            }
        }
        else
        {
            Console.WriteLine("Səhv giriş: Marc ən az 1 cupcake yeməlidir.");
        }
    }
}
