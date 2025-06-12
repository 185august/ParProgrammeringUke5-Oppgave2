namespace ParProgrammeringUke5_Oppgave2;

public abstract class InventoryItem
{
    protected string Name { get; set; }
    protected int Quantity { get; set; }
    protected double Price { get; set; }

    public InventoryItem(string name, int quantity, double price)
    {
        Name = name;
        Quantity = quantity;
        Price = price;
    }
    
    public void Print()
    {
        Console.WriteLine($"Name: {Name}, Quantity: {Quantity}, Price: {Price}");
    }
}