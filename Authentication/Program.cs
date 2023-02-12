using Authentication.Authorization;
using Authentication.Services;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

var builder = WebApplication.CreateBuilder(args);
//add services to DI container 
{
    var services=builder.Services;
    services.AddCors();
    services.AddControllers();

    //configure DI for application services
    services.AddScoped<IUserService,UserService>();

}

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<TodoContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("WebApiDatabase")!));
var app = builder.Build();

//configure HTTP request pipeline
{
    app.UseCors(x => x
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
    //coustome basic Auth middleware
    app.UseMiddleware<BasicAuthMiddleware>();
    app.MapControllers();
}

if(builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
