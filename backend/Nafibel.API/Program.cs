using Microsoft.EntityFrameworkCore;
using Nafibel.Data.Model;
using Nafibel.Data.Repositories;
using Nafibel.Services.Implematations;
using Nafibel.Services.Implementations;
using Nafibel.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

var conStr = builder.Configuration.GetConnectionString("DefaultConnection");
if (string.IsNullOrEmpty(conStr))
{
    throw new InvalidOperationException(
                       "Could not find a connection string named 'DefaultConnection'.");
}

// Add services to the container.
builder.Services.AddScoped<IHairStyleService ,HairStyleService>();
builder.Services.AddDbContext<NafibelDbContext>(options =>
     options.UseSqlServer(conStr));


builder.Services.AddScoped<IHairDresserService ,HairDresserService>();



builder.Services.AddScoped<IHairStylepPriceService, HairStylePriceService>();


builder.Services.AddScoped<IHairStyleNameLocaleService, HairStyleNameLocaleService>();

builder.Services.AddScoped<IClientService, ClientService>();

builder.Services.AddScoped<IAppointment,  AppointmentService>();

builder.Services.AddHealthChecks().AddSqlServer(conStr); ;


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();





// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapHealthChecks("/health");


app.UseAuthorization();

app.MapControllers();

app.Run();
