using System;
using System.Diagnostics;

namespace SimpleSorting
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 10;


            for (int i =0; i<6; i++)
            {
                n = n * 10;

                TimeTest(n);
            }


            Console.WriteLine("");
            //Console.ReadLine();


        }

        private static void TimeTest(int n)
        {
            Random r = new Random();
            var unsort = new int[n];
            for (int i = 0; i < n; i++)
            {
                unsort[i] = r.Next(0, n);
            }

            /*
            Console.WriteLine($"Было:");
            foreach (int i in unsort)
            {
                Console.Write($"{i} ");
            }
            */



            //BubbleSort(unsort);
            InsertionSort(unsort);
            //InsertionSortImproved(unsort);
            //ShellSort(unsort);
            Console.WriteLine($"");
        }

        private static void ShellSort(int[] mass)
        {

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

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
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

            Console.WriteLine("RunTime {0} {1} = {2}", "ShellSort", mass.Length, elapsedTime);

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

        private static void InsertionSort( int[] mass)
        {

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < mass.Length-1; i++)
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
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

            Console.WriteLine("RunTime {0} {1} = {2}", "InsertionSort", mass.Length, elapsedTime);


            //printMass(mass);
        }

        private static void InsertionSortImproved( int[] mass)
        {

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < mass.Length - 1; i++)
            {
                int n_min = i + 1;
                var inserted = mass[n_min];

                for (int j = i; j >= 0; j--)
                {

                    if (mass[j] <= inserted)
                    {
                        break;
                    }

                    mass[j+1] = mass[j];
                    n_min = j;
                }
                 
                if (mass[n_min] != inserted)
                {
                    mass[n_min] = inserted;
                }
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

            Console.WriteLine("RunTime {0} {1} = {2}", "InsertionSortImproved", mass.Length, elapsedTime);


            //printMass(mass);
        }



        private static void BubbleSort( int[] mass)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            for ( int j=0; j< mass.Length; j++)
            {
                for (int i = 0; i < mass.Length; i++)
                {
                    if (i == 0)
                    { }
                    else if  ( mass[i] < mass[i - 1])
                    {
                        var k = mass[i];
                        mass[i] = mass[i - 1];
                        mass[i - 1] = k;
                    }
                }
            }

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

            Console.WriteLine("RunTime {0} {1}  = {2}", "BubbleSort", mass.Length, elapsedTime);


            //printMass(mass);
        }
    }
}
