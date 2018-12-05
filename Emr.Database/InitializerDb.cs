using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Emr.Database.Models;

namespace Emr.Database
{
    public class InitializerDb
    {
        private readonly DatabaseContext _context;

        public InitializerDb(DatabaseContext context)
        {
            _context = context;
        }

        public void CreateRoles()
        {
            if(_context.Roles.Any())
                return;
            var role = new Role
            {
                Name = "Admin",
                RoleId = 1
            };
            _context.Roles.Add(role);
            role = new Role
            {
                Name = "User",
                RoleId = 2
            };
            _context.Roles.Add(role);
            _context.SaveChanges();
        }
    }
}
