using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using EfPrototype.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfPrototype.Domain.Models
{
    public class Role : IdentityRole<int>, IEntity
    {
    }
}
