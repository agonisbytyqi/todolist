using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList
{
    public class Data
    {
        public static List<ToDoItem> ToDoList { get; set; }

        static Data()
        {
            ToDoList = new List<ToDoItem>();
        }
    }
}
