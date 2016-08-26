using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            InitalizeInventory(inventory);

            //Searches
            MobilePhone searchMobile = new MobilePhone
            {
                OperatingSystem = "ios",
                Manufacture = "Apple",
                ModelName = "iphone 5s",
            };


            List<MobilePhone> collection=inventory.Search(searchMobile);

            foreach (var item in collection)
            {
                Console.WriteLine(item.ModelName);
                Console.WriteLine(item.Price);
                Console.WriteLine(item.OperatingSystem);
            }

            Console.ReadLine();
        }


        static void InitalizeInventory(Inventory inventory)
        {
            MobilePhone phone = new MobilePhone();
            phone.Color = "White";
            phone.Manufacture = "Apple";
            phone.ModelName = "IPhone 5s";
            phone.OperatingSystem = "IOS";
            phone.Price = 20000;
            phone.SerialNumber = 1;
            phone.IMEINumber = 121212;
            inventory.SavePhone(phone);

        }
    }
}
