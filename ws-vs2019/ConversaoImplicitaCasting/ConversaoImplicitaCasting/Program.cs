﻿using System;

namespace ConversaoImplicitaCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double a;
            int b;

            a = 5.1;
            b = (int)a;
            */

            int a = 5;
            int b = 2;

            double resultado = (double) a / b; 

            Console.WriteLine(resultado);

        }
    }
}
