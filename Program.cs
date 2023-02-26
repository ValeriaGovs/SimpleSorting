using Algorithms_LinearSorting;


namespace SimpleSorting
{
    class Program
    {
        static void Main(string[] args)
        {

            Sorting s = new Sorting();

            timeTest t = new timeTest();
            int variant = 1;

            t.Test(s.BubbleSort, "BubbleSort", variant);
            t.Test(s.InsertionSort, "InsertionSort", variant);
            t.Test(s.InsertionSortImproved  , "InsertionSortImproved", variant);
            t.Test(s.SelectionSort, "SelectionSort", variant);

            t.Test(s.ShellSort, "ShellSort_2", 2);
            t.Test(s.ShellSort, "ShellSort_3", 3);
            t.Test(s.ShellSort, "ShellSort_4", 4);

            t.Test(s.HeapSort, "HeapSort", variant);

        }

    }
}
