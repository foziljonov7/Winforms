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
    public partial class CreateUserControl : UserControl
    {
        private readonly ProductRepository repository;

        public CreateUserControl(ProductRepository repository)
        {
            InitializeComponent();
            this.repository = repository;
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (ProductNameTxt.Text is ""
                || ProductMadeTxt.Text is ""
                || ProductPriceTxt.Text is ""
                || ProductEnDateTxt.Text is "")
            {
                MessageBox.Show("Data is incomplete");
                ProductNameLbl.ForeColor = Color.Red;
                ProductMadeLbl.ForeColor = Color.Red;
                ProductPriceLbl.ForeColor = Color.Red;
                ProductEndDataLbl.ForeColor = Color.Red;
            }
            else
            {
                try
                {
                    Create();
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Exception: {ex}");
                }
            }
        }
        private void Create()
        {
            var newProduct = new Product
            {
                Id = new Random().Next(1000, 10000),
                Name = ProductNameTxt.Text,
                Price = double.Parse(ProductPriceTxt.Text),
                Made = ProductMadeTxt.Text,
                CreateDate = DateTime.UtcNow.AddHours(5),
                EndDate = DateTime.Parse(ProductEnDateTxt.Text)
            };

            repository.CreateProduct(newProduct);
            MessageBox.Show("Succesfully saved!");
            Clear();
        }
        private void Clear()
        {
            ProductNameTxt.Clear();
            ProductMadeTxt.Clear();
            ProductPriceTxt.Clear();
            ProductEnDateTxt.Clear();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
