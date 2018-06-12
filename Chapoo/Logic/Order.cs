using System;
using Chapoo.Data;
using Chapoo.Model;

namespace Chapoo.Logic
{
    public class Order
    {
        public Model.Order GetOrderByTable(int tableId, int userId)
        {
            var orderMgr = new OrderDAO();

            //Get the highest order for that table
            //Get the highest order for that table that is already finished
            try
            {
                if (orderMgr.GetOrderByTableId(tableId) == orderMgr.GetOrderByTableIdFinished(tableId))
                {
                    //If those match => Table needs new order
                    return GetOrder(NewOrder(tableId, userId));
                }
            }
            catch (Exception)
            {
                //load the highest order for that table
                return GetOrder(orderMgr.GetOrderByTableId(tableId));
            }

            //load the highest order for that table
            return GetOrder(orderMgr.GetOrderByTableId(tableId));
        }

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

        public void CompleteOrder(int tableId)
        {
            var orderMgr = new OrderDAO();
            orderMgr.CompleteOrder(tableId);
        }

        public void AddNotes(int orderId, string note)
        {
            if (Validator.CheckCredentials(note))
            {
                var orderMgr = new OrderDAO();
                orderMgr.SetNotes(orderId, note);
            }
            else
            {
                throw new Exception("invalid input");
            }
        }

        public string GetNotes(int orderId)
        {
            var orderMgr = new OrderDAO();
            return orderMgr.GetNotes(orderId);
        }
    }
}
