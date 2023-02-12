namespace Domain.Model;

public class ShoppingListItem : BaseModel
{
    public ShoppingListItem(Guid id, string name, int quantity, string note, bool isInTheBasket = false)
        : base(id)
    {
        Name = name;
        Quantity = quantity;
        Note = note;
        IsInTheBasket = isInTheBasket;
    }

    public int Quantity { get; set; }
    public string Name { get; set; }
    public string Note { get; set; }
    public bool IsInTheBasket { get; set; }
}