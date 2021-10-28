using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2810
{
    class Student
    {
        public string Name { get; }
        public string Surname { get; }

        private static int _id = 0;

        public int Id { get; }

        private int mark;

        public int Mark
        {

            get
            {
                return mark;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    mark = value;
                    Console.WriteLine("Student Mark added");
                    return;
                }
                Console.WriteLine("Please enter correct Mark");
            }
        }

        public Student(string name ,string surname)
        {
            Name = name;
            Surname = surname;
            _id++;
            Id = _id;
        }

        public override string ToString()
        {
            return $"{Surname} {Name} {Id} {Mark}";
        }
    }
}
