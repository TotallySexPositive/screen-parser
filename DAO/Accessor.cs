using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using ScreenParser.DAO.BindingSources;
using ScreenParser.DAO.Models;
using SQLite;

namespace ScreenParser.DAO
{
    
    class Accessor
    {
        public static string dbstring = "database.db";
        public SQLiteConnection db;
        public Accessor()
        {
            db = new SQLiteConnection(dbstring);
            db.CreateTable<Item>();
            db.CreateTable<Sale>();
        }

        public Item AddItem(Item item)
        {
            //See if the item is in the db already
            Item i = QueryItems(this.db, item.Name);
            if (i == null)
            {
                db.Insert(item);
                return QueryItems(this.db, item.Name);
            }
            return null;
        }

        public void AddSale(Sale sale)
        {
            db.Insert(sale);
        }

        public static List<Item> GetItems(SQLiteConnection db)
        {
            return db.Table<Item>().ToList();
        }

        public static List<Sale> GetSales(SQLiteConnection db)
        {
            return db.Table<Sale>().ToList();
        }
        public static Item QueryItems(SQLiteConnection db, string name)
        {
            return db.Table<Item>().Where(t => t.Name == name).FirstOrDefault();
        }

        public static List<Sale> QuerySales(SQLiteConnection db, int ItemId)
        {
            return db.Table<Sale>().Where(t => t.ItemID == ItemId).ToList();
        }


    }
}
