using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Calculate
    {
        /// <summary>
        /// первое число
        /// </summary>
        public double number1;
        /// <summary>
        /// второе число
        /// </summary>
        public double number2;
        /// <summary>
        /// констурктор без параметров
        /// </summary>
        public Calculate(){}
        /// <summary>
        /// конструктор с одним параметром
        /// </summary>
        /// <param name="number1">number1</param>
        public Calculate(double number1)
        {
            this.number1 = number1;
        }
        /// <summary>
        /// конструктор с двумя параметрами
        /// </summary>
        /// <param name="number1">number1</param>
        /// <param name="number2">number2</param>
        public Calculate(double number1,double number2) : this(number1)
        {
            this.number2 = number2;
        }
        public override string ToString()
        {
            return $"Первое число: {number1}\nВторое число: {number2}";
        }
        public double Calc()
        {
            return Math.Sqrt(number1*number2);
        }
    }
}
