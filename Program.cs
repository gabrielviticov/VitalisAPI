using Microsoft.EntityFrameworkCore;
using VitalisAPI.Data;
using VitalisAPI.Entities.Models;
using static System.Console;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(
    opts => opts.UseSqlite(
        builder.Configuration.GetConnectionString(
            "DbConnection"
        )
    )
);

var doctor = new DoctorModel();
{
    doctor.Person = new PersonModel("Viktor Hugo", "da Silva Santos", "example@example.com", "11 957420313");
    doctor.Crm = "045321-1";
    doctor.StartAt = new DateOnly(1999, 01, 04);
    doctor.EndAt = new DateOnly(2004, 09, 15);
    WriteLine(doctor.ToString());
}

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
