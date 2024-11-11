using System;
using System.Diagnostics;
using Test_Project;

class MainClass
{
    public static void Main()
    {
        Stopwatch stopwatch = new Stopwatch();
        //List<double> arr = Utilites.GenerateRandomArray(100000);
        //InsertionSort insertionSortObject = new InsertionSort();
        //List<double> arrCopy1 = new List<double>(arr);
        //stopwatch.Start();
        //List<double> insertionSortSortedarr = insertionSortObject.sort(arrCopy1);
        //stopwatch.Stop();
        ////Utilites.printArray(insertionSortSortedarr);
        //Console.WriteLine("Time taken to Insertion sort the array: {0} ms", stopwatch.ElapsedMilliseconds);


        //MergeSort mergeSortObject = new MergeSort();
        //List<double> arrCopy2 = new List<double>(arr);
        //stopwatch.Restart();
        //stopwatch.Start();
        //List<double> mergeSortSortedArr = mergeSortObject.sort(arrCopy2);
        //stopwatch.Stop();
        ////Utilites.printArray(mergeSortSortedArr);
        //Console.WriteLine("Time taken to Merge sort the array: {0} ms", stopwatch.ElapsedMilliseconds);


        //QuickSort quickSortObject = new QuickSort();
        //List<double> arrCopy3 = new List<double>(arr);
        //stopwatch.Restart();
        //stopwatch.Start();
        //List<double> quickSortSortedArr = mergeSortObject.sort(arrCopy3);
        //stopwatch.Stop();
        ////Utilites.printArray(quickSortSortedArr);
        //Console.WriteLine("Time taken to Quick sort the array: {0} ms", stopwatch.ElapsedMilliseconds);

        /*
        var A = Utilites.GenerateMatrix(128);
        var B = Utilites.GenerateMatrix(128);
        StrassenMatrixMultiplication strassen = new StrassenMatrixMultiplication();
        //Console.WriteLine("First Input Matrix");
        //Utilites.PrintMatrix(A);
        //Console.WriteLine("Second Input Matrix");
        //Utilites.PrintMatrix(B);

        stopwatch.Restart();
        stopwatch.Start();
        var strassenMatrixResult = strassen.Multiply(A, B);
        stopwatch.Stop();
        //Console.WriteLine("Result Matrix");
        //Utilites.PrintMatrix(strassenMatrixResult);
        Console.WriteLine("Time taken to Multiply matices using Strassen: {0} ms", stopwatch.ElapsedMilliseconds);





        BruteForceMatrixMultiplication bruteForceMatrixMultiplication = new BruteForceMatrixMultiplication();
        stopwatch.Restart();
        stopwatch.Start();
        var bruteForceMatrixResult = bruteForceMatrixMultiplication.Multiply(A, B);
        stopwatch.Stop();
        //Console.WriteLine("Result Matrix");
        //Utilites.PrintMatrix(bruteForceMatrixResult);
        Console.WriteLine("Time taken to Multiply matices using brute force: {0} ms", stopwatch.ElapsedMilliseconds);
        */

        
        List<double> arr = Utilites.GenerateRandomArray(100000);
        MaxSubarraySum maxSubarrayProblem = new MaxSubarraySum();
        stopwatch.Start();
        double sum = maxSubarrayProblem.maxSubarraySum(arr,0,arr.Count - 1);
        stopwatch.Stop();
        //Utilites.printArray(insertionSortSortedarr);
        Console.WriteLine("Time taken to max sum array problem: {0} ms", stopwatch.ElapsedMilliseconds);

    }
}
