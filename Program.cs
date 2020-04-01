using System;

namespace DZ6
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Задание №1 \n Сделано!");
            }
            {
                Console.WriteLine("Задание №2");
                Console.Write("Введите размер массива: ");
                int max, min, sum=0, size = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[size];
                for(int i=0; i<size; i++)
                {
                    arr[i] = new Random().Next(-9,9);
                    sum = arr[i] + sum;
                }
                max = arr[0]; min = arr[0];
                
                for(int i=1; i<size; i++)
                {
                    if(arr[i]>max) max = arr[i];
                    if(arr[i]<min) min = arr[i];
                }
                Console.Write("Элементы вашего массива: ");  writeArray(arr);
                Console.WriteLine($"\nНаибольшее значение массива: {max}");
                Console.WriteLine($"Наименьшее значение массива: {min} ");
                Console.WriteLine($"Общая сумма всех элементов: {sum} ");
                Console.WriteLine($"Среднее арифметическое всех элементов: {sum/size}");
                Console.WriteLine($"Все нечетные значения: ");
                for(int i=0; i<size; i++)
                {
                    if(arr[i]%2!=0) Console.Write($"{arr[i]} ");
                }
            }
            {
                Console.WriteLine("\nЗадние №3");
                Console.Write("Введите размер массива: ");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[size];
                for(int i=0; i<size; i++){
                      arr[i]= new Random().Next(-9,9);
                }
                Console.WriteLine("Ваш массив: ");
                writeArray(arr);
                Console.WriteLine();
                for(int i=0; i<size/2; i++)
                {
                    arr[i] = arr[i] + arr[size-1-i];
                    arr[size-i-1] = arr[i] - arr[size -1 -i];
                    arr[i] = arr[i] - arr[size - 1- i];
                }
                writeArray(arr);
            }    
            {
                Console.Write("\nЗадание №4 \nВведите размер массива:");
                int N = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[N];
                for(int i=0; i<N; i++) arr[i] = new Random().Next(0,10);
                Console.Write("Ваш массив: ");
                writeArray(arr);
                Console.Write("\ncount = ");
                int count = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n index = ");
                int index = Convert.ToInt32(Console.ReadLine());
                int [] arr2 = new int[count];
                for(int i=0; i<count; i++)
                {
                    if(index>N-1) arr2[i] = 1;
                    else arr2[i] = arr[index];
                    index++;
                }
                Console.Write("\nВаш новый массив: ");
                writeArray(arr2);
            }
       }
        static void writeArray(int[] arr1){
            for(int i=0; i<arr1.Length; i++) Console.Write($"{arr1[i]} ");
        }

    }
}
