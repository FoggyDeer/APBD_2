using APBD_2.Exceptions;

namespace APBD_2.Classes;

public enum ContainerType
{
    L,
    G,
    C
}
public class Container
{
    private static int _id {
        get
        {
            return _id++;
        }
        set
        {
            _id = value;
        }
    }

    static Container()
    {
        _id = 0;
    }

    protected int Id { get; } = _id;

    public double Mass { get; set; }
    public double Height { get; set; }
    public double TareWeight { get; set; }
    public double Depth { get; set; }
    public double MaxLoadWeight { get; set; }
    public string SerialNumber { get; set; }

    public Container(double height, double tareWeight, double depth, double maxLoadWeight, string containerType)
    {
        Mass = 0;
        Height = height;
        TareWeight = tareWeight;
        Depth = depth;
        MaxLoadWeight = maxLoadWeight;
        SerialNumber = $"KON-{containerType}-{Id}";
    }

    public void EmptyContainer()
    {
        this.Mass = 0;
    }

    public virtual void LoadContainer(double mass)
    {
        if (mass > MaxLoadWeight)
        {
            throw new OverfillException("Provided mass is bigger than max load weight!");
        }
        else
        {
            Mass = mass;
        }
    }
}