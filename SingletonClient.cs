using Patterns;
using Patterns.Create_Factory;
using Patterns.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Clients
{
    public static class SingletonClient
    {
        public static void RunDemo()
        {
            //var configs = GlobalConfig.GetInstance();
            //Console.WriteLine("Number of photos: {0}", configs.MaxNumberOfPhotos);
            //Console.WriteLine("Photo path: {0}", configs.PhotoDomainName);

            for(int i= 0; i< 20; i++)
            {
                var thread = new Thread(ShowConfigInfo);
                thread.Start();
                Thread.Sleep(1000);
            }

            Console.ReadLine();
        }

        private static void ShowConfigInfo()
        {
            var configs = GlobalConfig.GetInstance();                            
            Console.Write(configs.CreatedTime);
            Console.Write("\n");
        }
    }
}
