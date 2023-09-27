// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var str = "Hello  World";
var result = "";
var stack = new Stack<char>();
for (int i = 0; i < str.Length; i++)
{
    if (str[i].ToString().Equals(" "))
    {
        stack.Push(str[i]);
    }

    if (stack.Count == 0 || stack.Count == 1)
    {        
        result += str[i].ToString();        
    }
    else
    {
        stack.Pop();
    }
}
Console.WriteLine(result);

