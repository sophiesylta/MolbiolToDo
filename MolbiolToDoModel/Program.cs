using System;

namespace MolbiolToDoModel
{
    class Program
    {
        static void Main(string[] args)
        {

            string stationName = Console.ReadLine();
            Station st1 = new Station(stationName);
            st1.addTask(Console.ReadLine());
            st1.addTask(Console.ReadLine());
            Console.WriteLine(st1.name);
            foreach (Task t in st1.tasks)
                Console.WriteLine(t.name);
        }
    }
}
