using CallForPapers.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CallForPapers.ApplicationLayer.Contracts;
public interface IApplicationDbContext
{
    DbSet<Application> Applications {get; set; }
}
