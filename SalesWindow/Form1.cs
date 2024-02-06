using SalesWindow.Services;
using SalesWindow.UserControls;
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
        private async void FirstCategory(string category)
        {
            var categories = await service.GetCategoryProduct(category);

            dataGridView1.DataSource = categories;
        }
        private void AddUserControl(UserControl userControl)
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(userControl);
        }
        private void Createbtn_Click(object sender, EventArgs e)
        {
            CreateUserControl userControl = new CreateUserControl(service);
            AddUserControl(userControl);
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            ProductIdtxt.Clear();
            Quantitytxt.Clear();
            ProductIdtxt.Focus();
            Searchtxt.Clear();
        }

        private void Databtn_Click(object sender, EventArgs e)
        {
            
        }

        private void CategoryCombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var category = CategoryCombo.SelectedItem.ToString();

            if (category != null)
                FirstCategory(category);
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            DeleteUserControl userControl = new DeleteUserControl(service);
            AddUserControl(userControl);
        }

        private async void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            var name = Searchtxt.Text;
            var products = await service.FirstProduct(name);
            if(products != null)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = products;
            }
        }
    }
}
