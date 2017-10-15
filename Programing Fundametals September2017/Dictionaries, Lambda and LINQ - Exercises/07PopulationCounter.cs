using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var data = new Dictionary<string, Dictionary<string, decimal>>();
            while (input != "report")
            {
                var tokens = input.Split('|');
                var city = tokens[0];
                var country = tokens[1];
                var populatin = decimal.Parse(tokens[2]);
                if (!data.ContainsKey(country))
                {
                    data[country] = new Dictionary<string, decimal>();
                }
                if (!data[country].ContainsKey(city))
                {
                    data[country][city] = 0;
                }
                data[country][city] += populatin;


                input = Console.ReadLine();
            }
            var orderedCountries = data
                .OrderByDescending(kvp => kvp.Value.Values.Sum())
                .ToDictionary(x => x.Key,x => x.Value);
            foreach (var population in orderedCountries)
            {
                var country = population.Key;
                var citiesPopulations = population.Value
                    .OrderByDescending(kvp => kvp.Value)
                   .ToDictionary(x => x.Key, x => x.Value);
                var totalPopulation = citiesPopulations.Values.Sum();
                Console.WriteLine($"{country} (total population: {totalPopulation})");
                foreach (var cityPopulation in citiesPopulations)
                {
                   
                    Console.WriteLine($"=>{cityPopulation.Key}: {cityPopulation.Value}");
                }
            }
        }
    }
}
