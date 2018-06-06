using System;
using Chapoo.Data;
using Chapoo.Model;

namespace Chapoo.Logic
{
    //Mathijs
    public class Table
    {
        public int GetTableOrder(int tableId)
        {
            var tableData = new Data.Table();

            if ((BestelStatus)tableData.GetBestelStatus(tableId) != BestelStatus.Afgerekend)
            {
                return tableData.GetOrder(tableId);
            }
            else
            {
                throw new OrderCompletedException("Order is already completed");
            }
        }

        public bool GetTableStatus(int tableId)
        {
            var tableData = new Data.Table();
            return tableData.TafelBezet(tableId);
        }

        public void SetTableOccupied(int tableId)
        {
            var tableData = new Data.Table();
            tableData.Tafelbezetten(tableId);
        }

        public void SetTableFree(int tableId)
        {
            var tableData = new Data.Table();
            tableData.TafelVrijGeven(tableId);
        }
    }
}
