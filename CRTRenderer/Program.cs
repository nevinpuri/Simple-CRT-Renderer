using System;
using System.IO;
using System.Threading;

namespace CRTRenderer
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Title = "Simple CRT-Like Renderer - By Nevin";
            Console.SetWindowSize(65, 25);
            Random height = new Random();
            Random width = new Random();
            Console.WriteLine("Enter in the renderWidth");              // get all the inputs
            int renderWidth = Convert.ToInt32(Console.ReadLine());      // and all things like that
            Console.WriteLine("Enter in the renderHeight");
            int renderHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter in the randomCount");
            int randomCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter in the delayCount");
            int delayCount = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(@"
Simple CRT-Like Renderer - By Nevin
renderWidth = {0}
renderHeight = {1}
randomCount = {2}
delayCount = {3}", renderWidth, renderHeight, randomCount, delayCount);
            Thread.Sleep(2000);
            Console.Clear();
            while(true)
            {
                for (int max = 0; max < renderHeight; max++)
                {
                    for (int i = 0; i < randomCount; i++)
                    {
                        Console.SetCursorPosition(width.Next(1, 50), max);
                        Console.WriteLine("█");
                        ClearCurrentConsoleLine();
                        Thread.Sleep(delayCount);
                    }
                }
            }
        }

        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}
