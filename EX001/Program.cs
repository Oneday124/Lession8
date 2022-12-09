// Собрать строку с числами от a до b, a<=b. Рекурсия
string NumbersRec(int a, int b)
{
    if(a <= b) return $"{a} " + NumbersRec(a+1,b);
    else return String.Empty;
}

System.Console.WriteLine(NumbersRec(1,10));
