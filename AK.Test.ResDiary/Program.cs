using AK.Test.ResDiary;
using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program : ProgramBase
{
    public static void Main()
    {
        // Resolve the dependencies
        ConfigurationSetup();

        string output = string.Empty;

        //Input array
        int[] inputArray = { 1, 2, 3,4,5};
        int N = 3;

        List<List<int>> dividedArrays = groupArrayDivider.GroupArrayElements(inputArray, N);

        // Join array group string
        foreach (var array in dividedArrays)
        {
            output += "[ " + string.Join(", ", array) + " ],";
        }

        // Print final result
        Console.WriteLine($"[ {output.TrimEnd(',')} ]");
    }
}
