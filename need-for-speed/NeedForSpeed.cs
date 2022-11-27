using System;
using System.Runtime.CompilerServices;

class RemoteControlCar
{
    public int speed;
    private int batteryDrain;
    private int _metersDriven;
    private int _batteryPercentage = 100;
    
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        return (_batteryPercentage - batteryDrain) < 0;
    }

    public int DistanceDriven()
    {
        return _metersDriven;
    }

    public void Drive()
    {
        if (BatteryDrained()) return;
        _metersDriven += speed;
        _batteryPercentage -= batteryDrain;
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private int distance;

    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        var drivenDistance = 0;

        do
        {
            drivenDistance += car.speed;
            car.Drive();
        } while (!car.BatteryDrained());

        return drivenDistance >= distance;
    }
}
