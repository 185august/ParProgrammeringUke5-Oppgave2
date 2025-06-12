namespace ParProgrammeringUke5_Oppgave2;

public class BlackFridayStore : IStore
{
    private double _saleProcent = 0.30;
    private List<ISellable> StoreItems =
    [
        new ClothingItem("Shirt", 5, 500, 32, "Blue"),
        new ElectronicItem("Dvd Player", 3, 1000, 140, "Black")
    ];

    public void SeeAllPrices()
    {
        foreach (var item in StoreItems)
        {
            var price = item.CalculatePrice()- (item.CalculatePrice() * _saleProcent);
            Console.WriteLine($"The price is {price} after 30% discount");
        }
    }

}