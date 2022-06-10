Console.Write("Koren: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Kvadrat: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 * number1 == number2)
    Console.WriteLine(number1 + "^2" + "=" + number2 + " (True) ");
else
    Console.WriteLine(number1 + "^2" + "=" + number2 + " (False) ");