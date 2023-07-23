using WebApplication1.Application.Domain;
using WebApplication1.Dtos;

namespace WebApplication1.Repositories;

public static class MockOrderRepository
{
    private static List<Order> Orders { get; } = new()
    {
        new Order() { Id = 1, Name = "Order 1" },
        new Order() { Id = 2, Name = "Order 2" },
        new Order() { Id = 3, Name = "Order 3" },
        new Order() { Id = 4, Name = "Order 4" },
        new Order() { Id = 5, Name = "Order 5" },
    };

    public static IEnumerable<Order> GetOrder()
    {
        return Orders;
    }

    public static void AddOrder(Order order)
    {
        Orders.Add(order);
    }

    public static List<Order> GetAll()
    {
        return Orders;
    }
}