using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Product
    {
        private decimal price;

        public void SetPrice(decimal value)
        {
            if (value < 0)
            {
                throw new ArgumentException("fiyat değeri negatif olamaz");
            }

            this.price = value;
        }

        public decimal GetPrice()
        {
            return this.price;
        }

        private string name;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(value);
                }
                this.name = value;
            }
        }

        public string Category { get; set; }

        //private bool inStock = false;
        public bool InStock { get; private set; }

        public int Stock { get; set; }

        public void ChangeStock(int stock)
        {
            Stock = stock;
            InStock = Stock > 0;

        }
        //private int stockCount;
        //public int StockCount
        //{
        //    get
        //    {
        //        return stockCount;
        //    }
        //    set
        //    {
        //        stockCount = value;
        //        inStock = true;
        //    }
        //}


    }
}
