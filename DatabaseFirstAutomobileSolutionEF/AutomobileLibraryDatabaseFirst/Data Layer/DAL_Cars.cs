using AutomobileLibraryDatabaseFirst.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AutomobileLibraryDatabaseFirst.Data_Layer
{
    public class DAL_Cars
    {
        MyStockEFContext MyStockEF = new MyStockEFContext();
         
        public static async Task InsertProduct()
        {
            using(var context = new MyStockEFContext())
            {
                await context.Cars.AddAsync(new Car
                {
                    CarName = "tete",
                    Manufacturer = "Xe b"
                });
                await context.AddAsync(new Car()
                {
                    CarName = "hú hú",
                    Manufacturer = "Xe b"
                });
                //
                int rows = await context.SaveChangesAsync();
                Console.WriteLine($"Đã lưu {rows} sản phẩm");
            }
        }
    }
}
