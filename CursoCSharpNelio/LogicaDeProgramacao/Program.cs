﻿using System;
using System.Globalization;

namespace LogicaDeProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {
            DataOutput dataOutput = new DataOutput();
            dataOutput.Exercicio();
            Console.WriteLine("----------------------------FIM EX1----------------------");
            DataInput dataInput = new DataInput();
            dataInput.Exercicio();
            Console.WriteLine("----------------------------FIM EX2----------------------");
        }
    }
}
