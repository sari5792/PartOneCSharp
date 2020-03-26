using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Linq(1)
            string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            Console.WriteLine(" Display the name of the days of a week : ");


            var days = from WeekDay in dayWeek
                       select WeekDay;
            foreach (var WeekDay in days)
            {
                Console.WriteLine(WeekDay);
            }
            Console.WriteLine();
           
            // Linq(2)

            int[] integerArr = { 5, 10, 15, 20, 25 };
            List<int> subset = integerArr.Skip(0).Take(3).ToList();

            Console.WriteLine("The number is:");
            foreach (var item in subset)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Average is: {0}", subset.Average());

            //Tuple
            Random rnd = new Random();
            List<Tuple<int, int, int, int>> list = new List<Tuple<int, int, int, int>>();

            for (int i = 0; i < 4; i++)
            {
                list.Add(Tuple.Create(rnd.Next(1, 100), rnd.Next(1, 100), rnd.Next(1, 100), rnd.Next(1, 100)));

            }



            foreach (var tuple in list)
            {
                Console.WriteLine("{0} , {1} , {2} , {3}", tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4);
            }
   //Reflection 
        //1

        DateTime dateTime = (DateTime)Activator.CreateInstance(typeof(DateTime));

        //2


        int x =  1;
        Type type = x.GetType();
       
      Console.WriteLine(type.Name);

        }

     
         






    }
}



