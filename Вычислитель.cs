using System;
using static System.Console;
using System.Threading;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace b
{
  internal class Program
 {
    private static void Main(string[] args)
    {
     
            double minNumber = 0;
            double maxNumber = 0;
            double oldMassiveMax = 0;
            double oldMassiveMin = 0;
            WriteLine("Установите размер массива.");
            int size = Convert.ToInt32(ReadLine());
            double[] massive = new double[size];

            for (int i = 0; i < massive.Length; i++)
            {
                Random rnd = new Random();
                massive[i] = rnd.NextDouble() * (1000 + 1000) - 1000;
            }

            for (int i = 0; i < massive.Length; i++)
            {   
                WriteLine(massive[i]);
                WriteLine();
                if ((i + 1 != massive.Length)  && (massive[i] > massive[i + 1]))
                {
                    Thread.Sleep(400);
                     maxNumber = massive[i];                    
                     if (oldMassiveMax < maxNumber)
                     {
                        oldMassiveMax = maxNumber;
                     }
                     
                }
                else if ((i + 1 != massive.Length)  && (massive[i] < massive[i + 1]))
                {
                    Thread.Sleep(400);
                     maxNumber = massive[i + 1];
                     if (oldMassiveMax < maxNumber)
                     {
                        oldMassiveMax = maxNumber;
                     }
                }
                if ((i + 1 != massive.Length)  && (massive[i] < massive[i + 1]))
                {
                    Thread.Sleep(400);
                     minNumber = massive[i];
                     if (oldMassiveMin > minNumber)
                     {
                        oldMassiveMin = minNumber;
                     }
                }
                else if ((i + 1 != massive.Length)  && (massive[i] > massive[i + 1]))
                {
                    Thread.Sleep(400);
                     minNumber = massive[i + 1];
                     if (oldMassiveMin > minNumber)
                     {
                        oldMassiveMin = minNumber;
                     }
                }

                if (i == massive.Length - 1)
                {
                    WriteLine($"Минимальное число это {oldMassiveMin}, а максимальное число это {oldMassiveMax}");
                }
            }
        }
    } 
        
       
      
        
        
    
}
 