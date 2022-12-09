// вычислить a в степени n. Рекурсия

int PowerRec (int a, int n)
{
    //return n == 0 ? 1 : PowerRec(a, n-1) * a;
    if(n == 0) return 1;
    else return PowerRec(a, n-1) * a;
}

System.Console.WriteLine(PowerRec(2,10));
