using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
        Notebook notebook1 = new Notebook();
         
         notebook1.name = "Macbook";
         notebook1.brandname = "Apple";
         notebook1.price = 2000;

            Console.WriteLine(notebook1.name);
            Console.WriteLine(notebook1.brandname);
            Console.WriteLine(notebook1.price);

            
        
        }
    }
}
