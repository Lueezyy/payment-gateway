Console.WriteLine("Hello, gateway!");

Console.Write("Sender name: ");
string? sender = Console.ReadLine();

Console.Write("Recipient name: ");
string? recipient = Console.ReadLine();

Console.Write("Currency: ");
string? currency = Console.ReadLine();

Console.WriteLine($"Sender is {sender}");
Console.WriteLine($"Recipient is {recipient}");
Console.WriteLine($"Currency is {currency}");