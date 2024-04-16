namespace Warehouse.WareHouse;

public static class PalletsView
{
    public static Pallet[] GetPalletsMaxExpirationDate(IEnumerable<Pallet> pallets)
    {
        return [.. pallets
                        .OrderByDescending(p => p.ExpiryDate)
                        .Take(3)
                        .OrderBy(p => p.Volume)];
    }

    public static IGrouping<DateOnly, Pallet>[] GetPalletsGroup(IEnumerable<Pallet> pallets)
    {
        return [.. pallets
                        .OrderBy(p => p.Weight)
                        .GroupBy(p => p.ExpiryDate)
                        .OrderBy(gr => gr.Key)];
    }

    public static void Display(IEnumerable<IGrouping<DateOnly, Pallet>> palletGroups)
    {
        foreach (var gr in palletGroups)
        {
            Console.WriteLine($"Срок годности паллеты {gr.Key}");
            Display(gr);
            Console.WriteLine("___________________________________________\n");
        }
    }


    public static void Display(IEnumerable<Pallet> pallets)
    {
        foreach (Pallet p in pallets)
        {
            Display(p);
        }
    }
    public static void Display(Pallet pallet)
    {
        Console.WriteLine($"Id паллеты: {pallet.Id}\n" +
           $"Глубина паллеты: {pallet.Depth}\n" +
           $"Высота паллеты: {pallet.Height}\n" +
           $"Ширина паллеты {pallet.Width}\n" +
           $"Объем паллеты: {pallet.Volume}\n" +
           $"Вес паллеты: {pallet.Weight}\n");

        if (pallet.Boxes.Count == 0)
            Console.WriteLine("У паллеты нет коробок!");

        foreach (var box in pallet.Boxes.OrderBy(x => x.Weight))
        {
            Console.WriteLine($"\tId коробки:{box.Id}\n" +
                $"\tГлубина коробки: {box.Depth}\n" +
                $"\tВысота: {box.Height}\n" +
                $"\tШирина коробки: {box.Width}\n" +
                $"\tОбъем коробки: {box.Volume}\n" +
                $"\tСрок годности коробки: {box.ExpiryDate}\n" +
                $"\tВес коробки: {box.Weight}\n");
        }
    }
}
