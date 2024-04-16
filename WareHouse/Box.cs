using Warehouse.Abstract;

namespace Warehouse.WareHouse;

public class Box : Container
{
    public Box(int id, double width, double depth, double height, double weight, DateOnly expiryDate)
        : base(id, width, depth, height)
    {
        Weight = weight;
        Volume = width * depth * height;
        ExpiryDate = expiryDate;
    }

    public override double Weight { get; }
    public override double Volume { get; }
    public override DateOnly ExpiryDate { get; }
}
