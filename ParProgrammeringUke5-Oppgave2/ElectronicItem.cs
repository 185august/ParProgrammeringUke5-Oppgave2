namespace ParProgrammeringUke5_Oppgave2;

public class ElectronicItem : InventoryItem, ISellable
{
    public int Watt { get; set; }
    public string Insurance { get; set; }
    public ElectronicItem(string name, int quantity, double price, int watt, string insurance)
        : base(name, quantity, price)
    {
        Watt = watt;
        Insurance = insurance;
    }

    public double CalculatePrice()
    {
        return Price;
    }
}