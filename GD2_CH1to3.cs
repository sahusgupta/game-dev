using System;
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

    public static (string[], string[], float, float) EvaluateScore ((string, int)[] studs)
    {
        string[] names = new string[studs.Length];
        for (int i = 0; i < studs.Length; i++) {
            names[i] = studs[i].Item1;
        }
        float passed = 0;
        float total = 0;
        List<string> pd = new List<string>();
        foreach ((string, float) c in studs) {
            passed += c.Item2 >= 3 ? 1 : 0;
            total += c.Item2;
        }
        for (int i = 0; i < studs.Length; i++) {
            if (studs[i].Item2 >= 3) { pd.Add(studs[i].Item1); }
        }
        (string[], string[], float, float) ret = (names, names, passed / studs.Length, total / studs.Length);
        return ret;
    }

    public static int Gather(char[] farm)
    {
        int home = farm.IndexOf('H');
        int curr = home;
        int steps = 0;
        while (curr > 0)
        {
            curr -= 1;
            steps += 1;
            if (farm[curr] == 'F')
            {
                home =
            }
        }
        {

        }
    }
}
