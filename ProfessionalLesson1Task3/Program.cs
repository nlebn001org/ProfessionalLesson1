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
            list.Add(new Student(1));
            list.Add(new Student(2));
            list.Add(new Worker(1));
            list.Add(new Worker(2));
            list.Add(new Retiree(2));
            list.Add(new Retiree(3));

            foreach (var item in list)
                Console.WriteLine(item);

        }
    }
}
