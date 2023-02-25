// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
//
// Можно записать так:
// def Foo(number, argument):
//    if number == 0:
//        return argument + 1
//
//    result = argument
//   for i in range(argument + 2):
//        result = Foo(number - 1, result)
//
//    return result

Console.WriteLine("Введите два положительных числа M и N");
int m = InputInt("Введите M: ");
int n = InputInt("Введите N: ");
Console.WriteLine($"A({m}, {n}) = {Ack(m, n)}");
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
int Ack(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Ack(m - 1, 1);
    else
        return Ack(m - 1, Ack(m, n - 1));
}
