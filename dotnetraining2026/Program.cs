 // Q1
 Console.WriteLine("Enter first number:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number:");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b)
{
    Console.WriteLine("Both numbers are equal");
}
else
{
    Console.WriteLine("Both numbers are not equal");
}

// Question 2

Console.WriteLine("Enter a number:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    Console.WriteLine("The number is positive");
}
else if (number < 0)
{
    Console.WriteLine("The number is negative");
}
else
{
    Console.WriteLine("The number is zero");
}

// Question 3

Console.WriteLine("Enter height in centimeters:");
int height = Convert.ToInt32(Console.ReadLine());

if (height < 150)
{
    Console.WriteLine("Short");
}
else if (height < 180)
{
    Console.WriteLine("Average height");
}
else
{
    Console.WriteLine("Tall");
}

// Question 4

Console.WriteLine("Enter first number:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number:");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third number:");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 >= num2 && num1 >= num3)
{
    Console.WriteLine("Largest number is: " + num1);
}
else if (num2 >= num1 && num2 >= num3)
{
    Console.WriteLine("Largest number is: " + num2);
}
else
{
    Console.WriteLine("Largest number is: " + num3);
}

// Question 5

Console.WriteLine("Enter Roll Number:");
int rollNo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Name:");
string name = Console.ReadLine();

Console.WriteLine("Enter Subject 1 marks:");
int mark1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Subject 2 marks:");
int mark2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Subject 3 marks:");
int mark3 = Convert.ToInt32(Console.ReadLine());

int total = mark1 + mark2 + mark3;
double percentage = total / 3.0;

Console.WriteLine("Total = " + total);
Console.WriteLine("Percentage = " + percentage);

if (percentage >= 60)
{
    Console.WriteLine("First Division");
}
else if (percentage >= 45)
{
    Console.WriteLine("Second Division");
}
else if (percentage >= 33)
{
    Console.WriteLine("Third Division");
}
else
{
    Console.WriteLine("Fail");
}

// Question 6

Console.WriteLine("Enter membership level (Gold/Silver/Platinum):");
string membership = Console.ReadLine();

Console.WriteLine("Enter purchase amount:");
double amount = Convert.ToDouble(Console.ReadLine());

double discount = 0;

if (amount >= 100)
{
    if (membership == "Gold")
    {
        discount = amount * 0.05;
    }
    else if (membership == "Silver")
    {
        discount = amount * 0.10;
    }
    else if (membership == "Platinum")
    {
        discount = amount * 0.20;
    }
}

double finalAmount = amount - discount;

Console.WriteLine("Discount = " + discount);
Console.WriteLine("Final Amount = " + finalAmount);

// Question 7

Console.WriteLine("Enter day number from 1 to 7:");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;

    case 2:
        Console.WriteLine("Tuesday");
        break;

    case 3:
        Console.WriteLine("Wednesday");
        break;

    case 4:
        Console.WriteLine("Thursday");
        break;

    case 5:
        Console.WriteLine("Friday");
        break;

    case 6:
        Console.WriteLine("Saturday");
        break;

    case 7:
        Console.WriteLine("Sunday");
        break;

    default:
        Console.WriteLine("Invalid day number");
        break;
}

// Question 8

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

// Question 9

int sum1 = 0;

for (int i = 1; i <= 10; i++)
{
    sum1 = sum1 + i;
}

Console.WriteLine("Sum = " + sum1);

// Question 10

Console.WriteLine("Enter a positive integer:");
int value = Convert.ToInt32(Console.ReadLine());

int sum2 = 0;

while (value > 0)
{
    int digit = value % 10;
    sum2 = sum2 + digit;
    value = value / 10;
}

Console.WriteLine("Sum of digits = " + sum2);

// Question 11

Console.WriteLine("Enter a string:");
string text = Console.ReadLine();

string reversed = "";

for (int i = text.Length - 1; i >= 0; i--)
{
    reversed = reversed + text[i];
}

Console.WriteLine("Reversed string = " + reversed);

// Question 12

int i = 1;
int sum3 = 0;

while (i <= 100)
{
    sum3 = sum3 + i;
    i++;
}

Console.WriteLine("Sum = " + sum3);

// Question 13

Console.WriteLine("Enter the secret number:");
int secretNumber = Convert.ToInt32(Console.ReadLine());

int guess;

do
{
    Console.WriteLine("Guess the number:");
    guess = Convert.ToInt32(Console.ReadLine());

    if (guess < secretNumber)
    {
        Console.WriteLine("Too low");
    }
    else if (guess > secretNumber)
    {
        Console.WriteLine("Too high");
    }
    else
    {
        Console.WriteLine("Correct!");
    }
}

// Question 14

Console.WriteLine("Enter a number:");
int count = Convert.ToInt32(Console.ReadLine());

while (count >= 0)
{
    Console.WriteLine(count);
    count--;
}


// Question 15

for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine(i + " x " + j + " = " + (i * j));
    }

    Console.WriteLine();
}







