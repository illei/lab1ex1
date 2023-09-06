using System;

namespace lab1ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int inaltime;
            int lungime;
            int latime;
            int volum;
            /*Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
                paralelipiped dreptunghic, va afisa volumul lui*/
            Console.WriteLine("Introduceti inaltimea Paralepipedului:");
            inaltime = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti lungimea Paralepipedului:");
            lungime = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti latimea Paralepipedului:");
            latime = int.Parse(Console.ReadLine());
            volum = inaltime * lungime * latime;


            Console.WriteLine("Volumul paralepipedului este :" + volum);
        }
    }
}
