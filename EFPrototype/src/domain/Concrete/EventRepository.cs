using EfPrototype.Domain.Abstract;
using EfPrototype.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfPrototype.Domain.Concrete
{
    public class EventRepository : RepositoryBase<Event>, IEventRepository
    {
        public EventRepository(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
