using System.Collections;
ArrayList numbers=new ArrayList();
numbers.Add(10);
numbers.Add(20);
numbers.Add(30);
numbers.Add(40);
numbers.Add(50);
for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}
// Question 2

numbers.Add(60);
numbers.Insert(1, 15);
Console.WriteLine("After Add and Insert:");
for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}
// Question 3

Console.WriteLine("Total number of elements: " + numbers.Count);
// Question 4
numbers.Sort();
Console.WriteLine("ArrayList in ascending order:");

for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}
// Question 5

for (int i = 0; i < numbers.Count - 1; i++)
{
if (numbers[i].Equals(numbers[i + 1]))
{
    numbers.RemoveAt(i + 1);
    i--;
}
}
Console.WriteLine("ArrayList after removing duplicates:");

for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}
//  Question 6

Console.WriteLine("Minimum element: " + numbers[0]);
Console.WriteLine("Maximum element: " + numbers[numbers.Count - 1]);
//  Question 7
ArrayList secondArrayList = new ArrayList();
secondArrayList.Add(20);
secondArrayList.Add(40);
secondArrayList.Add(70);
secondArrayList.Add(80);
Console.WriteLine("Common elements:");
for (int i = 0; i < numbers.Count; i++)
{
for (int j = 0; j < secondArrayList.Count; j++)
{
if (numbers[i].Equals(secondArrayList[j]))
{
    Console.WriteLine(numbers[i]);
}
}
}