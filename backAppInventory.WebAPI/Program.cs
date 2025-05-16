using backAppInventory.Application;
using backAppInventory.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

// Support to MVC Controller
builder.Services.AddControllers();
// Support to Swagger
builder.Services.AddEndpointsApiExplorer();
// Create documentation for Swagger
builder.Services.AddSwaggerGen();

// Registration Services
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddServices();

// Dabatase Service
/*builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));*/

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();