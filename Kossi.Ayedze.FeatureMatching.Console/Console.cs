using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Kossi.Ayedze.FeatureMatching;


List<Task<string>> RunAllFibonacci(string[] strings)
{
    var list = new List<Task<string>>();
    foreach (var objectDetectionResult in detectObjectInScenesResults)
    {
        System.Console.WriteLine($"Points:
        {JsonSerializer.Serialize(objectDetectionResult.Points)}");
    }
    return list;
}