using System;
using Chapoo.Data;

namespace Chapoo.Logic
{
    //Mathijs
    public class Table
    {
        public bool GetTableStatus(int tableId)
        {
            var tableData = new TafelDAO();
            return tableData.TafelVrij(tableId);
        }

        public void SetTableOccupied(int tableId)
        {
            var tableData = new TafelDAO();
            tableData.Tafelbezetten(tableId);
        }

        public void SetTableFree(int tableId)
        {
            var tableData = new TafelDAO();
            tableData.TafelVrijGeven(tableId);
        }
    }
}
