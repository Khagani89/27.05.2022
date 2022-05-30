using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Notebooks notebooks1 = new Notebooks();

            notebooks1.Name = "Macbook";
            notebooks1.Brandname = "Apple";
            notebooks1.Price = 2000;

            Notebooks notebooks2 = new Notebooks();

            notebooks2.Name = "Asus";
            notebooks2.Brandname = "Rog";
            notebooks2.Price = 1000;


            Notebooks notebooks3 = new Notebooks();

            notebooks3.Name = "Acer";
            notebooks3.Brandname = "Predator";
            notebooks3.Price = 3000;



            Notebooks[] notebooks = new Notebooks[3];

            notebooks[0] = notebooks1;
            notebooks[1] = notebooks2;
            notebooks[2] = notebooks3;


            int min = 1000;
            int max = 3000;


            for (int i = 0; i < notebooks.Length; i++)
            {
                if (notebooks[i].Price >= min && notebooks[i].Price <= max)
                {
                    Console.WriteLine(notebooks[i].Name);
                }
            }



        }




    }
}
