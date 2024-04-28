using EFCoreInMemoryDbDemo;
using LimedikosTask.Server.Models;

namespace LimedikosTask.Server.Logging;

public class CustomLogger(ApiContext context) : ICustomLogger
{
    private readonly ApiContext _context = context;

    public void Log(string message)
    {
        _context.Logs.Add(
            new CustomError
            {
                Created = DateTime.Now,
                Message = message
            });

        _context.SaveChanges();
    }
}
