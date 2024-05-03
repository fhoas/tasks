using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Neçə test etmək istəyirsən?");
        string testCountInput = Console.ReadLine();

            int testCount = int.Parse(testCountInput);

            if (testCount > 0)
            {
                for (int i = 0; i < testCount; i++)
                {
                    Console.WriteLine($"Test {i + 1} üçün başlangıç və bitiş rəqəmlərini daxil edin. (nümunə: 3 9):");
                    string inputNums = Console.ReadLine();
                    string[] nums = inputNums.Split(' ');

                    if (nums.Length == 2)
                    {
                        int start = int.Parse(nums[0]);
                        int end = int.Parse(nums[1]);

                        if (start >= 0 && start <= 999 && end >= 0 && end <= 999)
                        {
                            int count = 0;
                            for (int j = start; j <= end; j++)
                            {
                                double sqrt = Math.Sqrt(j);
                                if (sqrt == (int)sqrt)
                                {
                                    count++;
                                }
                            }
                            Console.WriteLine($"Cavab: {count}");
                        }
                        else
                        {
                            Console.WriteLine("Səhv giriş: Dəstəklənməyən input daxil edildi");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Səhv giriş: Dəstəklənməyən input daxil edildi.");
                    }
                }
                Console.WriteLine("Testlər yerinə yetirildi!");
            }
            else
            {
                Console.WriteLine("Səhv giriş: Pozitiv bir tam rəqəm daxil edin.");
            }
    }
}
