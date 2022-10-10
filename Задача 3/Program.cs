int a = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[a];
int n = 0;
int m = 0;
for( int i = 0; i < a; i++)
{
 arr[i] = new Random().Next(99, 1000);
 Console.Write(arr[i] + " ");
 if (arr[i] % 2 == 0 )
 {
  n = n + 1;  
 }
 else if (arr[i] % 2 != 0 )
 {
  m = m + 1;
 }
}
Console.WriteLine("Количество четных значений: " + n);
Console.WriteLine("Количество не четных значений: " + m);
