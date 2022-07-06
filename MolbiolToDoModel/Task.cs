using System;
namespace MolbiolToDoModel
{
    public class Task
    {
        public string name { get; private set; }
        public Station station { get; private set; }

        public Task(string name, Station station)
        {
            this.name = name;
            this.station = station;

        }

    }
}
