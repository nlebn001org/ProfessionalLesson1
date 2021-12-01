using System;

namespace ProfessionalLesson1Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            MyCollection<Citizen> list = new MyCollection<Citizen>();
            list.Add(new Retiree(1));
            list.Add(new Retiree(2));
            list.Add(new Retiree(3));
            list.Add(new Retiree(4));
            list.Add(new Retiree(5));
            list.Add(new Worker(5));
            list.Add(new Worker(2));
            list.Add(new Student(5));


            Retiree ret = new Retiree(5);
            Console.WriteLine(list.Contains(ret));
            Console.WriteLine(new string('-', 20));
            list.RemoveByCitizenType(typeof(Retiree));
            Console.WriteLine(list.LastCitizen());
            Console.WriteLine(new string('-', 20));
            list.Remove();
            Console.WriteLine(new string('-', 20));
            list.RemoveByCitizenType(typeof(Retiree));
            Console.WriteLine(new string('-', 20));


            foreach (var item in list)
                Console.WriteLine(item);

        }
    }
}
