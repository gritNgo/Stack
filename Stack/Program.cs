Stack stack = new Stack();

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
Console.WriteLine(stack.Pop());


stack.Clear();

