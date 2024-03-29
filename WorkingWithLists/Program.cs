﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using static System.Console;

namespace WorkingWithLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var cities = new List<string>();
            cities.Add("London");
            cities.Add("Paris");
            cities.Add("Milan");
            cities.Add("Moscow");

            WriteLine("Initial list");
            foreach (var city in cities)
            {
                WriteLine($" {city}");
            }

            WriteLine($"The first city is {cities[0]}");
            WriteLine($"The last city is {cities[cities.Count - 1]}");

            cities.Insert(0, "Sydney");
            WriteLine("After inserting Sydney at index 0");
            foreach (string city in cities)
            {
                WriteLine($" {city}");
            }

            cities.RemoveAt(1);
            cities.Remove("Milan");
            WriteLine("After removing two cities");
            foreach (string city in cities)
            {
                WriteLine($" {city}");
            }


            WriteLine(new string('#', 50));

            var immutableCities = cities.ToImmutableList();
            var newList = immutableCities.Add("Rio");
            Write("Immutable cities : ");
            foreach (string city in immutableCities)
            {
                Write($" {city}");
            }
            WriteLine();
            Write("New cities : ");
            foreach (string city in newList)
            {
                Write($" {city}");
            }
            WriteLine();
        }
    }
}
