Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());

int num(int n)
{
   if (0 == n) return n; Console.Write($" {n}");
   return num(n - 1); 
   
}

num(n);