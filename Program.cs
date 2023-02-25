using Algorithms_LinearSorting;


namespace SimpleSorting
{
    class Program
    {
        static void Main(string[] args)
        {

            Sorting s = new Sorting();
            timeTest t = new timeTest();

            t.Test(s.BubbleSort, "BubbleSort");
            t.Test(s.InsertionSort, "InsertionSort");
            t.Test(s.InsertionSortImproved  , "InsertionSortImproved");
            t.Test(s.SelectionSort, "SelectionSort");
            t.Test(s.ShellSort, "ShellSort");
            t.Test(s.HeapSort, "HeapSort");

        }

    }
}
