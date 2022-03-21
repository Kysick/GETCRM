using System;
using System.Linq;

namespace GETCRM
{

//Raikov Maksim

    internal class Program
    {
        private class Excursion
        {
            private string _name;
            private int _priority;
            private double _duration;
            private double _ratio;

            public Excursion(string name, double duration, int priority)
            {
                Name= name;
                _priority= priority;
                Duration= duration;
                Ratio = priority + duration;
            }

            public double Ratio { get => _ratio; set => _ratio = value; }
            public string Name { get => _name; set => _name = value; }
            public double Duration { get => _duration; set => _duration = value; }
        }

        static void Main(string[] args)
        {
            int sleepTime = 8;
            double time = 48;
            time -= time / 24 * sleepTime;
       

            List<Excursion> eList = GetList();

            var sortedList = eList.OrderBy(l => l.Ratio);

            foreach (var exc in sortedList)
            {
                time -= exc.Duration;
                if (time < 0)
                {
                    break;
                }

                Console.WriteLine(exc.Name);
                
            } 
        }

        static List<Excursion> GetList()
        {

            return new List<Excursion>
            {
                new Excursion("Исаакиевский собор", 5, 10),
                new Excursion("Эрмитаж", 8, 11),
                new Excursion("Кунсткамера", 3.5, 4),
                new Excursion("Петропавловская крепость", 10, 7),
                new Excursion("Ленинградский зоопарк", 9, 15),
                new Excursion("Медный всадник", 1, 17),
                new Excursion("Казанский собор", 4, 3),
                new Excursion("Спас на Крови", 2, 9),
                new Excursion("Зимний дворец Петра I", 7, 12),
                new Excursion("Зоологический музей", 5.5, 6),
                new Excursion("Музей обороны и блокады Ленинграда", 2, 19),
                new Excursion("Русский музей", 5, 8),
                new Excursion("Навестить друзей", 12, 20),
                new Excursion("Музей восковых фигур", 2, 13),
                new Excursion("Литературно-мемориальный музей Ф.М. Достоевского", 4, 2),
                new Excursion("Екатерининский дворец", 1.5 , 5),
                new Excursion("Петербургский музей кукол", 1 , 14),
                new Excursion("Музей микроминиатюры «Русский Левша»", 3, 18),
                new Excursion("Всероссийский музей А.С. Пушкина и филиалы", 6 , 1),
                new Excursion("Музей современного искусства Эрарта", 7 , 16)
            };
        }
    }
}