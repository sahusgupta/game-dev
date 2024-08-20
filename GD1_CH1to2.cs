// See https://aka.ms/new-console-template for more information
public class GD1_CH1to2
{
    public static int TimeDifference (int start, int end, out int hrs, out int mins){
        int startHr = start / 100;
        int startMin = start % 100;
        int endHr = end / 100;
        int endMin = end % 100;
        hrs = endHr - startHr;
        mins = endMin - startMin;

        if (mins < 0)
        {
            mins += 60;
            hrs -= 1;
        }
        return 0;
    }

    public static int TotalServings( int cc, int eightIn, int sheets)
    {
        return cc + (eightIn * 18) + (sheets * 58);
    }
}
