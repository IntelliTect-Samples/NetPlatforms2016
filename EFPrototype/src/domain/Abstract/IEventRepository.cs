using EfPrototype.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfPrototype.Domain.Abstract
{
    public interface IEventRepository : IRepository<Event>
    {
    }
}
