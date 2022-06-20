using System;
int[] numbers = new int[10];
int sum=0,avg=0,above=0,below=0;
for(int i = 0; i < 10; i++)
{
    Console.Write("Please enter a number");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
    sum+=numbers[i];
}
avg=sum/numbers.Length;
for(int j = 0; j < 10; j++)
{
    if(numbers[j] < avg)
    {
        above++;
    }
    else if(numbers[j] > avg)
    {
        below++;
    }
   
}
Console.WriteLine("Average is :" + avg);
Console.WriteLine("Average below is :" + below);
Console.WriteLine("Average above is :" + above);

