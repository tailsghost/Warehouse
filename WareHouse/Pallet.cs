using System.Collections.ObjectModel;
using Warehouse.Abstract;

namespace Warehouse.WareHouse;

public class Pallet : Container
{
    public Pallet(int id, double width, double depth, double height)
        : base(id, width, depth, height)
    {
        palletVolume = width * height * depth;
        Boxes = new(boxesList);
    }

    public override double Weight => Boxes.Select(b => b.Weight).Append(30).Sum();

    private readonly double palletVolume;
    public override double Volume => Boxes.Select(b => b.Volume).Append(palletVolume).Sum();
    public override DateOnly ExpiryDate
    {
        get
        {
            if (Boxes.Count == 0)
                return new DateOnly();
            return Boxes.Min(b => b.ExpiryDate);
        }
    }

    public ReadOnlyCollection<Box> Boxes { get; }
    private readonly List<Box> boxesList = [];

    public event EventHandler? PalletChanged;

    public bool TryAddBox(Box box)
    {
        if (box.Width > Width || box.Width > Depth)
        {
            return false;
        }
        boxesList.Add(box);
        PalletChanged?.Invoke(this, EventArgs.Empty);
        return true;
    }

    public bool TryRemoveBox(Box box)
    {
        if (boxesList.Remove(box))
        {
            PalletChanged?.Invoke(this, EventArgs.Empty);
            return true;
        }
        return false;
    }
}