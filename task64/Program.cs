Console.Clear();
Console.Write("Введите чило: ");
int n = Convert.ToInt32(Console.ReadLine());
void Print (int n)
{
   int m = 1;
   if(n >= m)
   {
       Console.WriteLine(n);
       Print(n -1);
   }
 }
Print(n);
