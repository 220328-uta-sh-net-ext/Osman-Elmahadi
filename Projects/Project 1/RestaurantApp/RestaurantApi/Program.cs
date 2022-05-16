using RestaurantBL;
using RestaurantDL;
//Connection is in the appSettings.json file
//string connectionStringFilePath = "../RestaurantDL/connection-string.txt";
//string connectionString = File.ReadAllText(connectionStringFilePath);

var builder = WebApplication.CreateBuilder(args);
//to access the appSettings.json file 
ConfigurationManager Config=builder.Configuration;
// Add services to the container.
builder.Services.AddMemoryCache();
builder.Services.AddControllers(options =>
    options.RespectBrowserAcceptHeader = true
     )
    .AddXmlSerializerFormatters(); // adding xml Formatter
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();//This is Middleware
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepo>(repo => new SqlRepository(Config.GetConnectionString("RestaurantDb")));
builder.Services.AddScoped<IRestaurantLogic, RestaurantLogic>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()||app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
