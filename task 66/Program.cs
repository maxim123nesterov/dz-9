Console.Write("Введите число m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n ");
int n = Convert.ToInt32(Console.ReadLine());

if (m>n)
{(m,n)=(n,m);}

int num(int m1,int n1)
{
   Console.Write($" {(m1)}");
   if (m1 == n1) return n1;
   return num(m1 + 1, n1); 
}

num(m,n);
Console.WriteLine();

int sum = 0;
while (m <= n)
{
    sum = sum + m;
    m++;
}
Console.Write($"Сумма = {sum}");