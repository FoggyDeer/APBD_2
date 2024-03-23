using APBD_2.Exceptions;

namespace APBD_2.Classes;

public class RefrigeratedContainer : Container
{
    public static Dictionary<string, float> Products = new()
    {
        {"Bananas", 13.3f},
        {"Chocolate", 18},
        {"Fish", 2},
        {"Meat", -15},
        {"Ice cream", -18},
        {"Frozen pizza", -30},
        {"Cheese", 7.2f},
        {"Sausages", 5},
        {"Butter", 20.5f},
        {"Eggs", 19}
    };

    public string? ProductType { get; set; }
    public float Temperature { get; set; }
    
    public RefrigeratedContainer(double height, double tareWeight, double depth, double maxLoadWeight, float temperature) : base(height, tareWeight, depth, maxLoadWeight, ContainerType.C)
    {
        Temperature = temperature;
    }

    public void LoadContainer(string productType, double mass)
    {
        if (Products[productType] == null)
            throw new NoSuchProductException("There is no such product in list!");
        if (productType != ProductType)
            throw new NotSameProductLoadedException("Trying to load different product!");
        if (Temperature > Products[productType])
            throw new WrongTemperatureException("Trying to load product with lower required temperature!");
        
        base.LoadContainer(mass);
        ProductType = productType;
    }

    public override void EmptyContainer()
    {
        base.EmptyContainer();
        ProductType = null;
    }

    public override string ToString()
    {
        return base.ToString() + $"\nTemperature: {Temperature}, Product Type: {(ProductType == null ? "Is empty" : ProductType)}";
    }
}