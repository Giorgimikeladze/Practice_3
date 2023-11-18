
int numb;
Console.Write("Enter some integer value: ");
bool is_parsed = Int32.TryParse(Console.ReadLine(), out numb);

if (is_parsed && numb>=1)
{
    
	for (int i = 1; i <=numb; i++)
	{
        Console.WriteLine($"{i} cubed is: {Math.Pow(i,3)}");

    }
}
else {
    Console.WriteLine( "Invalid value!!!!");
}

