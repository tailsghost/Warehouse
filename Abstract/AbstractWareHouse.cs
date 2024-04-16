using Warehouse.Data;
using Warehouse.WareHouse;

namespace Warehouse.Abstract;

public abstract class AbstractWareHouse
{
    protected readonly CollectionWriter PalletSortResponse;

    protected readonly List<Pallet> pallets;

    protected AbstractWareHouse(CollectionWriter palletSortResponse, List<Pallet> _initialState)
    {
        PalletSortResponse = palletSortResponse;
        pallets = _initialState;
    }
    public abstract void Run();
}
