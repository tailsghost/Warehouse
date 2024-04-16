using Warehouse.Data;
using Warehouse.WareHouse;

var initialState = new InitialState();

var InitialWriter = new CollectionWriter();

new WareHouse(InitialWriter, initialState.GetPallets()).Run();

