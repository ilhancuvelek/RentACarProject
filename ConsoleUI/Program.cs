﻿using Business.Concrete;
using DataAccess.Concrete.Entityframework;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.BrandName+" "+car.ColorName);
            }
        }
    }
}
