using System;
using System.Diagnostics;
using Test_Project;

class MainClass
{
    public static void Main()
    {
        List<double> arr = Utilites.GenerateRandomArray(100000);
        Stopwatch stopwatch = new Stopwatch();
        InsertionSort insertionSortObject = new InsertionSort();
        List<double> arrCopy1 = new List<double>(arr);
        stopwatch.Start();
        List<double> insertionSortSortedarr = insertionSortObject.sort(arrCopy1);
        stopwatch.Stop();
        //Utilites.printArray(insertionSortSortedarr);
        Console.WriteLine("Time taken to Insertion sort the array: {0} ms", stopwatch.ElapsedMilliseconds);


        MergeSort mergeSortObject = new MergeSort();
        List<double> arrCopy2 = new List<double>(arr);
        stopwatch.Restart();
        stopwatch.Start();
        List<double> mergeSortSortedArr = mergeSortObject.sort(arrCopy2);
        stopwatch.Stop();
        //Utilites.printArray(mergeSortSortedArr);
        Console.WriteLine("Time taken to Merge sort the array: {0} ms", stopwatch.ElapsedMilliseconds);

    }
}
