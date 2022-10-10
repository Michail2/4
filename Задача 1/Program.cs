int a = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[a];
for( int i = 0; i < a; i++)
{
 arr[i] = new Random().Next(0,2); 
 Console.Write(arr[i] + " ");
}
