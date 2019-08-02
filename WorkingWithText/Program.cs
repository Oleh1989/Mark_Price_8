using System;
using static System.Console;

namespace WorkingWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = "London";
            WriteLine($"{city} is {city.Length} characters long.");
            WriteLine($"First char is {city[0]} and third char is {city[3]}");

            WriteLine(new string('#', 50));

            string cities = "Paris,Berlin,Madrid,New York";
            string[] citiesArray = cities.Split(',');
            foreach (string i in citiesArray)
            {
                WriteLine(i);
            }

            WriteLine(new string('#', 50));

            string fullName = "Alan Jones";
            int indexOfTheSpace = fullName.IndexOf(' ');
            string firstName = fullName.Substring(0, indexOfTheSpace);
            string lastName = fullName.Substring(indexOfTheSpace + 1);
            WriteLine($"First name: {firstName}\nLastName: {lastName}");

            lastName = fullName.Substring(indexOfTheSpace + 1);
            firstName = fullName.Substring(0, indexOfTheSpace);
            WriteLine($"First name: {firstName}\nLastName: {lastName}");
        }
    }
}
