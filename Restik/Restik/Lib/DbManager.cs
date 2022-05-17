﻿using Restik.Data;
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


    }
}
