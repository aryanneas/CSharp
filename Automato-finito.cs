﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream infile;
            int tam;
            char x;          

            infile = new System.IO.FileStream("Teste.txt",
                                               System.IO.FileMode.Open,
                                               System.IO.FileAccess.Read);

            tam = (int)infile.Length;
            for (int i = 0; i < tam; ++i)
            {
                x = (char)infile.ReadByte();
                if (char.IsDigit(x))
                {
                    do
                    {
                        Console.Write(x);
                        x = (char)infile.ReadByte();
                    } while ((char.IsDigit(x)));
                    Console.WriteLine();                   
                }

                
            }
            Console.ReadKey();
        }
    }
}
