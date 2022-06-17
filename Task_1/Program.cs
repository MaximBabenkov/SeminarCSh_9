//Показать все натуральные числа от n до 1, n задано
void PrintNumbers (int n)
{    
    if (n<1) return;
    Console.Write(n+" ");   
    PrintNumbers(n-1);
    
}
Console.Clear();
PrintNumbers(4);
