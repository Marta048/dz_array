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
          int sum = 0;
            
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
           Console.WriteLine("Количество четных чисел в массиве:"+sum); 
        }
    }
}
