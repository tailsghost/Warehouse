using Warehouse.Abstract;

namespace Warehouse.WareHouse;

public class CollectionWriter : AbstractCollectionWriter
{
    public override void ConsoleResponseAllPalletSort(List<Pallet> pallets)
    {
        Console.WriteLine("___________________________________________\n");
        Console.WriteLine("Сгруппированы все паллеты:");
        Console.WriteLine("___________________________________________\n");

        var resultGroup = PalletsView.GetPalletsGroup(pallets);

        PalletsView.Display(resultGroup);
    }

    public override void ConsoleResponseSeveralPalletSort(List<Pallet> pallets)
    {
        Console.WriteLine("3 паллеты содержащие коробки с наибольшим сроком годности\n");

        Console.WriteLine("___________________________________________\n");

        var resultItems = PalletsView.GetPalletsMaxExpirationDate(pallets);

        PalletsView.Display(resultItems);
    }
}
