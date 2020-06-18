using ScreenParser.DAO.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenParser.DAO.BindingSources
{
    public class SaleTable
    {
        private List<Sale> sales;
        private Item item;
        public SaleTable(Item item, List<Sale> sales)
        {
            this.sales = sales;
            this.item = item;
        }

        public DataTable MakeTable()
        {
            DataTable table = new DataTable(item.Name);
            table.Columns.Add(makeColumn("High Quality", "System.Boolean"));
            table.Columns.Add(makeColumn("Quantity", "System.Int32"));
            table.Columns.Add(makeColumn("Price", "System.Int32"));
            table.Columns.Add(makeColumn("Buyer", "System.String"));
            table.Columns.Add(makeColumn("Date", "System.DateTime"));

            DataSet dataset = new DataSet();
            dataset.Tables.Add(table);
            DataRow row;
            foreach (Sale sale in sales)
            {
                row = table.NewRow();
                row["High Quality"] = sale.IsHq;
                row["Quantity"] = sale.Quantity;
                row["Price"] = sale.Price;
                row["Buyer"] = sale.Buyer;
                row["Date"] = sale.Date;
                table.Rows.Add(row);
            }
            return table;
        }

        private DataColumn makeColumn(string name, string type)
        {
            DataColumn column = new DataColumn();
            column.DataType = System.Type.GetType(type);
            column.ColumnName = name;
            column.ReadOnly = true;
            column.Unique = false;
            return column;
        }
    }
}
