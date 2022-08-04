using System.Collections.Generic;

namespace WindowsFormsApp27
{
    // Класс заказов
    class Ord
    {
        public int Id { get; set; }
        public string Name { get; set; } // Название заказа
        public string Start { get; set; } // Пункт отправления
        public string Finish { get; set; } // Пункт назначения
        public int Length { get; set; } // Расстояние
        public int Width { get; set; } // Вес


        public Driver Drivers { get; set; }
        public int? DriverId { get; set; }
        public Car Cars { get; set; }
        public int? CarId { get; set; }

        
    }
}
