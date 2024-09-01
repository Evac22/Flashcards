using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using FluentValidation.AspNetCore;
using AutoMapper;
using Flashcards.Application.Mappers;
using Flashcards.Core.Entities;
using Flashcards.Infrastructure.Data;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);

// Добавление DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Добавление Identity
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

// Добавление AutoMapper
builder.Services.AddAutoMapper(typeof(FlashcardsMappingProfile));

// Добавление FluentValidation
builder.Services.AddFluentValidationAutoValidation(config => config.ImplicitlyValidateChildProperties = true)
    .AddValidatorsFromAssemblyContaining<Program>();
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

// Добавление контроллеров с представлениями (если нужны представления)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Конфигурация пайплайна HTTP-запросов
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
