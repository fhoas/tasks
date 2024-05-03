using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Neçə tələbə var?");
        string studentCountInput = Console.ReadLine();
        int studentCount = int.Parse(studentCountInput);

        if (studentCount > 0)
        {
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"Tələbə {i + 1}'in aldığı qiyməti daxil edin. (nümunə: 67):");
                string originalGradeInput = Console.ReadLine();
                int originalGrade = int.Parse(originalGradeInput);

                if (originalGrade != 0)
                {
                    int modifiedGrade = 0;

                    if (originalGrade > 37 && originalGrade <= 100)
                    {
                        if (originalGrade % 5 == 3 || originalGrade % 5 == 4)
                        {
                            if(originalGrade % 5 == 3){
                            modifiedGrade = originalGrade + 2;
                            } else if(originalGrade % 5 == 4){
                            modifiedGrade = originalGrade + 1;
                            }
                            Console.WriteLine($"Tələbə {i + 1}'in nəticəsi {modifiedGrade} olaraq dəyişdirildi.");
                        }
                        else{
                            Console.WriteLine($"Tələbə {i + 1}'in nəticəsi şərtləri ödəmədiyi üçün dəyişdirilmədi.");
                        }
                    }
                    else if(originalGrade <= 37)
                    {
                        Console.WriteLine("Tələbənin aldığı qiymət limitdən aşağıdır və uğursuz nəticədir.");
                    } else
                    {
                        Console.WriteLine("Tələbənin aldığı qiymət 100'dən çox ola bilməz.");
                    }
                }
                else
                {
                    Console.WriteLine("Səhv giriş: Düzgün bir tam rəqəm daxil edin.");
                }
            }
            Console.WriteLine("Qiymətləndirmələr yerinə yetirildi!");
        }
        else
        {
            Console.WriteLine("Səhv giriş: Pozitiv bir tam rəqəm daxil edin.");
        }
    }
}