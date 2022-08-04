using System.Data.Entity;
namespace WindowsFormsApp27
{
    // Класс базы данных
    class Db: DbContext
    {
        public Db() : base("DBConnection") { }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Ord> Ords { get; set; }
    }
}
