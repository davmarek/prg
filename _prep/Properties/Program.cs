Product product = new Product();
product.Name = name;
product.Price = price;
Console.WriteLine($"{product.Name}: ${product.Price}");

public class Product
{
    // Step 1: Declare a private backing field for name

    // Step 2: Declare a private backing field for price

    // Step 3: Create a property for Name with get and set accessors
    // The get accessor should return the backing field
    // The set accessor should assign the value to the backing field

    // Step 4: Create a property for Price with get and set accessors
    // In the set accessor, only allow positive values (if value <= 0, keep current price)
}
