using ApiAlmoxarifao.Api.DAL;
using ApiAlmoxarifao.Api.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AlmoxarifadoContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"));
});

builder.Services.AddScoped<ProdutoRepositroy>();
builder.Services.AddScoped<CategoriaRepository>();
builder.Services.AddScoped<DepartamentoRepository>();
builder.Services.AddScoped<FuncionaiosRepository>();
builder.Services.AddScoped<MotivoRepository>();
builder.Services.AddScoped<RequisicaoRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
