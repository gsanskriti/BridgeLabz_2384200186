using BusinessLayer.Service;
using RepositoryLayer.Service;

var builder = WebApplication.CreateBuilder(args);

// Register services
builder.Services.AddScoped<IUserRegistrationBL, UserRegistrationBL>();
builder.Services.AddScoped<IUserRegistrationRL, UserRegistrationRL>();

// Add services to the container.
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
