Console.Write("Enter your name: ");
string username = Console.ReadLine() ?? "0";

if (username.ToLower() == "paul")
{
    Console.WriteLine("Wow, that's Paul !!!");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}
