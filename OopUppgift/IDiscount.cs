namespace OopUppgift
{
    interface IDiscount
    {
        decimal DiscountSum(Dictionary<Product, Item> items);
    }
}
