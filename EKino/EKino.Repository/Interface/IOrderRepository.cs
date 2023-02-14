using EKino.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EKino.Repository.Interface
{
    public interface IOrderRepository
    {
        List<Order> getAllOrders();
        Order getOrderDetails(BaseEntity model);
    }
}
