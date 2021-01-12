using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWPF.Model
{
    class Complex_number
    {
        private double a1; //Действительная часть числа
        private double b1; //Мнимая часть числа

        //Конструктор
        public Complex_number (double real, double imaginary)
        {
            this.a1 = real;
            this.b1 = imaginary;
        }

        public double A1
        {
            get { return a1; }
            set { a1 = value; }
        }

        double B1
        {
            get { return b1; }
            set { b1 = value; }
        }

        //Функция вычисления модуля
        public double ABC()
        {
            return Math.Sqrt(a1 * a1 + b1 * b1);
        }

        //Функция получения обратного числа
        public double getReverseNumberA()
        {
            double d = ((a1 * a1) + (b1 * b1));
            return a1 / d;
        }
        public double getReverseNumberB()
        {
            double d = ((a1 * a1) + (b1 * b1));
            return -b1 / d;
        }
    }
}
