// See https://aka.ms/new-console-template for more information


using ParProgrammeringUke5_Oppgave2;


List<ISellable> StoreItems =
[
    new ClothingItem("Shirt", 5, 500, 32, "Blue"),
    new ElectronicItem("Dvd Player", 3, 1000, 140, "Black")
];

foreach (var item in StoreItems)
{
    Console.WriteLine(item.CalculatePrice());
}

MainStore store = new MainStore(new BlackFridayStore());
store.SeeAllPrices();

store.ChangeStore(new NettstoreWithTax());
store.SeeAllPrices();