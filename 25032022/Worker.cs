using System;
using System.Collections.Generic;
using System.Text;

namespace _25032022
{
    class Worker:Person
    {
        public double salaryForHour;
        public int hour;

        public Worker(double salary, int hour, string name, string surname, byte age) : base(name,surname,age)
        {
            salaryForHour = salary;
            this.hour = hour;
        }
        public Worker(string name, string surname, byte age, double salaryForHour) : base(name, surname, age)
        {
            this.salaryForHour = salaryForHour;
        }


    }
}
