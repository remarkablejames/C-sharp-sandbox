Console.WriteLine("Welcome to the C# class!");

// functions

// void add(int a, int b)
// {
//     Console.WriteLine("a = {0}, b = {1}", a, b);
// }

// add(b: 1, a: 100);


(int a, int b) add(int a, int b)
{
    return (a, b);
}

var (a, b) = add(1, 2);
Console.WriteLine("a = {0}, b = {1}", a, b);