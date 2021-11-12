﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionCallStackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                M1();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("End of Game");
            Console.ReadLine();
        }
        public static void M1()
        {
            Console.WriteLine("inside m1");
            M2();
        }
        public static void M2()
        {
            Console.WriteLine("inside m2");
            M3();
        }
        public static void M3()
        {
            Console.WriteLine("inside m3");
            throw new Exception("something went wrong in M3");
           
        }

    }
}
