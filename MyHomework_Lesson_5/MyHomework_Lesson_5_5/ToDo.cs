using System;
using System.Collections.Generic;
using System.Text;

namespace MyHomework_Lesson_5_5
{
    public class ToDo
    {
        public bool IsDone { get; set; }
        public string Title { get; set; }

        public ToDo(string title, bool isDone)
        {
            Title = title;
            IsDone = isDone;
        }

    }
}
