using APBD_2.Interfaces;

namespace APBD_2.Classes;
public enum LiquidType
{
    Dangerous,
    Safe
}

public class LiquidContainer : Container, IHazardNotifier
{
    
    public LiquidType? LiquidType { get; set; }

    public LiquidContainer(double height, double tareWeight, double depth, double maxLoadWeight, ContainerType containerType, LiquidType liquidType) : base(height, tareWeight, depth, maxLoadWeight, containerType)
    {
        LiquidType = liquidType;
    }

    public override void LoadContainer(double mass)
    {
        base.LoadContainer(mass);
        if (LiquidType == Classes.LiquidType.Dangerous && Mass > MaxLoadWeight / 2)
        {
            Notify();
        }
        else if (LiquidType == Classes.LiquidType.Safe && Mass > MaxLoadWeight * 0.9)
        {
            Notify();
        }
    }

    public override void EmptyContainer()
    {
        base.EmptyContainer();
        LiquidType = null;
    }

    public void Notify()
    {
        Console.WriteLine($"Container {SerialNumber}: attempting to perform a dangerous operation");
    }
}