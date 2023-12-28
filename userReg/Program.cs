using Microsoft.EntityFrameworkCore;
using userReg.data;
using userReg.repository;
using userReg.service;
using userReg.utility;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddHttpContextAccessor();
builder.Services.AddSwaggerGen();

// Add DbContext
builder.Services.AddDbContext<ApplicantDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("UserDBConnectionString")));

builder.Services.AddScoped<IApplicantRepository, ApplicantRepository>();
builder.Services.AddScoped<IApplicantService, ApplicantService>();
builder.Services.AddScoped<ApplicantUtility>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(options =>
{
    options.AllowAnyHeader();
    options.AllowAnyOrigin();
    options.AllowAnyMethod();
});

app.UseAuthorization();

app.UseStaticFiles();
app.MapControllers();

app.Run();