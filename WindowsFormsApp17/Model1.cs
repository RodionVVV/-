﻿namespace WindowsFormsApp17
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using WindowsFormsApp17.Model;

    public class Model1 : DbContext
    {
        // Контекст настроен для использования строки подключения "Model1" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "WindowsFormsApp17.Model1" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "Model1" 
        // в файле конфигурации приложения.
        public Model1()
            : base("name=Model1")
        {

        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.
        public DbSet<Cinema> Сinema { get; set; }
        public DbSet<Film> Film { get; set; }
        public DbSet<FoodRevenue> Foodrev { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Show> Show { get; set; }
        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
