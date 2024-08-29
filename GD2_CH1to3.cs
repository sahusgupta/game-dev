using System;
using System.ComponentModel;
/*
 */
public class GD2_CH1to3
{
    public static (float, float) Totals(float[] c)
    {
        float sub = 0;
        foreach (float x in c)
        {
            sub += x;
        }
        (float, float) totals = (sub, sub * 1.0825f);
        return totals;

    }

    public static (string[], string[], float, float) EvaluateScores((string, int)[] studs)
    {
        string[] names = new string[studs.Length];
        for (int i = 0; i < studs.Length; i++)
        {
            names[i] = studs[i].Item1;
        }
        float passed = 0;
        float total = 0;
        List<string> pd = new List<string>();
        foreach ((string, float) c in studs)
        {
            passed += c.Item2 >= 3 ? 1 : 0;
            total += c.Item2;
        }
        for (int i = 0; i < studs.Length; i++)
        {
            if (studs[i].Item2 >= 3) { pd.Add(studs[i].Item1); }
        }
        (string[], string[], float, float) ret = (names, pd.ToArray(), passed / studs.Length, total / studs.Length);
        return ret;
    }

    public static int Gather(char[] farm)
    {
        int home = Array.IndexOf(farm, 'H');
        List<int> food = new List<int>();
        int total = 0;

        for (int i = 0; i < farm.Length; i++) { if (farm[i] == 'F') { food.Add(i); } }

        if (food.Count == 0)
        {
            if (farm.Length == 1) { return 0; }
            else
            {
                total += Math.Abs(farm.Length - 1 - home);
                total += Math.Abs(home - 0) * 2;
                return total;
            }
        }
        foreach (int fp in food) { total += Math.Abs(fp - home) * 2; }
        if (food[^1] != farm.Length - 1){ total += (farm.Length - 1 - home) * 2; }
        if (food[0] != 0) { total += (home) * 2;}
        return total;
    }
}