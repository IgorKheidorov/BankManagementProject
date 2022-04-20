// See https://aka.ms/new-console-template for more information

// Do change order!!!!!!!!!!!!!
using FirstSteps;

Bank bpsSber = new Bank(10);

bpsSber.IssueCreditCard("Pupkin", 10);
bpsSber.IssueCreditCard("Johny Walker", 10);
bpsSber.IssueCreditCard("Red Label", 10);

bpsSber.Cards[0].DecreaseBalance(30);
bpsSber.Cards[1].DecreaseBalance(30);


string numbers = bpsSber.GetCardsNumbers();

bool operationResult = bpsSber.TransferMoney("0", "2", 9);

Console.WriteLine(numbers);



