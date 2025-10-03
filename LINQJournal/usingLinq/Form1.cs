using Application;

namespace usingLinq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductService productService = new ProductService();
        private void buttonGetp_Click(object sender, EventArgs e)
        {
            var products = productService.GetProducts();
            dataGridView1.DataSource = products;
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            var maxPrice = productService.GetProducts().Max(p => p.Price);

            var maxPriceProduct = productService.GetProducts().MaxBy(p => p.Price);
            MessageBox.Show(maxPrice.ToString());
            MessageBox.Show($"En pahalý ürünün bilgileri: {maxPriceProduct.Name} - {maxPriceProduct.Description}, {maxPriceProduct.Category}, {maxPriceProduct.Price} TL");
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            var orderedProducts = productService.GetProducts()
                                  .OrderBy(p => p.Category)
                                  .ThenByDescending(p => p.Price)
                                  .ToList();



            dataGridView1.DataSource = orderedProducts;
        }

        private void buttonGroup_Click(object sender, EventArgs e)
        {
            /*
             *     var query = petsList.GroupBy(
        pet => Math.Floor(pet.Age),
        pet => pet.Age,
        (baseAge, ages) => new
        {
            Key = baseAge,
            Count = ages.Count(),
            Min = ages.Min(),
            Max = ages.Max()
        });
             */
            var grouping = productService.GetProducts()
                          .GroupBy(p => p.Category, (category, products) => new
                          {
                              Key = category,
                              Count = products.Count(),
                              Min = products.Min(p=>p.Price),
                              Max = products.Max(p=>p.Price),
                              Average = products.Average(p=>p.Price)
                          })
                          .OrderBy(x=>x.Key)
                          .ToList();


            dataGridView1.DataSource = grouping;
                          

          
        }
    }
}
