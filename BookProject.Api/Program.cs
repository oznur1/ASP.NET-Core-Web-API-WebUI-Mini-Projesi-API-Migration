using BookProject.Api.Data;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi


//Database baglantısı
builder.Services.AddDbContext<AppDbContext>(options => {

    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddSwaggerGen();//ise bu endpoint bilgilerini kullanarak OpenAPI/Swagger dokümantasyonu oluşturur. Böylece API endpoint'lerini Swagger UI üzerinden görüntüleyip test edebiliriz.

builder.Services.AddEndpointsApiExplorer(); //AddEndpointsApiExplorer() API endpoint'lerinin keşfedilmesini sağla

var app = builder.Build();

// Configure the HTTP request pipeline.


app.UseHttpsRedirection();
app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.RoutePrefix = string.Empty;
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
});

app.UseAuthorization();

app.MapControllers();

app.Run();
