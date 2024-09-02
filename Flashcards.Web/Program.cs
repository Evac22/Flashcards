using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using FluentValidation.AspNetCore;
using Flashcards.Application.Mappers;
using Flashcards.Infrastructure.Data;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();


builder.Services.AddAutoMapper(typeof(FlashcardsMappingProfile));


builder.Services.AddFluentValidationAutoValidation(config => config.ImplicitlyValidateChildProperties = true)
    .AddValidatorsFromAssemblyContaining<Program>();


builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
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
app.MapRazorPages();

app.Run();
