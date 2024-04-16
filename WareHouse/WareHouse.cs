using Warehouse.Abstract;
using Warehouse.Data;

namespace Warehouse.WareHouse;

public class WareHouse : AbstractWareHouse
{
    public WareHouse(CollectionWriter palletSortResponse, List<Pallet> pallets) : base(palletSortResponse, pallets)
    {
    }

    public override void Run()
    {
        PalletSortResponse.ConsoleResponseAllPalletSort(pallets);
        PalletSortResponse.ConsoleResponseSeveralPalletSort(pallets);
    }
}
