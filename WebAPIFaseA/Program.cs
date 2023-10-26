using Microsoft.EntityFrameworkCore;
using WebAPIFaseA.DataSource;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//builder.Services.AddDbContext<NorthwindContext>(options =>
//{
//    //modo 1
//    string? cnNorthwind = builder.Configuration.GetConnectionString("cnNW");
//    //modo 2
//    //string cnNorthwind2 = builder.Configuration.GetValue<string>("ConnectionStrings:cnNW");

//    options.UseSqlServer(cnNorthwind);

//});
//builder.Services.AddScoped<NorthwindContext, NorthwindContext>();



builder.Services.AddDbContext<AmazonContext>(options =>
{
    //modo 1
    string? cnAmazon = builder.Configuration.GetConnectionString("cnAmazon");
    //modo 2
    //string cnNorthwind2 = builder.Configuration.GetValue<string>("ConnectionStrings:cnNW");


    options.UseSqlServer(cnAmazon);


});
builder.Services.AddScoped<AmazonContext, AmazonContext>();




////CONTEXT per SQL server
//builder.Services.AddDbContext<AmazonContext>(options =>
//{
//    string cnAmazon = builder.Configuration.GetConnectionString("cnAmazon");
//options.UseSqlServer(cnAmazon);
//});

//builder.Services.AddScoped<AmazonContext, AmazonContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
