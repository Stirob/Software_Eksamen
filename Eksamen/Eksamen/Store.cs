using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Eksamen
{
    class Store
    {
        public static void ThreadStore()
        {
            while (Bazzar.Finished == false)
            {
                for (int i = 1; i <= 25; i++)
                {
                    while (Bazzar.GetItemAvailable() == true)
                    {
                        Thread.Sleep(0);
                    }

                    Bazzar.SetAvailable(true);
                    Bazzar.SetItemNumber(i);
                    Console.WriteLine("Store put item #" + i + " up for sale");
                    Thread.Sleep(2000);
                }
                Bazzar.Finished(true);
            }
        }

        public static void CreateStore()
        {
            Thread t = new Thread(new ThreadStart(ThreadStore));
            t.Start();
        }
    }
}
