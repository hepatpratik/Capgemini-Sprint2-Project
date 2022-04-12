using System;
using System.Linq;

namespace LinqTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 90,80,50,60,70,100,30,20,10,110 };
            int[] array2 = new int[] { 5, 97, 50, 43, 37, 30, 80, 69, 20, 87 };

            var query1 = ( array1 ).Union(array2 );
            Console.WriteLine("----------------Union-------------------");
            foreach (int i in query1)
            {
                Console.WriteLine(i);
            }

          

            var query2 = ( array1 ).Intersect( array2 );
            Console.WriteLine("----------------Intersect-------------------");
            foreach (int i in query2)
            {
                Console.WriteLine(i);
            }

            

            var query3 = ( array1 ).Except( array2 );
            Console.WriteLine("-----------------Except--------------------");
            foreach (int i in query3)
            {
                Console.WriteLine(i);
            }


            var query4 = ( array1 ).Concat(array2 );
            Console.WriteLine("-----------------Concat--------------------");
            foreach (int i in query4)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("------------------------------------------------------------------------------------");

            Console.WriteLine("Aggregate Functions:-");

            Console.WriteLine("-----------------------");

            Console.WriteLine("Sum:-");

            var query5= array1.Sum(i =>i);
           

            Console.WriteLine($"Total Sum = {query5}");

            Console.WriteLine("-----------------------");

            Console.WriteLine("Max:-");

            var query6 = array1.Max(i => i);


            Console.WriteLine($"Max of all elements in array1 = {query6}");

            Console.WriteLine("-----------------------");
            Console.WriteLine("Min:-");

          var query7 = array1 .Min(i => i);


            Console.WriteLine($"Min of all elements in array1 = {query7}");

            Console.WriteLine("-----------------------");
            Console.WriteLine("Average:-");

            var query8 =array1.Average(i => i);

            Console.WriteLine($"Average of all elements in array1 = {query8}");


            Console.WriteLine("-----------------------");
            Console.WriteLine("Count:-");

            var query9 = array1.Count(i=> i<110);

            Console.WriteLine($"Count of all elements in array1 = {query9}");

            Console.WriteLine("-----------------------");
            Console.WriteLine("Distinct:-");
            Console.WriteLine("All the distinct items of the array1 ");
            var query10 = array1.Distinct();
            foreach (var i in query10)
            {
                Console.WriteLine(i);
            }
        }
    }
}