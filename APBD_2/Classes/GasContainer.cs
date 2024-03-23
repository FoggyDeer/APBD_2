using APBD_2.Interfaces;

namespace APBD_2.Classes;

public class GasContainer : Container, IHazardNotifier
{
    public double Pressure { get; set; }


    public GasContainer(double height, double tareWeight, double depth, double maxLoadWeight, ContainerType containerType, double pressure) : base(height, tareWeight, depth, maxLoadWeight, containerType)
    {
        Pressure = pressure;
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
}