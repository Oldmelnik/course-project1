using System.Collections.Generic;
using System;

namespace WindowsFormsApp27
{
    // Класс трейлеров
    class Car
    {
        public int Id { get; set; }
        public string Model { get; set; } // Марка
        public string Firm { get; set; } // Фирма
        public string Num { get; set; } // Гос. Номер
        public int Capacity { get; set; } // Грузоподъемность
        public int Consumption  { get; set; } // Расход топлива
        public int LenTruck { get; set; } // Длина прицепа
        public double Price { get; set; } // Рублей за километр
        public ICollection<Ord> Ords { get; set; }
        public Car()
        {
            Ords = new List<Ord>();
        }
    }
}
