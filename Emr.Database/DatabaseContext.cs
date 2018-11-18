using System;
using Emr.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Emr.Database
{
    /// <summary>
    /// Класс для работы с бд
    /// </summary>
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> opt):base(opt)
        {
            
        }

        /// <summary>
        /// Так объявляется таблица в бд
        /// </summary>
        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

    }
}
