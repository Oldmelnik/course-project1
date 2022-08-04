using System.Collections.Generic;
using System;

namespace WindowsFormsApp27
{
    // Класс Водителей
    class Driver
    {
        public int Id { get; set; }
        public string FIO { get; set; } // ФИО
        public string Passport { get; set; } // Номер паспорта
        public int SecDr { get; set; } // Напарник
        public int ClassDr { get; set; } // Классность
        public int Exp { get; set; } // Стаж работы

        public ICollection<Ord> Ords { get; set; }
        public Driver()
        {
            Ords = new List<Ord>();
        }

    }
}
