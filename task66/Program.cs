Console.Clear();
Console.Write("Введите первое чило: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе чило: ");
int m = Convert.ToInt32(Console.ReadLine());
int SumNaturalNumbers(int n, int m)
{
  if(n > m)
  {
     return 0;
  }else
return n + SumNaturalNumbers(n + 1, m) ;
}
//SumNaturalNumbers(n, m);
Console.WriteLine($"Сумма = {SumNaturalNumbers(n, m)}");
