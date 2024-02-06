using SalesWindow.Dtos;
using SalesWindow.Model;
using SalesWindow.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWindow.UserControls
{
    public partial class CreateUserControl : UserControl
    {
        private readonly ProductService _service;

        public CreateUserControl(ProductService service)
        {
            InitializeComponent();
            _service = service;
        }
        private async void Savebtn_Click(object sender, EventArgs e)
        {
            if(Nametxt.Text == ""
                || Quantitytxt.Text == ""
                || Valumetxt.Text == ""
                || ProductMadetxt.Text == ""
                || CategoryCombo.SelectedItem == "")
            {
                MessageBox.Show("Data incompleted");
            }
            else
            {
                try
                {
                    var newProduct = new CreateProductDto
                    {
                        Name = Nametxt.Text,
                        Price = double.Parse(Pricetxt.Text),
                        Quantity = Convert.ToInt32(Quantitytxt.Text),
                        Made = ProductMadetxt.Text,
                        Volume = double.Parse(Valumetxt.Text),
                        Category = CategoryCombo.SelectedItem.ToString()
                    };

                    await _service.CreateProduct(newProduct);
                    MessageBox.Show("Successfully saved!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Invalid operation {ex}");
                }
            }
        }
    }
}
