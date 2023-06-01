using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emplo
{
    public class Employee
    {
        private string _fio;
        private int _departament;
        private double _salary;
        private int _id;
        private static int count = 0;

        public Employee(string fio, double salary, int departament)
        {
            _departament = departament;
            _salary = salary;
            _fio = fio;
            _id = count++;

        }

        public string Fio
        {
            get => _fio;
            set => _fio = value;

        }

        public int Department
        {
            get => _departament;
            set => _departament = value;

        }

        public double Salary
        {
            get => _salary;
            set => _salary = value;

        }

        public int Id { get => _id; }


    }
}
