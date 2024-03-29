﻿using WebApplication1.Dtos;
using WebApplication1.Repositories;

namespace WebApplication1.Application.Feature.Order.GetOrderById;

public class GetOrderByIoRepository : IGetOrderByIdRepository
{
    public Task<OrderDto> findByIdAsync(int requestOrderId)
    {
        var result = MockOrderRepository.GetOrder().First(x => x.Id == requestOrderId);
        return result == null 
            ? null
            : Task.FromResult(new OrderDto
            {
                Id = result.Id,
                Name = result.Name
            });
    }
}