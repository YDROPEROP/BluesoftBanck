using Bluesoft_Bank.BLL.Servicios;
using Bluesoft_Bank.DAL.DataContext;
using Bluesoft_Bank.DAL.Repository;
using Bluesoft_Bank.MODELS.DTOs;
using Microsoft.EntityFrameworkCore;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigions";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.AllowAnyOrigin()
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                      });
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BluesoftBankContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("CadenaSQL"));
});

builder.Services.AddScoped<IGenericRepository<EmpresaDTO>, EmpresaRepository>();
builder.Services.AddScoped<IGenericRepository<PersonaNaturalDTO>, PersonaNaturalRepository>();
builder.Services.AddScoped<IGenericRepository<Transaccion>, TransaccionRepository>();

builder.Services.AddScoped<IEmpresaService, EmpresaService>();
builder.Services.AddScoped<IPersonaNaturalService, PersonanaturalService>();
builder.Services.AddScoped<ITransaccionService, TransaccionService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(MyAllowSpecificOrigins);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
