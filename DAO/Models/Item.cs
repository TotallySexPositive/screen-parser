using System.Collections.Generic;
using SQLite;
using System.ComponentModel;

namespace ScreenParser.DAO.Models
{
    [Table("Item")]
    public class Item
    {
        [PrimaryKey, AutoIncrement, Column("ID")]
        public int ID { get; set; }
        [Unique]
        public string Name { get; set; }

    }
}
