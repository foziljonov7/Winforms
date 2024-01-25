using Food.Desktop.Models;
using Food.Desktop.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food.Desktop
{
    public partial class UpdateUserControl : UserControl
    {
        private readonly ProductRepository repository;

        public UpdateUserControl(ProductRepository repository)
        {
            InitializeComponent();
            this.repository = repository;
        }
        private void Update()
        {
            var product = new Product
            {
                Id = Convert.ToInt32(ProductIdTxt.Text),
                Name = ProductNameTxt.Text,
                Price = double.Parse(ProductPriceTxt.Text),
                Made = ProductMadeTxt.Text,
                CreateDate = DateTime.UtcNow.AddHours(5),
                EndDate = DateTime.Parse(ProductEnDateTxt.Text)
            };

            repository.UpdateProduct(product);
            MessageBox.Show($"Succesfully updated! {product.Id}");
            Clear();
        }
        private void Clear()
        {
            ProductIdTxt.Clear();
            ProductNameTxt.Clear();
            ProductMadeTxt.Clear();
            ProductPriceTxt.Clear();
            ProductEnDateTxt.Clear();
        }
        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (ProductIdTxt.Text is ""
                || ProductNameTxt.Text is ""
                || ProductMadeTxt.Text is ""
                || ProductPriceTxt.Text is ""
                || ProductEnDateTxt.Text is "")
            {
                MessageBox.Show("Data is incomplete");
                ProductIdLbl.ForeColor = Color.Red;
                ProductNameLbl.ForeColor = Color.Red;
                ProductMadeLbl.ForeColor = Color.Red;
                ProductPriceLbl.ForeColor = Color.Red;
                ProductEndDataLbl.ForeColor = Color.Red;
            }
            else
            {
                Update();
            }
        }
    }
}
