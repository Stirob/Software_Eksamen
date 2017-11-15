using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Eksamen

{
    class Customer
    {
        public static void ThreadCustomer(string Name)
        {
            while (Bazzar.Finished == false)
            {
                while (Bazzar.ItemAvailable == true)
                {
                    Bazzar.SetItemAvailable(false);
                    Console.WriteLine(Name + " bought Item #" + Bazzar.GetItemNumber());
                }
                Thread.Sleep(0);
            }
        }

        public static void CreateCustomer()
        {
            string[] Names = new string[] { "Jaina", "Uther", "Malfurian", "Gul'dan", "Valeera", "Anduin", "Rexxar", "Thral", "Garrosh" };
            Random Rnd = new Random();
            string Name = Names[Rnd.Next(0, 8)];
            Thread t = new Thread(new ThreadStart(ThreadCustomer));
            t.Start(Name);
        }
    }
}
