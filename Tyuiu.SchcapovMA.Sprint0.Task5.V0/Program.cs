﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SchcapovMA.Sprint0.Task5.V0.Lib;

namespace Tyuiu.SchcapovMA.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пример линейной структуры
            Console.WriteLine("A + B = " + DataService.Addition(1, 5));
            Console.WriteLine("A - B = " + DataService.Subtraction(25, 5));
            Console.WriteLine("A * B = " + DataService.Multiplication(10, 10));
            //Пример развлетляющийся структуры находится в библиотеке классов и методов Division
            Console.WriteLine("A / B = " + DataService.Division(9, 3));
            Console.ReadKey();
        }
    }
}
