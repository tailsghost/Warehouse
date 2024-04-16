using Warehouse.WareHouse;

namespace Warehouse.Abstract;

public abstract class AbstractCollectionWriter
{
    public abstract void ConsoleResponseAllPalletSort(List<Pallet> pallets);

    public abstract void ConsoleResponseSeveralPalletSort(List<Pallet> pallets);
}
