public class GD1_CH5to6
{
    public static long NthFibonacci(long p)
    {
        if (p <= 0) { return -1; }
        if (p == 1) { return 0; }
        long[] nums = new long[p];
        nums[0] = 0;
        nums[1] = 1;
        for (int i = 2; i < p; i++)
        {
            nums[i] = nums[i - 1] + nums[i - 2];
        }
        return nums[nums.Length - 1];

    }

    public static bool IsLeapYear(int year)
    {
        return year % 4 == 0 && (year % 100 == 0 && year % 400 == 0);
    }

    public static int DaysInMonth(int month, int year)
    {
        if (month == 2)
        {
            if (IsLeapYear(year))
            {
                return 29;
            } else
            {
                return 28;
            }
        }

        if (month <= 6)
        {
            return month % 2 == 0? 30: 31;
        } else
        {
            return month % 2 == 0 ? 30 : 31;
        }
        
    }

    public static int DaysBetween(int m1, int d1, int y1, int m2, int d2, int y2)
    {
        int total = 0;

        while (y1 < y2)
        {
            y2 -= 1;
            total += 365;
        }

        
    }
}