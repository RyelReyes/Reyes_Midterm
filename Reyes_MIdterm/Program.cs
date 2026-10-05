using CommunityLibraryAPI.Data;
using CommunityLibraryAPI.Interfaces.Services;
using CommunityLibraryAPI.Services;
using Microsoft.EntityFrameworkCore;
using Reyes_Midterm.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<LibraryDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ILoanService, LoanService>();

var app = builder.Build();

app.UseSwagger();

app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();