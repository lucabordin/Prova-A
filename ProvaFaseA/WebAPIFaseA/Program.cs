using Microsoft.EntityFrameworkCore;
using WebAPIFaseA.DataSource;
using WebAPIFaseA.Repository;
using WebAPIFaseA.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ProvaAContext>(options =>
{
    string? cnProvaA = builder.Configuration.GetConnectionString("cnProvaA");
    options.UseSqlServer(cnProvaA);
});

builder.Services.AddScoped<ProvaAContext, ProvaAContext>();
builder.Services.AddScoped<IProdottiService, ProdottiService>();
builder.Services.AddScoped<IClientiService, ClientiService>();
builder.Services.AddScoped<ICarrelloService, CarrelloService>();
builder.Services.AddScoped<IRepository, Repository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
