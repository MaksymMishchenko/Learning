using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.DataContexts
{
    internal class UserIdentityContext : IdentityDbContext
    {
        public UserIdentityContext(DbContextOptions<UserIdentityContext> options) : base(options)
        {
        }
    }
}
