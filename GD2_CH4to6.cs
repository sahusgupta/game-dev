using NUnit.Framework.Internal.Execution;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class GD2_CH4to6
{
    public static bool isPrime(int num)
    {
        if (num <= 1) { return false; }
        if (num == 2) { return true; }
        if (num % 2 == 0) { return false; }
        if (num == 3) { return true; }

        for (int i = 3; i <= Math.Sqrt(num); i += 2)
        {
            if (num % i == 0) { return false; }
        }
        return true;
    }
    public static void RemovePrimes (List<int> numbers)
    {
        List<int> copy = new List<int> ();
        foreach (int item in numbers)
        {
            if (isPrime(item))
            {
                copy.Add(item);
            }
        }
        for (int i = 0; i < copy.Count; i++)
        {
            if (numbers.Contains(copy[i])) { numbers.Remove(copy[i]); }
        }
        Console.WriteLine(string.Join("; ", copy));
        Console.WriteLine(string.Join("; ", numbers));
    }

    public static void FibonacciList(int wanted, out List<long> numbers)
    {
        numbers = new List<long>();
        if (wanted >= 1)
        {
            numbers.Add(0);
        }
        if (wanted >= 2)
        {
            numbers.Add(1);
        }
        for (int i = 2; i < wanted; i++)
        {
            numbers.Add(numbers[i - 2] + numbers[i - 1]);
        }
    }

    public static List<string> MedianScores(ref List<(string, int)> scores)
    {
        scores.Sort((a, b) =>
        {
            int sc = a.Item2.CompareTo(b.Item2);
            return sc != 0 ? sc: a.Item1.CompareTo(b.Item1);
        });

        int med = (scores.Count - 1) / 2;
        int m = scores[med].Item2;
        List<string> students = new List<string>();
        foreach ((string, int) stud in scores)
        {
            if (stud.Item2 == m)
            {
                students.Add(stud.Item1);
            }
        }
        return students;
    }
}