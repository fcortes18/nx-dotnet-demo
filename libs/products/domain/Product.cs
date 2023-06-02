namespace Products.Domain;
public class Product
{
    public int Id {get; set;}
    public string Name {get; set;} = string.Empty;
    public Guid Code {get; set;} = Guid.Empty;
    public string Description {get; set;} = string.Empty;
    public decimal Price {get; set;}
}