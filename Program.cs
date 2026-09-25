Console.WriteLine("Hello, gateway!");

Console.Write("Sender name: ");
string? sender = Console.ReadLine();

Console.Write("Recipient name: ");
string? recipient = Console.ReadLine();

Console.Write("Currency: ");
string? currency = Console.ReadLine();

Console.Write("Amount: ");
string? amountText = Console.ReadLine();

if (string.IsNullOrWhiteSpace(sender)){
    Console.WriteLine("Sender name can't be blank.");
    return;
}

if (string.IsNullOrWhiteSpace(recipient)){
    Console.WriteLine("Recipient name can't be blank.");
    return;
}

currency = (currency ?? "").Trim().ToUpper();

if (currency != "GBP" && currency != "EUR" && currency != "USD"){
    Console.WriteLine("Currency must be GBP, EUR or USD.");
    return;
}

if (!decimal.TryParse(amountText, out decimal amount)){
    Console.WriteLine("Amount must be a number.");
    return;
}

if (amount <= 0){
    Console.WriteLine("Amount must be greater than zero.");
    return;
}

Console.WriteLine($"Sender is {sender}");
Console.WriteLine($"Recipient is {recipient}");
Console.WriteLine($"Currency is {currency}");
Console.WriteLine($"Amount is {amount}");