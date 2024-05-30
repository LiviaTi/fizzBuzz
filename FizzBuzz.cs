/*string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David") names[i] = "Sammy";
    Console.WriteLine(names[i]);
}

*/


for(int i=1; i<=100 ;i++){
    Console.Write($"{i} - ");
    if(i % 3 ==0 ) Console.Write("Fizz");
    if(i % 5 ==0 ) Console.Write("Buzz");
    Console.WriteLine(" ");
}