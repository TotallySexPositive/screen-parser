using ScreenParser.DAO;
using System;

using System.Windows.Forms;
using SQLite;
using ScreenParser.DAO.Models;
using System.ComponentModel;
using ScreenParser.DAO.BindingSources;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Windows.Forms.VisualStyles;
using Microsoft.SqlServer.Server;
using System.Globalization;

namespace ScreenParser
{
    
    public partial class Viewer : Form
    {
        private readonly Random _random = new Random();
        private SQLiteConnection db = new SQLiteConnection(Accessor.dbstring);
        private Accessor a = new Accessor();
        private ItemList items = new ItemList();
        private SaleTable saleTable;
        public Viewer()
        {
            InitializeComponent();
            
            foreach (Item i in Accessor.GetItems(a.db).OrderBy(i=>i.Name).ToList())
            {
                items.Add(i);
            }

            listBox1.DataSource = items;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Name";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            Item i = a.AddItem(new Item()
            {
                Name = text
            });
            if (i == null)
            {
                return;
            }
            items.Add(i);
            items.ResetBindings();
            System.Console.WriteLine("Added an item");
            textBox2.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item i = (Item)listBox1.SelectedItem;
            System.Console.WriteLine("Selected item: " + i.Name);
            //Do the sales lookup (random data for now)
            List<Sale> sales = new List<Sale>();
            for (int j = 0; j < 10; j++)
            {
                sales.Add(new Sale()
                {
                    ItemID = i.ID,
                    Quantity = _random.Next(99),
                    Price = _random.Next(1000),
                    IsHq = _random.Next(2) >= 1,
                    Buyer = _random.Next(100000000).ToString(),
                    Date = DateTime.Now
                });
            }
            saleTable = new SaleTable(i, sales);
            DataTable t = saleTable.MakeTable();
            salesgrid.DataSource = saleTable.MakeTable();
            List<int> prices = new List<int>();
            List<int> quantity = new List<int>();
            foreach (Sale sale in sales)
            {
                prices.Add(sale.Price);
                quantity.Add(sale.Quantity);
            }
            prices.Sort();
            max_price.Text = prices.Max().ToString();
            min_price.Text = prices.Min().ToString();
            median_price.Text = prices[(int)(prices.Count / 2)].ToString();
            sold_per_day.Text = quantity.Average().ToString();
        }

        private void snap_Click(object sender, EventArgs e)
        {
            Item i = (Item)listBox1.SelectedItem;
            FormRect f = new FormRect(i);
            f.DoneOCR += c_DoneOCR;
            f.Bounds = Screen.PrimaryScreen.Bounds;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.TopMost = true;
            f.BackColor = Color.White;
            f.Opacity = .25;
            f.FormBorderStyle = FormBorderStyle.None;
            f.ShowDialog();
            
        }

        public static void c_DoneOCR(object sender, DoneOCREventArgs e)
        {
            List<Sale> sales = new List<Sale>();
            string t = e.Text;
            String[] lines = t.Split('\n');
            foreach(string line in lines)
            {
                bool hq;
                int price;
                int offset = 0;
                String[] parts = line.Split();
                if (parts.Length < 6)
                {
                    continue;
                }
                if (parts.Length == 6)
                {
                    if (parts[5].Count(c=>c == '/') == 1)
                    {
                        hq = true;
                        offset = 1;
                    }
                    else
                    {
                        hq = false;
                    }
                    
                }
                else if (parts.Length == 7)
                {
                    if (parts[5].Count(c=>c == '/') == 1)
                    {
                        hq = true;
                        offset = 1;
                    }
                    else
                    {
                        hq = false;
                    }
                }
                else if (parts.Length == 8)
                {
                    hq = true;
                    offset = 1;
                    
                }else
                {
                    if (parts[5].Count(c=>c == '/') == 1)
                    {
                        //Then the date got effed and it was high quality
                        hq = true;
                    }
                    else
                    {
                        hq = false;
                        offset = 1;
                    }
                    
                }
                price = price = Int32.Parse(parts[offset].Substring(0, parts[offset].Length - 1)); ;
                int quantity = Int32.Parse(parts[++offset]);
                string buyer = parts[++offset] + " " + parts[++offset];
                DateTime dt;
                string datetimestr;
                string format = "M/ddh:mmtt";
                if (parts.Length - (offset + 1) == 2)
                {
                    //MM/ddhh:mmtt
                    datetimestr = parts[++offset] + parts[++offset];
                }
                else if (parts.Length - (offset +1) == 1)
                {
                    datetimestr = parts[++offset];
                }
                else
                {
                    datetimestr = parts[++offset] + parts[++offset] + parts[++offset];
                }
                datetimestr = datetimestr.Replace(".", string.Empty);
                CultureInfo provider = CultureInfo.InvariantCulture;
                dt = DateTime.ParseExact(datetimestr, format, provider);
                sales.Add(new Sale()
                {
                    ItemID = e.Item.ID,
                    IsHq = hq,
                    Price = price,
                    Buyer = buyer,
                    Quantity = quantity,
                    Date = dt

                });

            }
            foreach (Sale s in sales)
            {
                Console.WriteLine("HQ: " + s.IsHq.ToString() + " Price: " + s.Price.ToString() +
                    " Quantity: " + s.Quantity +
                    " Buyer: " + s.Buyer +
                    " Date: " + s.Date.ToString());
            }
            Accessor a = new Accessor();
            ((FormRect)sender).Close();
        }
    }
}
