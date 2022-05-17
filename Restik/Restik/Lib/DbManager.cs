using Microsoft.EntityFrameworkCore;
using Restik.Data;
using Restik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restik.Lib
{
    public static class DbManager
    {
        public static List<User> GetUsers()
        {
            using (var db = new ApplicationContext())
            {
                return db.Users.ToList();
            }
        }

        public static User GetUser(string name)
        {
            using (var db = new ApplicationContext())
            {
                return db.Users.SingleOrDefault(U => U.FullName == name);
            }
        }

        public static User GetUser(string mail, string password)
        {
            using (var db = new ApplicationContext())
            {
                return db.Users.SingleOrDefault(U => U.Mail == mail && U.Password == password);
            }
        }

        public static void AddUser(User user)
        {
            using (var db = new ApplicationContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        public static void DeleteUser(string FullName)
        {
            using (var db = new ApplicationContext())
            {
                var RequiredUser = db.Users.SingleOrDefault(U => U.FullName == FullName);
                db.Users.Remove(RequiredUser);
                db.SaveChanges();
            }
        }

        public static void UpdateUser(User NewUser)
        {
            using (var db = new ApplicationContext())
            {
                var RequiredUser = db.Users.SingleOrDefault(U => U.Id == NewUser.Id);

                RequiredUser.FullName = NewUser.FullName;
                RequiredUser.Mail = NewUser.Mail;
                RequiredUser.Type = NewUser.Type;
                RequiredUser.Password = NewUser.Password;
                RequiredUser.Phone = NewUser.Phone;

                db.Users.Update(RequiredUser);
                db.SaveChanges();
            }
        }

        public static List<Hall> GetHalls()
        {
            using (var db = new ApplicationContext())
            {
                return db.Halls.ToList();
            }
        }

        public static Hall GetHall(string name)
        {
            using (var db = new ApplicationContext())
            {
                return db.Halls.SingleOrDefault(H => H.Name == name);
            }
        }

        public static void AddHall(Hall hall)
        {
            using (var db = new ApplicationContext())
            {
                db.Halls.Add(hall);
                db.SaveChanges();
            }
        }

        public static void DeleteHall(string Name)
        {
            using (var db = new ApplicationContext())
            {
                var RequiredHall = db.Halls.SingleOrDefault(H => H.Name == Name);
                db.Halls.Remove(RequiredHall);
                db.SaveChanges();
            }
        }

        public static void UpdateHall(Hall NewHall)
        {
            using (var db = new ApplicationContext())
            {
                var RequiredHall = db.Halls.SingleOrDefault(H => H.Id == NewHall.Id);

                RequiredHall.Name = NewHall.Name;
                RequiredHall.ImagePath = NewHall.ImagePath;

                db.Halls.Update(RequiredHall);
                db.SaveChanges();
            }
        }

        public static List<Table> GetTables()
        {
            using (var db = new ApplicationContext())
            {
                return db.Tables.ToList();
            }
        }

        public static Table GetTable(string name)
        {
            using (var db = new ApplicationContext())
            {
                return db.Tables.Include(T => T.Hall).SingleOrDefault(T => T.Name == name);
            }
        }

        public static void AddTable(Table table)
        {
            using (var db = new ApplicationContext())
            {
                var AddedHall = table.Hall;
                table.Hall = new Hall();
                
                var ExistedHall = db.Halls.SingleOrDefault(H => H.Id == AddedHall.Id);
                table.Hall = ExistedHall;
                

                db.Tables.Add(table);
                db.SaveChanges();
            }
        }

        public static void DeleteTable(string Name)
        {
            using (var db = new ApplicationContext())
            {
                var RequiredTable = db.Tables.SingleOrDefault(T => T.Name == Name);
                db.Tables.Remove(RequiredTable);
                db.SaveChanges();
            }
        }

        public static void UpdateTable(Table NewTable)
        {
            using (var db = new ApplicationContext())
            {
                var RequiredTable = db.Tables.SingleOrDefault(H => H.Id == NewTable.Id);
                RequiredTable.Name = NewTable.Name;

                var AddedHall = NewTable.Hall;
                RequiredTable.Hall = new Hall();

                var ExistedHall = db.Halls.SingleOrDefault(H => H.Id == NewTable.HallId);
                RequiredTable.Hall = ExistedHall;
                RequiredTable.HallId = ExistedHall.Id;

                db.Tables.Update(RequiredTable);
                db.SaveChanges();
            }
        }

        public static List<Place> GetPlaces()
        {
            using (var db = new ApplicationContext())
            {
                return db.Places.ToList();
            }
        }

        public static Place GetPlace(string name)
        {
            using (var db = new ApplicationContext())
            {
                return db.Places.Include(P => P.Table).Include(P => P.Booking).SingleOrDefault(P => P.Name == name);
            }
        }

        public static void AddPlace(Place place)
        {
            using (var db = new ApplicationContext())
            {
                var AddedTable = place.Table;
                place.Table = new Table();

                var ExistedTable = db.Tables.SingleOrDefault(P => P.Id == AddedTable.Id);
                place.Table = ExistedTable;

                var AddedBooking = place.Booking;
                place.Booking = null;

                if (AddedBooking != null)
                {
                    var ExistedBooking = db.Bookings.SingleOrDefault(B => B.Id == AddedBooking.Id);
                    place.Booking = ExistedBooking;
                }


                db.Places.Add(place);
                db.SaveChanges();
            }
        }

        public static void DeletePlace(string Name)
        {
            using (var db = new ApplicationContext())
            {
                var RequiredPlace = db.Places.SingleOrDefault(P => P.Name == Name);
                db.Places.Remove(RequiredPlace);
                db.SaveChanges();
            }
        }

        public static void UpdatePlace(Place NewPlace)
        {
            using (var db = new ApplicationContext())
            {
                var RequiredPlace = db.Places.SingleOrDefault(H => H.Id == NewPlace.Id);
                RequiredPlace.Name = NewPlace.Name;
                RequiredPlace.Price = NewPlace.Price;

                var AddedTable = NewPlace.Table;
                RequiredPlace.Table = new Table();

                var ExistedTable = db.Tables.SingleOrDefault(T => T.Id == NewPlace.TableId);
                RequiredPlace.Table = ExistedTable;
                RequiredPlace.TableId = ExistedTable.Id;

                var AddedBooking = NewPlace.Booking;
                RequiredPlace.Booking = null;
                RequiredPlace.BookingId = null;

                if (AddedBooking != null) {
                    var ExistedBooking = db.Bookings.SingleOrDefault(B => B.Id == NewPlace.BookingId);
                    RequiredPlace.Booking = ExistedBooking;
                    RequiredPlace.BookingId = ExistedBooking.Id;
                }

                db.Places.Update(RequiredPlace);
                db.SaveChanges();
            }
        }

        ///

        public static List<Booking> GetBookings()
        {
            using (var db = new ApplicationContext())
            {
                return db.Bookings.Include(B => B.Event)
                    .Include(B => B.User)
                    .Include(B => B.Dishes)
                    .Include(B => B.Places)
                    .Include(B => B.Payments).ToList();
            }
        }
        public static Booking GetBooking(string number)
        {
            using (var db = new ApplicationContext())
            {
                return db.Bookings.Include(B => B.Event)
                    .Include(B => B.User)
                    .Include(B => B.Dishes)
                    .Include(B => B.Places)
                    .Include(B => B.Payments).SingleOrDefault(B => B.Number == number);
            }
        }
    }
}
