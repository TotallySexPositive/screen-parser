using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenParser.DAO.Models
{
    public class Sale
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [Indexed]
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public bool IsHq { get; set; }
        public string Buyer { get; set; }
        public DateTime Date { get; set; }

    }
}
