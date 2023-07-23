using System.Reflection;
using WebApplication1.Application.Feature.Order.CreateOrder;
using WebApplication1.Application.Feature.Order.GetAllOrder;
using WebApplication1.Application.Feature.Order.GetOrderById;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddTransient<IGetAllOrderRepository, GetAllOrderRepository>();
builder.Services.AddTransient<IGetOrderByIdRepository, GetOrderByIoRepository>();
builder.Services.AddTransient<ICreateOrderRepository, CreateOrderRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();