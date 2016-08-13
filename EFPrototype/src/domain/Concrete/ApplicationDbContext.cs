using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using EfPrototype.Domain.Models;

namespace EfPrototype.Domain.Concrete
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, int>
    {
        public DbSet<Event> Events { get; set; }
        //public DbSet<SpeakerEvent> SpeakerEvents { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
