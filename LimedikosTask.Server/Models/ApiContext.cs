using LimedikosTask.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreInMemoryDbDemo;

public class ApiContext : DbContext
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<CustomError> Logs { get; set; }

    public ApiContext(DbContextOptions<ApiContext> options) : base(options)
    {
    }
}