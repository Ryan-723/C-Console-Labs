
public class item : IitemInfo
{
    public string itemName { get; set; }
    public int itemQuantity { get; set; }
    public double itemPrice { get; set; }
    
    item newItem = new item();

    public override string ToString(){
    return $"Book Name: {itemName}, Quantity: {itemQuantity}, Price: {itemPrice}";
    }
}


