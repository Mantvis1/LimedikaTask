using EFCoreInMemoryDbDemo;
using LimedikosTask;
using LimedikosTask.Server.Integrations;
using LimedikosTask.Server.Integrations.Interfaces;
using LimedikosTask.Server.Logging;
using LimedikosTask.Server.Repositories;
using LimedikosTask.Server.Repositories.Interfaces;
using LimedikosTask.Server.Services;
using LimedikosTask.Server.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApiContext>(options => options.UseSqlServer(@"Data Source=DESKTOP-S72TFCE;Initial Catalog=Test;Integrated Security=True;Encrypt=False"));

builder.Services.AddScoped<ICustomLogger, CustomLogger>();

builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<IFileReaderService, JsonFileReaderService>();
builder.Services.AddScoped<IPostRequestUrlBuilder, PostRequestUrlBuilder>();
builder.Services.AddScoped<IPostCodeIntegration, PostCodeIntegration>();

builder.Services.AddAutoMapper(typeof(MappingProfile));


var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
