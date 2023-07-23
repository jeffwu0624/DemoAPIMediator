using WebApplication1.Dtos;

namespace WebApplication1.Repositories;

public static class MockOrderRepository
{
    private static List<OrderDto> Orders { get; } = new()
    {
        new OrderDto() { Id = 1, Name = "Order 1" },
        new OrderDto() { Id = 2, Name = "Order 2" },
        new OrderDto() { Id = 3, Name = "Order 3" },
        new OrderDto() { Id = 4, Name = "Order 4" },
        new OrderDto() { Id = 5, Name = "Order 5" },
    };

    public static IEnumerable<OrderDto> GetOrder()
    {
        return Orders;
    }

    public static void AddOrder(OrderDto order)
    {
        Orders.Add(order);
    }

    public static List<OrderDto> GetAll()
    {
        return Orders;
    }
}