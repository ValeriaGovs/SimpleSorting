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



        public void HeapSort(int[] mass)
        {

            for (int root = mass.Length / 2 - 1; root >= 0; root--)
                heapify(root, mass.Length, mass);

            for (int j = mass.Length - 1; j > 0; j--)
            {
                swap(0, j, mass);
                heapify(0, j, mass);

            }

        }

        private static void heapify(int root, int size, int[] mass) // moveMaxToRoot
        {
            int L = 2 * root + 1;
            int R = 2 * root + 2;
            int X = root;
            if (L < size && mass[L] > mass[X]) X = L;
            if (R < size && mass[R] > mass[X]) X = R;
            if (X == root) return;
            swap(X, root, mass);
            heapify(X, size, mass);
        }



        public  void SelectionSort(int[] mass)
        {


            int indMax = FindMax(mass, mass.Length);
            for (int i = mass.Length - 1; i >= 0; i--)
            {
                swap(indMax, i, mass);
                indMax = FindMax(mass, i);
            }


        }

        private static void swap(int indMax, int i, int[] mass)
        {
            int k = mass[i];
            mass[i] = mass[indMax];
            mass[indMax] = k;
        }

        private static int FindMax(int[] mass, int j)
        {
            int max = 0;
            int ind_max = 0;
            for (int i = 0; i < j; i++)
            {
                if (mass[i] > max)
                {
                    ind_max = i;
                    max = mass[i];
                }
            }
            return ind_max;
        }

    }
}
