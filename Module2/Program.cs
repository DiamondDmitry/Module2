using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;

namespace Module2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Console.WriteLine(circle.CalculateArea(5, 0, 0));
            Rectangle rectangle = new Rectangle();
            Console.WriteLine(rectangle.CalculateArea(6, 5, 0));

            Dog dog = new Dog();
            dog.MakeSound();
            Cat cat = new Cat();
            cat.MakeSound();

            TV tv = new TV();
            tv.TurnOn();
            tv.TurnOff();
            Laptop laptop = new Laptop();
            laptop.TurnOn();
            laptop.TurnOff();

            Bird bird = new Bird();
            bird.Fly();
            Airplane airplane = new Airplane();
            airplane.Fly();



            //FruitStore bestFruits = new FruitStore();
            //string fruit = "Orange";
            //bestFruits.OrderProduct(fruit, 5, "Mexico Orange");
            //Console.WriteLine($"Продукт годен: {bestFruits.IsProductExpried(fruit)}");
            //Console.WriteLine($"Цена продукта: {bestFruits.GetProductPrice(fruit)}");
            //Console.WriteLine($"Страна производитель: {bestFruits.GetProductInfo(fruit)}");

            //LiquorMart liquorMart = new LiquorMart();
            //string drink = "Scotch whisky";
            //Console.WriteLine();
            //liquorMart.OrderProduct(drink, 20, "Blue Label");
            //Console.WriteLine($"Продукт годен: {liquorMart.IsProductExpried(drink)}");
            //Console.WriteLine($"Цена продукта: {liquorMart.GetProductPrice(drink)}");
            //Console.WriteLine($"Страна производитель: {liquorMart.GetProductInfo(drink)}");

            //CheeseStore cheeseStore = new CheeseStore();
            //string cheese = "Chesse gauda";
            ////string cheese = "Dorblue";
            //Console.WriteLine();
            //cheeseStore.OrderProduct(cheese, 20, "European Cheeses");
            //Console.WriteLine($"Продукт годен: {cheeseStore.IsProductExpried(cheese)}");
            //Console.WriteLine($"Цена продукта: {cheeseStore.GetProductPrice(cheese)}");
            //Console.WriteLine($"Страна производитель: {cheeseStore.GetProductInfo(cheese)}");
        }
    }
}
