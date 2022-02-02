Console.WriteLine("************************");
Console.WriteLine("* String formatting");
Console.WriteLine("************************");

string firstName = "Chris";
string greeting = "Hello";

/*
 * String concatenation
 *
 */
string message = greeting + " " + firstName + "!"; // string concatenation
Console.WriteLine(message);
/*
 * String interpolation
 *
 */
message = $"{greeting} {firstName}!"; // string interpolation
Console.WriteLine(message);

/*
 * Combine verbatim literals and string interpolation
 *
 */
string projectID = "First-Project";
Console.WriteLine($@"C:\Output\{projectID}\Data");


/*
 * Exercise - Combine verbatim literals and string interpolation
 *
 */
Console.WriteLine("************************");
Console.WriteLine("* Exercise - String formatting");
Console.WriteLine("************************");

string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

/*
 * Solution by Me.
 * 
 */
Console.WriteLine("View English output:");
Console.Write("\t");
Console.WriteLine($@"c:\Exercise\{projectName}\data.txt");
Console.Write("\n");

Console.WriteLine($"{russianMessage}:");
Console.Write("\t");
Console.WriteLine($@"c:\Exercise\{projectName}\ru-RU\data.txt");
Console.Write("\n");

/*
 * Solution by Microsoft Learn.
 *
 */
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");
