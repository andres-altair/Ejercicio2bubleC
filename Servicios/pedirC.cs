using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2bubleC.Servicios
    {
        internal class pedirC : pedirI
        {
            public double pedir(int k)
            {
                if (k = 0) { Console.WriteLine("escribe un numero double"); }
                else (k = 1) { Console.WriteLine("escribe un numero entero"); }
                double num = Convert.ToDouble(Console.ReadLine());  
                return num;
                
            
            
            
            
                //Console.WriteLine("escribe un numero entero");
                //double a = Convert.ToInt32(Console.ReadLine());
                //return a;
            }
        }
    }
