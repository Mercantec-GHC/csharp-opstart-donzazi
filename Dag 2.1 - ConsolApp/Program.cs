// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

Console.WriteLine("Hello, World!");

// This code simulates a dice roll to generate a random number.
Random diceNumber = new Random();
int roll = diceNumber.Next(1, 7);
Console.WriteLine(roll);

/*The first code line creates an instance of the Random class named dice. 
The second code line uses the dice.Next(1, 7) method to assign a random value to 
an integer named roll. Notice that the calling statement provides two arguments separated
by a , symbol. The Next() method includes a method signature that accepts two input parameters
of type int. These parameters are used to configure the lower and upper boundaries for the random 
number that's returned. The final code line uses the Console.WriteLine() method to print 
the value of roll to the console.*/

/*Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}"); */

/*The first version of the Next() method doesn't set an upper and lower boundary, 
so the method will return values ranging from 0 to 2,147,483,647, which is the maximum 
value an int can store.The second version of the Next() method specifies the maximum 
value as an upper boundary, so in this case, you can expect a random value between 0 and 100.
The third version of the Next() method specifies both the minimum and maximum values, so in 
this case, you can expect a random value between 50 and 100.*/

Console.WriteLine("\n");

//Code challenge: Implement a method of the Math class that returns the larger of two numbers
int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);
Console.WriteLine("\n");
Console.WriteLine("\n");



Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
    Console.WriteLine("You rolled doubles! +2 bonus to toal");
    total += 2;
}
if ((roll1 == roll2) && (roll2 == roll3))
{
    Console.WriteLine("You rolled triples! +6 bonus to tal");
    total += 6;
}
if (total >= 15)
{
    Console.WriteLine("You Win!");
}
if (total < 15)
{
    Console.WriteLine("Sorry, you lose!");
}



Console.WriteLine("\n");
Console.WriteLine("\n");

