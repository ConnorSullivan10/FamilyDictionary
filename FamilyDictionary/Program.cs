using System;
using System.Collections.Generic;
using System.Linq;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Erin" }, { "age", "19" } });
            myFamily.Add("brother1", new Dictionary<string, string>() { { "name", "Sean" }, { "age", "26" } });
            myFamily.Add("brother2", new Dictionary<string, string>() { { "name", "Ryan" }, { "age", "30" } });
            myFamily.Add("mother", new Dictionary<string, string>() { { "name", "Gail" }, { "age", "59" } });
            myFamily.Add("father", new Dictionary<string, string>() { { "name", "Michael" }, { "age", "59" } });

            // below destructuring basically states put the key into the relationship, and put the value into the properties variable
            foreach (var (relationship, properties) in myFamily)
            {
                 Console.WriteLine($"{properties["name"]} is my {relationship} and {properties["age"]} is years old");
            }
        }
    }
}
