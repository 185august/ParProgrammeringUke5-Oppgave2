namespace ParProgrammeringUke5_Oppgave2;

public class ClothingItem : InventoryItem, ISellable
{
    public int Size { get; set; }
    public string Color { get; set; }
    public ClothingItem(string name, int quantity, double price, int Size, string color)
        : base(name, quantity, price)
    {
        Size = Size;
        Color = color;
    }

    public double CalculatePrice()
    {
        return Price;
    }
}