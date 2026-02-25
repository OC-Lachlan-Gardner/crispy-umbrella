class Cart
{
    public int itemsCount = 0;
    const int FreeShippingThreshold = 5;

    public void AddItem()
    {
        itemsCount++;
    }

    public string ShippingMessage()
    {
        if (itemsCount >= FreeShippingThreshold)
        {
            return "Free shipping";
        }
        else
        {
            return "Shipping applies";
        }
    }

    public static bool QualifiesForFreeShipping(int count)
    {
        if (count >= FreeShippingThreshold)
        {
            return true;
        } else
        {
            return false;
        }
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Cart newCart = new Cart();

        do
        {
            newCart.AddItem();

            Console.WriteLine(newCart.itemsCount);

            Console.WriteLine(newCart.ShippingMessage());
        } while(!Cart.QualifiesForFreeShipping(newCart.itemsCount));
    }
}

// AddItem and ShippingMessage are both instance types because they use the instances properties to function.
// FreeShippingThreshold and QualifiesForFreeShipping are static methods because they can be used independent of an instance.