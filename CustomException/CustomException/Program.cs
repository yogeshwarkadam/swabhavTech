﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            throw new YogeshwarException();
            throw new YogeshwarException("yogi");
            Console.ReadKey();
        }
    }
}
