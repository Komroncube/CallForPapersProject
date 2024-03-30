using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallForPapers.ApplicationLayer.Contracts;
using CallForPapers.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CallForPapers.Infrastructure;
public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    public DbSet<Application> Applications { get; set; }
}
