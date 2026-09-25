Console.WriteLine("Hello, gateway!");

Console.Write("Sender name: ");
string? sender = Console.ReadLine();

Console.Write("Recipient name: ");
string? recipient = Console.ReadLine();

Console.Write("Currency: ");
string? currency = Console.ReadLine();

Console.Write("Amount: ");
string? amountText = Console.ReadLine();

List<string> errors = new List<string>();

if (string.IsNullOrWhiteSpace(sender)){
    errors.Add("Sender name can't be blank.");
}

if (string.IsNullOrWhiteSpace(recipient)){
    errors.Add("Recipient name can't be blank.");
}

currency = (currency ?? "").Trim().ToUpper();

if (currency != "GBP" && currency != "EUR" && currency != "USD"){
    errors.Add("Currency must be GBP, EUR or USD.");
}

if (!decimal.TryParse(amountText, out decimal amount)){
    errors.Add("Amount must be a number.");
}
else if (amount <= 0){
    errors.Add("Amount must be greater than zero.");
}

if (errors.Count == 0){
    Console.WriteLine("Valid payment");
    Console.WriteLine($"Sender is {sender}");
    Console.WriteLine($"Recipient is {recipient}");
    Console.WriteLine($"Currency is {currency}");
    Console.WriteLine($"Amount is {amount}");
}
else {
    foreach (string error in errors){
        Console.WriteLine(error);
    }
}