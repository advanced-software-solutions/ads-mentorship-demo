using System;
using System.Collections.Generic;
using System.Text;

namespace ASMentorship
{
    public class Student
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!value.Contains('$'))
                {
                    name = value;
                }
            }
        }
        public DateTime DoB { get; set; }
    }
}