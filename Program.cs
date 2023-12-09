using System;
namespace dz1{
    class Programm{
        static void Main(){
         /*   //Задание 1
            int sum = 0;
            
            int [] arr = new int [10] ;
            for (int i = 0 ; i< arr.Length; i++)
            {
                arr [i]= new Random().Next(1,101);
                Console.Write(arr [i]+" ");
            } 
            for (int i = 0 ; i< arr.Length; i++){
                if( arr[i]>20 && arr[i]<90){
                    sum++;
                }
            }
           
            Console.WriteLine();
            Console.WriteLine(sum); */

            //задание 2
          /*int sum = 0;
            
            int [] arr = new int [10] ;
            for (int i = 0 ; i< arr.Length; i++)
            {
                arr [i]= new Random().Next(1,101);
                Console.Write(arr [i]+" ");
                if(arr[i]%2==0)
                {
                    sum++;
                }
                
            }    
            Console.WriteLine();
           Console.WriteLine("Количество четных чисел в массиве:"+sum); */


           //ЗАДАЧА 3

           Console.Write("Введите количество элементов массива: ");
        int n = int.Parse(Console.ReadLine());
        double[] array = new double[n];
        Random random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(100) + random.NextDouble(); // Генерация числа до 100 с ненулевой дробной частью
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Элемент {i + 1}: {array[i]}");
        }
         double max = array[0];
        for (int i = 1; i < n; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
         double min = array[0];
        for (int i = 1; i > n; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        Console.WriteLine("Максимальное значение:"+ max);
         Console.WriteLine("Минимальное значение:"+ min);

        }
    }
}
