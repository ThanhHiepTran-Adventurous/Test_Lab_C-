
using AutomobileLibraryDatabaseFirst.Models;

namespace AutomobileLibraryDatabaseFirst;

     public class Program
     {
        public static void Main()
        {
            //Create a DbContext object
            MyStockEFContext myStock = new MyStockEFContext();
            //print all stock
            var cars = from c in myStock.Cars
                       select new { c.CarId, c.CarName, c.Manufacturer, c.Price, c.ReleaseYear };
            foreach (var c in cars)
            {
                Console.WriteLine($"Car ID: {c.CarId}, Car Name: {c.CarName}, Manufacturer: {c.Manufacturer}, Price: {c.Price}, Realease Year: {c.ReleaseYear}");
            }
            Console.WriteLine("----------------------------------------------------------------------");
            Console.ReadLine();

        }
    }
