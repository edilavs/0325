using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    class Worker:Person 
    {
        public Worker(double payment,string name,string surname,byte age) : base(name, surname, age)
        {
            this.Payment = payment;
        }
        public double  Payment;
        public int Hours;

        public double getSalaryMonthly()
        {
            return Payment * Hours;
        }

    }
}
