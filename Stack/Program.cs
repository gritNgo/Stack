Stack stack = new Stack();

Console.WriteLine("*******************************************");
Console.WriteLine("                   STACK              ");
Console.WriteLine("*******************************************");


while (true)
{
    Console.WriteLine("Enter 'push' to push an object onto stack, 'pop' to pop out of it, or 'exit' to exit: ");

    var input = Console.ReadLine();

    var components = input.Split(' ');

    if (components[0].ToLower() == "push" && components[1] != null)
    {
        var obj = components[1];
        stack.Push(obj);
        Console.WriteLine($"{obj} pushed");
    }

    else if (components[0].ToLower() == "pop")
    {
        Console.WriteLine(stack.Pop());
    }

    else if (components[0].ToLower() == "exit")
    {
        Console.WriteLine("Exited");
        return;
    }


}














stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(null);

foreach (var item in stack.Objects)
{
    Console.WriteLine(item + " pushed");
}

Console.WriteLine();
Console.WriteLine(stack.Pop() + " popped");
Console.WriteLine(stack.Pop() + " popped");
Console.WriteLine(stack.Pop() + " popped");
Console.WriteLine(stack.Pop() + " popped");





