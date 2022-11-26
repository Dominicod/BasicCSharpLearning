using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed == 0)
            return 0;
        if (speed >= 1 & speed <= 4)
            return 1;
        if (speed >= 5 & speed <= 8)
            return 0.90;

        return speed == 9 ? 0.80 : 0.77;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return speed * 221 * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)ProductionRatePerHour(speed) / 60;
    }
}
