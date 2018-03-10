﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energy = int.Parse(Console.ReadLine());
            var sugar = int.Parse(Console.ReadLine());

            var calories = (double)energy * volume / 100;
            var sugars = (double)volume * sugar / 100;


            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{calories}kcal, {sugars}g sugars");
        }
    }
}