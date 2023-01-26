// Console.WriteLine("Введите числа через пробел");
// int [] numbers = GetArrayFromString(Console.ReadLine());
Console.WriteLine("Введите количество чисел");
int number = Convert.ToInt32(Console.ReadLine());
int[] mass = new int [number];
int max = 0;
for(int i = 0; i < number; i++)
{
 mass[i] = new Random().Next(-100, 100);
 Console.WriteLine($"{mass[i]} ");  
}
for(int i = 0; i < number; i++)
{
 if(mass[i] > 0) max++;
}
Console.WriteLine();
Console.WriteLine(max);
