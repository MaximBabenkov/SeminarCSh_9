//Показать все натуральные числа от 1 до n, n задано

void PrintNumbers (int n)
{
    if (n<1) return;    
    PrintNumbers(n-1);
    Console.Write(n+" ");
}
Console.Clear();
PrintNumbers(4);
