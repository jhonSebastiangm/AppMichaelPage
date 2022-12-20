using BM.Login;
using BM.Persona;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddTransient<IBMLogin, BMLogin>();
builder.Services.AddTransient<IBMPersona, BMPersona>();
var corsapp = "_corsapp";
builder.Services.AddCors(p => p.AddPolicy(corsapp, builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));
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
app.UseCors(corsapp);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();