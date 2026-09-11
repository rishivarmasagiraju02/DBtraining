// Question 1

Console.WriteLine("Enter number of elements:");
int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[n];
Console.WriteLine("Enter the numbers:");
for (int i = 0; i < n; i++)
{
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("The numbers are:");

for (int i = 0; i < n; i++)
{
    Console.WriteLine(numbers[i]);
}
// Question 2
int sum = 0;
for (int i = 0; i < n; i++)
{
    sum = sum + numbers[i];
}
double average = (double)sum / n;
Console.WriteLine("Sum: " + sum);
Console.WriteLine("Average: " + average);
int largestnum = numbers[0];
int smallestnum = numbers[0];
for (int i = 1; i < n; i++)
{
    if (numbers[i] > largestnum)
    {
        largestnum = numbers[i];
    }
}
    for (int i = 1; i < n; i++)
{
    if (numbers[i] < smallestnum)
    {
        smallestnum = numbers[i];
    }
}
    Console.WriteLine("Largest number: " + largestnum);
Console.WriteLine("Smallest number: " + smallestnum);
// Question 4
int evenCount = 0;
int oddCount = 0;
for (int i = 0; i < n; i++)
{
    if (numbers[i] % 2 == 0)
    {
        evenCount++;
    }
    else
{
    oddCount++;
}
}
Console.WriteLine("Even numbers: " + evenCount);
Console.WriteLine("Odd numbers: " + oddCount);
// Question 5
Console.WriteLine("The reversed Array:");
for (int i = n - 1; i >= 0; i--)
{
    Console.WriteLine(numbers[i]);
}

// Question 6
//int secondLargest=numbers[0];
int secondLargest;

if (numbers[0] == largestnum)
{
    secondLargest = numbers[1];
}
else
{
    secondLargest = numbers[0];
}
for (int i = 0; i < n; i++)
{
    if (numbers[i] < largestnum && numbers[i] > secondLargest)
    {
        secondLargest = numbers[i];
    }
}
Console.WriteLine("Second largest number: " + secondLargest);

// Question 7
// Question 8

for (int i = 0; i < n; i++)
{
    for (int j = i + 1; j < n; j++)
    {
if (numbers[i] > numbers[j])
{
int temp = numbers[i];
numbers[i] = numbers[j];
numbers[j] = temp;
}
    }
}
Console.WriteLine("Array in ascending order:");
for (int i = 0; i < n; i++)
{
    Console.WriteLine(numbers[i]);
}
// Question 9
// Question 9
Console.WriteLine("Missing number:");

for (int i = 1; i <= n + 1; i++)
{
    int found = 0;

    for (int j = 0; j < n; j++)
    {
        if (numbers[j] == i)
        {
            found = 1;
        }
    }

    if (found == 0)
    {
        Console.WriteLine(i);
    }
}
// Question 10

int[] secondArray = { 20, 40, 50, 60 };
for (int i = 0; i < n; i++)
{
for (int j = 0; j < secondArray.Length; j++)
{
if (numbers[i] == secondArray[j])
{
    Console.WriteLine(numbers[i]);
}
}
}
// Question 7
// Question 7

Console.WriteLine("Array without duplicates:");

for (int i = 0; i < n; i++)
{
    int duplicate = 0;
    for (int j = 0; j < i; j++)
{
if (numbers[i] == numbers[j])
{
    duplicate = 1;
}
}
if (duplicate == 0)
{
    Console.WriteLine(numbers[i]);
}
}
