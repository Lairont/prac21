using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Time
    {
        /// <summary>
        /// поле количества часов
        /// </summary>
        public int hours;
        /// <summary>
        /// поле количества минут
        /// </summary>
        public int minutes;
        /// <summary>
        /// поле количества секунд
        /// </summary>
        public int seconds;
        /// <summary>
        /// конструктор без параметров
        /// </summary>
        public Time()
        { }
        /// <summary>
        /// констурктор с одним параметром
        /// </summary>
        /// <param name="hours">hours</param>
        public Time(int hours)
        {
            this.hours = hours;
        }
        /// <summary>
        /// конструктор с двумя параметрами
        /// </summary>
        /// <param name="hours">hours</param>
        /// <param name="minutes">minutes</param>
        public Time(int hours, int minutes) : this(hours)
        {
            this.minutes = minutes;
        }
        /// <summary>
        /// конструктор с тремя параметрами
        /// </summary>
        /// <param name="hours">hours</param>
        /// <param name="minutes">minutes</param>
        /// <param name="seconds">seconds</param>
        public Time(int hours, int minutes, int seconds) : this(hours, minutes)
        {
            this.seconds = seconds;
        }
        public override string ToString()
        {
            return $"Количество часов: {hours}, Количество минут: {minutes}, Количество секунд: {seconds}";
        }
        public int Totalminutes()
        {
            return hours * 60 + minutes;
        }
        public int Totalseconds()
        {
            return (hours * 3600) + (minutes * 60) + seconds;
        }
    }
}
