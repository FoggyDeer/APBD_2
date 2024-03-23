using APBD_2.Interfaces;

namespace APBD_2.Classes;

public class GasContainer : Container, IHazardNotifier
{
    public double MaxPressure { get; set; }


    public GasContainer(double height, double tareWeight, double depth, double maxLoadWeight, double maxPressure) : base(height, tareWeight, depth, maxLoadWeight, ContainerType.G)
    {
        MaxPressure = maxPressure;
    }

    public override void EmptyContainer()
    {
        if (Mass > MaxLoadWeight * 0.05)
        {
            Mass = MaxLoadWeight * 0.05;
        }
    }

    public void Notify()
    {
        Console.WriteLine($"Container {SerialNumber}: attempting to perform a dangerous operation");
    }

    public override string ToString()
    {
        return base.ToString() + $"\nMax Pressure: {MaxPressure}";
    }
}