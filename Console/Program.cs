using OopUppgift;

Checkout checkout = new Checkout();
checkout.AddItem(1);
checkout.AddItem(1);
checkout.AddItem(1);
checkout.AddItem(1);
checkout.AddItem(1);
checkout.AddItem(1);
//checkout.AddItem(5, 100);
Console.WriteLine(checkout.Sum());