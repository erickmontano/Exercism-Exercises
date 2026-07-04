class RemoteControlCar
{
    private int totalDistance;
    private int batteryCharge;

    public RemoteControlCar()
    {
        TotalDistance = 0;
        BatteryCharge = 100;
    }
    private int TotalDistance
    {
        get { return totalDistance; }
        set { totalDistance = value; }
    }
    private int BatteryCharge
    {
        get { return batteryCharge; }
        set { batteryCharge = value; }
    }

    public static RemoteControlCar Buy()
    {
        return new();
    }

    public string DistanceDisplay() => $"Driven {TotalDistance} meters";

    public string BatteryDisplay() => (batteryCharge != 0) ? $"Battery at {BatteryCharge}%" : "Battery empty";

    public void Drive()
    {
        if (batteryCharge > 0)
        {
            TotalDistance += 20;
            BatteryCharge -= 1;
        }
    }
}
