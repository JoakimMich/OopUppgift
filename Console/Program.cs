using OopUppgift;

Checkout checkout = new Checkout();
checkout.AddItem(7, 2);
checkout.AddItem(5, 100);
Console.WriteLine(checkout.Sum());