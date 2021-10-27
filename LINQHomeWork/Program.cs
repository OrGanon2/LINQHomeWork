using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Nums = new int[] { 10, 12, 14, 13, 11, 7, 5, 20, 9, 15 };
            Console.WriteLine("Q1++++++++++++++++++++++++++++");

            var quary1 = from num1 in Nums
                         where num1 % 2 == 0
                         select num1;
            foreach (var item in quary1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Q1++++++++++++++++++++++++++++");


            Console.WriteLine("Q2++++++++++++++++++++++++++++");

            var quary2 = Nums.Where(num2 => num2 % 2 == 1).OrderByDescending(num2 => num2);
                          
            foreach (var item in quary2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Q2++++++++++++++++++++++++++++");



            Console.WriteLine("Q3+++++++++++++++++++++++++++");

            var quary3 = Nums.Where(num3 => num3 > 5 && num3 % 3 != 0).Select(num3 => num3 * 3).ToList();

            foreach (var item in quary3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Q3+++++++++++++++++++++++++++");



            Console.WriteLine("Q4+++++++++++++++++++++++++++");
            List<string> City = new List<string> {"Rishon","Batyam","Holon","Ranana","Ashdod","Yavne","Gan Yavne","Herzeliya"};
            
            Func<string,List<string>, List<string>> Allcitys = (Arim,City) =>
            {
                var quary4 = (from arim in City
                              where arim.Contains(Arim)
                              select arim).ToList();

                return quary4;
            };
            var list1 = Allcitys("",City);
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Q4+++++++++++++++++++++++++++");


            Console.WriteLine("Q5+++++++++++++++++++++++++++");

            

            Func<string, List<string>, List<string>> Allcitys2 = (Arim2, City) =>
            {
                var quary5 = (from arim2 in City
                              where !arim2.Contains(Arim2)
                              select arim2).ToList();

                return quary5;
            };
            var list2 = Allcitys2("R", City);
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Q5+++++++++++++++++++++++++++");


            Console.WriteLine("Q6+++++++++++++++++++++++++++");

            var quary6 = (from arim2 in City
                          where arim2.Contains("Y")
                          select arim2).Take(1);
            foreach (var item in quary6)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Q6+++++++++++++++++++++++++++");


            Console.WriteLine("Q7+++++++++++++++++++++++++++");

            var quary7 = (from arim2 in City
                          orderby arim2 descending
                          select arim2).Take(3);
            foreach (var item in quary7)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Q7+++++++++++++++++++++++++++");








            Console.WriteLine("Q8+++++++++++++++++++++++++++");

            List<City2> City3 = new List<City2>();

            City3.Add(new City2 { Id = 1, Name = "Rishon Lezzion", NumberOfPopulation = 40000, CityOrSettlement = "City"});
            City3.Add(new City2 { Id = 2, Name = "Yavne", NumberOfPopulation = 15000 , CityOrSettlement = "Settlement" });
            City3.Add(new City2 { Id = 3, Name = "Nes Ziona", NumberOfPopulation = 10000, CityOrSettlement = "Settlement" });
            City3.Add(new City2 { Id = 4, Name = "Holon", NumberOfPopulation = 30000, CityOrSettlement = "City" });

            var query8 = City3.Where(city => city.NumberOfPopulation > 25000).Select(city1 => city1.ToString()).ToList();
            foreach (var item in query8)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Q8+++++++++++++++++++++++++++");



            Console.WriteLine("Q9+++++++++++++++++++++++++++");

            var query9 = City3.Where(city => city.NumberOfPopulation > 25000).Select(city1 => city1.Name).ToList();
            foreach (var item in query9)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Q9+++++++++++++++++++++++++++");



            Console.WriteLine("Q10+++++++++++++++++++++++++++");

            var query10 = City3.Select(city5 => new { city5.Name, city5.CityOrSettlement }).ToList();

            foreach (var item in query10)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Q10+++++++++++++++++++++++++++");










        }
    }
}
