using System;

namespace _25032022
{
    class Program
    {
        static void Main(string[] args)
        {
            #region class-task

            //    //CLASS WORK//
            //    string name = "aytan";
            //    string surname = "zeynalova";
            //    byte age = 10;
            //    double salary = 1;
            //    int hour = 3;
            //    Worker worker1 = new Worker(salary, hour, name, surname, age);
            //    worker1.salaryForHour = Convert.ToDouble(Console.ReadLine());
            //    worker1.hour = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(Salary(worker1.salaryForHour, worker1.hour, age));


            //}
            //static double Salary(double salaryForHour, int hour, byte age)
            //{
            //    if (age < 18)
            //    {
            //        return -1;
            //    }
            //    else
            //    {
            //        double finalsalary = hour * salaryForHour;
            //        return finalsalary;
            //    }



            //    //return salary;
            //}





            #endregion

            string words = "Ayten";
            Console.WriteLine(check(words));

        }

        // task-1//
        static void removeSpaces(string table)
        {
            string[] array = table.Split(' ');
            table = "";
            foreach (var item in array)
            {
                if (item != "")
                {
                    table += item + " ";
                }
            }
            Console.WriteLine(table.TrimEnd());
        }
        //TASK2//
        static bool check(string words)
        {
            int count = 0;
            foreach (var item in words)
            {
                if (char.IsDigit(item))
                {
                    count++;
                    //break;
                }
            }
            foreach (var item in words)
            {
                if (char.IsUpper(item))
                {
                    count++;
                    //break;
                }
            }
            foreach (var item in words)
            {
                if (char.IsLower(item))
                {
                    count++;
                    //break;
                }
            }
            if (count == 3 || count >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //TASK 3//
        static string FindFirstWord(string words)
        {
            string word = "";
            words = words.Trim();
            for (int i = 0; i < words.Length -1; i++)
            {
                word = words[0];
            }
            return word;

        }
        //task 4//







        //TASK5//
        static void AddNum(int[] nums, int num)
        {
            int[] newarr = new int[nums.Length + 1];
            int i = 0;
            foreach (var item in nums)
            {
                newarr[i++] = item;
            }
            newarr[nums.Length] = num;
            nums = newarr;
        }
    }
}
