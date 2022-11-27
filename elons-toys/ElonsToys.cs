using System;

class RemoteControlCar
{
    private int metersDriven = 0;
    private int batteryPercentage = 100;
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {metersDriven} meters";
    }

    public string BatteryDisplay()
    {
        return batteryPercentage == 0 ? "Battery empty" : $"Battery at {batteryPercentage}%";
    }

    public void Drive()
    {
        if (batteryPercentage == 0) return;
        metersDriven += 20;
        batteryPercentage--;
    }
}
