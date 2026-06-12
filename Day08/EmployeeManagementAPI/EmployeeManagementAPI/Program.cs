using EmployeeManagementAPI.Services;
using EmployeeManagementAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddScoped<EmployeeRepository>();

builder.Services.AddScoped<EmployeeService>();
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
