using Warehouse.WareHouse;

namespace Warehouse.Data;

public class InitialState
{
    public List<Pallet> GetPallets()
    {
        var random = new Random();
        var result = Enumerable.Range(1, 25).Select(p => new Pallet
        (
            p,
            random.Next(10, 15),
            random.Next(100, 150),
            random.Next(100, 130)
        )).ToList();

        int boxId = 0;
        foreach (var r in result)
        {
            foreach (var b in Enumerable.Range(1, 15))
            {
                boxId++;
                r.TryAddBox(new Box
                (
                    boxId,
                    random.Next(5, 25),
                    random.Next(10, 60),
                    random.Next(40, 180),
                    random.Next(40, 123),
                    new DateOnly(random.Next(2024, 2025), random.Next(1, 12), random.Next(1, 30))
                ));
            }
        }
        return result;
    }
}
