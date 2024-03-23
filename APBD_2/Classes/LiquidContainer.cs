using APBD_2.Interfaces;

namespace APBD_2.Classes;
public enum LiquidType
{
    Dangerous,
    Safe
}

public class LiquidContainer : Container, IHazardNotifier
{
    
    public LiquidType LiquidType { get; set; }

    public LiquidContainer(double height, double tareWeight, double depth, double maxLoadWeight, string containerType, LiquidType liquidType) : base(height, tareWeight, depth, maxLoadWeight, containerType)
    {
        LiquidType = liquidType;
    }

    public override void LoadContainer(double mass)
    {
        base.LoadContainer(mass);
        if (LiquidType == LiquidType.Dangerous && mass > MaxLoadWeight / 2)
        {
            Notify();
        }
        else if (LiquidType == LiquidType.Safe && mass > MaxLoadWeight * 0.9)
        {
            Notify();
        }
    }

    public void Notify()
    {
        Console.WriteLine($"Container {SerialNumber}: attempting to perform a dangerous operation");
    }
}