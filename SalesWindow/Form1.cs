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

namespace SalesWindow
{
    public partial class Form1 : Form
    {
        private readonly ProductService service;

        public Form1(ProductService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void Closebtn_Click(object sender, EventArgs e)
            => Application.Exit();
        private async void LoadData()
        {
            var products = await service.GetProducts();
            dataGridView1.DataSource = products;
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private async void Purchase()
        {
            int productId = Convert.ToInt32(ProductIdtxt.Text);
            int quantity = Convert.ToInt32(Quantitytxt.Text);

            var purchase = await service.SalesProduct(productId, quantity);
            MessageBox.Show($"Product sold {productId} product number {quantity}");
        }
        private void Purchasebtn_Click(object sender, EventArgs e)
        {
            Purchase();
            LoadData();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
