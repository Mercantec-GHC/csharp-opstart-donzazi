// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Console.WriteLine("Hello, World!");

Console.Write("Congratulations!");
Console.Write(" ");
Console.WriteLine("You wrote your first lines of code.");

//Complete the challenge

//first example
Console.WriteLine("This is the first line.");
Console.WriteLine("This is the second line.");
Console.WriteLine(" ");

// second example
Console.WriteLine("This is the first line.");
Console.Write("This ");
Console.Write("is ");
Console.Write("the ");
Console.Write("second ");
Console.WriteLine("line.");
Console.WriteLine(" ");

// Use character literals
Console.WriteLine('b');
Console.WriteLine(" ");

// Use integer literals
Console.WriteLine(123);
Console.WriteLine(" ");

// Use floating-point literals
Console.WriteLine(0.25F);
Console.WriteLine(2.625);
Console.WriteLine(12.39816m);
Console.WriteLine(" ");

// Use Boolean literals
Console.WriteLine(true);
Console.WriteLine(false);
Console.WriteLine(" ");

// Exercise - Working with variables
// Create your first variable
string firstName;
firstName = "Don";
Console.WriteLine(firstName);

// Reassign the value of a variable
firstName = "Pablo";
Console.WriteLine(firstName);
firstName = "Isabella";
Console.WriteLine(firstName);
firstName = "Yasmin";
Console.WriteLine(firstName);

// Initialize the variable
string first_Name = "DonZazi";
Console.WriteLine(first_Name);
Console.WriteLine(" ");

// Challenge: Display literal and variable values
string name = "Bob";
int messages = 3;
decimal temperature = 34.4m;
Console.WriteLine("Hello, " + name + "! You have " + messages + " messages in your inbox. The temperature is " + temperature + " celcius.");

// Character escape sequences
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
Console.WriteLine("Hello \"World\"!");
Console.WriteLine("c:\\source\\repos");

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");
Console.WriteLine(" ");

// Unicode escape characters (Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

// Format output using unicode escape characters
// To generate Japanese invoices:
// Nihon no seikyu-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");
Console.WriteLine("");

// Concatenate multiple variables and literal strings
string nameBob = "Bob";
string greeting = "Hello";
Console.WriteLine(greeting + " " + nameBob + "!");
// or do this (string interpolation)
Console.WriteLine($"{greeting} {nameBob}!");
Console.WriteLine("");

// String interpolation
string firstName10 = "Bob";
string message10 = $"Hello {firstName10}!";
Console.WriteLine(message10);
Console.WriteLine("");

// Use string interpolation with multiple variables and literal strings
int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}!");
Console.WriteLine("");


// Combine verbatim literals and string interpolation
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");
Console.WriteLine("");


// Challenge: Format and display instructions
string project_Name = "ACME";
string englishLocation = $@"c:\Exercise\{project_Name}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{project_Name}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");


//Add two numeric values
firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets. ");

//Write code to perform addition, subtraction, multiplication, and division with integers
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum:\t\t = " + sum);
Console.WriteLine("Difference\t = " + difference);
Console.WriteLine("Product\t\t = " + product);
Console.WriteLine("Quotient\t = " + quotient);

decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient = {decimalQuotient}");

// Add code to cast results of integer division
int first = 7;
int second = 5;
decimal quoTient = (decimal)first / (decimal)second;
Console.WriteLine(quoTient);

// Write code to determine the remainder after integer division
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

//Write code to exercise C#'s order of operations
int value1 = 3 + 4 * 5;
int value2 = (3 + 4) *5;
Console.WriteLine(value1);
Console.WriteLine(value2);

int value = 1;
value = value + 1;
Console.WriteLine("First increment " + value);

value += 1;
Console.WriteLine($"Second increment {value}");

value++;
Console.WriteLine($"Third increment {value}");

value = value - 1;
Console.WriteLine($"First decrement {value}");

value -= 1;
Console.WriteLine($"Second decrement {value}");

value--;
Console.WriteLine($"Third decrement {value}");


value = 1;
value++;
Console.WriteLine($"First: {value}");
Console.WriteLine($"Second {value++}");
Console.WriteLine($"Third: {value}");
Console.WriteLine($"Fourth: {(++value)}");
Console.WriteLine("");

// Challenge: Calculate Celsius given the current temperature in Fahrenheit
/*int fahrenheit = 94;
int substract = 32;
int multiply = 5 / 9;
Console.WriteLine("The temperature is " + (fahrenheit - substract) * multiply + " Celsius");
*/

int fahrenheit = 94;
decimal substract = 32m;
decimal multiply = 5m / 9m;
decimal celcius = (fahrenheit - substract) * (multiply);
Console.WriteLine("The temperature is " + celcius + " Celsius");

