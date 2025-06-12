namespace ParProgrammeringUke5_Oppgave2;

public class NettstoreWithTax : IStore
{
    private double TaxRate = 0.25;
    private List<ISellable> StoreItems =
        [
            new ClothingItem("Shirt", 5, 500, 32, "Blue"),
            new ElectronicItem("Dvd Player", 3, 1000, 140, "Black")
        ];

    public void SeeAllPrices()
    {
        foreach (var item in StoreItems)
        {
            var price = (item.CalculatePrice() * TaxRate) + item.CalculatePrice();
            Console.WriteLine($"The price is {price} after tax");
        }
    }
    
}