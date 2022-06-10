Console.Write("Vvedite chislo: ");


string input = Console.ReadLine(); // считывыет пользовательский ввод
int number = Convert.ToInt32(input);

int result = number * number;

Console.Write("Otvet: ");
Console.Write(result);
