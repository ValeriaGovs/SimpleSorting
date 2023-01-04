using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSorting
{
    public class Sorting
    {

        public  void ShellSort(int[] mass)
        {


            int i, j, step;
            int tmp;
            int n = mass.Length;
            for (step = n / 2; step > 0; step /= 2)
                for (i = step; i < n; i++)
                {
                    tmp = mass[i];
                    for (j = i; j >= step; j -= step)
                    {
                        if (tmp < mass[j - step])
                            mass[j] = mass[j - step];
                        else
                            break;
                    }
                    mass[j] = tmp;
                }


            //printMass(mass);

        }

        public  void InsertionSort(int[] mass)
        {



            for (int i = 0; i < mass.Length - 1; i++)
            {
                int n_min = i + 1;

                for (int j = i; j >= 0; j--)
                {

                    if (mass[j] <= mass[n_min])
                    {
                        break;
                    }

                    var k = mass[n_min];
                    mass[n_min] = mass[j];
                    mass[j] = k;
                    n_min = j;
                }
            }

            //printMass(mass);
        }

        public  void InsertionSortImproved(int[] mass)
        {


            for (int i = 0; i < mass.Length - 1; i++)
            {
                int n_min = i + 1;
                var inserted = mass[n_min];

                for (int j = i; j >= 0 && mass[j] > inserted; j--) 
                {

                    mass[j + 1] = mass[j];
                    n_min = j;
                }

                if (mass[n_min] != inserted)
                {
                    mass[n_min] = inserted;
                }
            }


           // printMass(mass);
        }



        public  void BubbleSort(int[] mass)
        {
            for (int j = 0; j < mass.Length; j++)
            {
                for (int i = 0; i < mass.Length; i++)
                {
                    if (i == 0)
                    { }
                    else if (mass[i] < mass[i - 1])
                    {
                        var k = mass[i];
                        mass[i] = mass[i - 1];
                        mass[i - 1] = k;
                    }
                }
            }



            //printMass(mass);
        }


        private static void printMass(int[] mass)
        {
            foreach (int i in mass)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine(" ");
        }

    }
}
