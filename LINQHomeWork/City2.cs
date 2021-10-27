using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQHomeWork
{
    class City2
    {
        

        //public City2(int id, string name, int numberOfPopulation)
        //{
        //    Id = id;
        //    Name = name;
        //    NumberOfPopulation = numberOfPopulation;
        //}

        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfPopulation { get; set; }
        public string CityOrSettlement { get; set; }

        public override string ToString()
        {
            return $"Id:{Id} name: {Name} NumberOfPopulation{NumberOfPopulation}";
        }








    }
}
