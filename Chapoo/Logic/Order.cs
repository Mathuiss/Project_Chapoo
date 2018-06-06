using System;
using System.Collections.Generic;
using Chapoo.Data;
using Chapoo.Model;

namespace Chapoo.Logic
{
    public class Order
    {
        public int NewOrder(int tableId, int userId)
        {
            var orderMgr = new OrderDAO();
            return orderMgr.NewOrder(tableId, userId);
        }

        public Model.Order GetOrder(int orderId)
        {
            var orderMgr = new OrderDAO();
            return orderMgr.GetOrder(orderId);
        }
    }
}
