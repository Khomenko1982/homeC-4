// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] arr =new int[8];
int i=0;
for ( i=0; i<8; i++)
{
    int a = new Random().Next(0,2);
    arr[i]=a;
    Console.Write(arr[i]);
    Console.Write(" ");
}
// Console.WriteLine(arr[]);