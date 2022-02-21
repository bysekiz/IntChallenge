using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IntChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            var threadList = new List<Thread>();
            try
            {
                while (true)
                {
                    Thread newThread = new Thread(new ThreadStart(Write), 1024);
                    newThread.Start();
                    threadList.Add(newThread);
                    count++;
                }
            }
            catch (Exception ex)
            {
            }
        }

        public static void Write()
        {
            for (int k = 1; k < 1000; k++)
            {
                Console.WriteLine(k);

            }
            Console.ReadKey();
            
        }
    }
   
}
