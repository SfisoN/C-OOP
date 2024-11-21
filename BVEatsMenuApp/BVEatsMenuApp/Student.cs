using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BVEatsMenuApp
{
    class Student
    {
        private string name, surname;
        private double id;

        public Student(double id)
        {

        }

        public Student(string name, string surname, double id)
        {
            this.name = name;
            this.surname = surname;
            this.Id1 = id;

        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public double Id1 { get => id; set => id = value; }

        public override string ToString()
        {
            return "Name: " + Name + "\tSurname: " + Surname + "\tID: " + Id1;
        }
    }
}
