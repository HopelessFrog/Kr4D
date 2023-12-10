
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiprocessor_And_Multithreaded_Programming
{
    public static class ConectString
    {
        public static string? conectionString;
    }
    public class ApplicationContext : DbContext // подключение к бд
    {

        public DbSet<Trains> Trains { get; set; } = null!;  // коллекция всех сущностей, которые мы запрашиваем из бд
        public DbSet<WhereFromWay> WhereFromWays { get; set; } = null!; 
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)  
        {
            optionsBuilder.UseSqlite(ConectString.conectionString); 
        }
    }
    public class DbManagement 
    {
        public static void AddWayToTrain(Trains trains, string whereWay) // Добавление путей
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                WhereFromWay? wfw = db.WhereFromWays.FirstOrDefault(p => p.WhereWay == whereWay);
                trains.WhereWay = wfw;
                db.Trains.Add(trains);
                db.SaveChanges();

            }
        }
        public static bool CheckWayExist(string whereWay) //проверяем существование пути
        {
            using (ApplicationContext db = new ApplicationContext()) //контекст данных для взаимодействия с бд
            {
                WhereFromWay? wfw = db.WhereFromWays.FirstOrDefault(p => p.WhereWay == whereWay); // проверяем, есть ли в бд конец пути
                
                if (wfw != null ) { return true; }
                return false;
            }
        }
        
        public static void AddWhereWay(string whereWay) //Добавляем конец пути
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                WhereFromWay? ww = new WhereFromWay(whereWay);
                db.WhereFromWays.Add(ww);
                db.SaveChanges();
            }
        }
        public static List<Trains> GetTrainsList() //получение списка поездов
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();//создаст бд, если её нет. 
                return db.Trains.Include(u => u.WhereWay).ToList(); 
            }
        }
        public static Trains GetTrain(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated(); //инициализация бд
                return db.Trains.Include(u => u.WhereWay).Where(u => u.Id == id).First(); //возвращаем список поездов, удовлетворяющих условию

            }
        }

        public static void ChangeTrains(Trains train, string finish, Trains newTrain) // выборка поездов
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                var railway =  db.Trains.Include(u => u.WhereWay).Where(u => u.Id == train.Id).First(); // первое значение из бд с условиями
                WhereFromWay? wfw = db.WhereFromWays.FirstOrDefault(from => from.WhereWay == finish); // кладутся данные в созданный объект класса
                railway.TrainsDOC = newTrain.TrainsDOC; // присваиваются значения в объект типа поезда
                railway.TrainsName = newTrain.TrainsName;
                railway.TrainsType = newTrain.TrainsType;
                railway.Departure = newTrain.Departure;
                railway.Arrival = newTrain.Arrival;
                railway.WhereWay = wfw;
                db.SaveChanges(); //база данных сохраняет значения
            }
        }

        public static void DeleteTrain(Trains train) // удаление поезда
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                var railway = db.Trains.Include(u => u.WhereWay).Where(u => u.Id == train.Id).First();// переменная с неявням типом
                db.Trains.Remove(railway);
                db.SaveChanges();
            }
        }
        public static List<WhereFromWay> GetWayList() //получение списка концов
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                return db.WhereFromWays.ToList();
            }
        }

        public static List<Trains> GetTrainsWayX(string finish) //полуение поездов с конечным назнаением(сама выборка)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Trains.Include(u => u.WhereWay).Where(u => u.WhereWay!.WhereWay == finish).ToList(); // получение списка, где конечный путь задан
            }
        }

        public static List<Trains> GetTrainsTypeX(string type) //получение поездов определённого типа
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Trains.Include(u => u.WhereWay).Where(u => u.TrainsType == type).ToList();
            }
        }

        public static List<Trains> GetTrainsWayAndTypeX(string finish, string type) // получение полной выборки(тип+конец)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Trains.Include(u => u.WhereWay).Where(u => u.WhereWay!.WhereWay == finish && u.TrainsType == type).ToList();
            }
        }

        public static void RemoveDb()//удаление бд(для тестов)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureDeleted();
            }
        }
        public static void CreateDb()//создание бд(для тестов)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
            }
        }
    }
}
