// Adding two number variables together
int firstNumber = 13;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

// Concatenating numbers and strings
string firstName = "Chris";
int widgetsSold = 15;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

// Basic mathematical operations
int sum = 8 + 6;
int difference = 8 - 6;
int product = 8 * 6;
int quotient = 8 / 6;
decimal decimalQuotient = 8 / 6.0m;
Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);
Console.WriteLine("Decimal quotient: " + decimalQuotient);

// Using literal decimal data
int first = 8;
int second = 6;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);

// Calulating modulus using odulus operator
Console.WriteLine("Modulus of 300 / 6: " + (300 % 6));
Console.WriteLine("Modulus of 8 / 6: " + (8 % 5));

// Order of operation
int value0 = 4 + 5 * 6;
int value1 = (4 + 5) * 6;
Console.WriteLine(value0);
Console.WriteLine(value1);

// Incrementing and decrementin values
int value = 3;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);

// Positioning the increment and decrement operators
value = 3;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine("Second: " + (value++)); // retrieve the value before incrementing
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value)); // increment the value first before retrieving

// Converting from fahrenheit to celsius
int fahrenheit = 93;
decimal celcius = (fahrenheit - 32) * (5m / 9m);
string message = "The temperature is " + celcius + " Celcius.";
Console.WriteLine(message);
