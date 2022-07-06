using System;
using System.Collections.Generic;

namespace MolbiolToDoModel
{

    public class Station
    {
        public string name { get; private set; }
        public List<Task> tasks { get; } = new List<Task>();

        public Station(string name)
        {
            this.name = name;
        }

        public void addTask(string taskName) {
            Task t = new Task(taskName, this);
            tasks.Add(t);
        }
    }

}
