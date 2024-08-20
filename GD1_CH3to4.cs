public class GD1_CH3to4
{
    public static float Sale(ref float cost1, ref float cost2, ref float cost3)
    {
        if (Math.Min(cost1, cost2) >= cost3)
        {
            cost3 /= 2;
        }
        else if (Math.Min(cost3, cost2) >= cost1)
        {
            cost1 /= 2;
        }
        else if (Math.Min(cost1, cost3) >= cost2)
        {
            cost2 /= 2;
        }
        return cost1 + cost2 + cost3;
    }

    public static int NumberOfFactors (int number)
    {
        int factors = 0;
        for (int i = 1; i <= number; i++)
        {
            factors += number % i == 0 ? 1 : 0;
        }
        return factors;
    }
}