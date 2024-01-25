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
    public partial class DataUserControl : UserControl
    {
        private readonly IProductRepository repository;

        public DataUserControl(IProductRepository repository)
        {
            InitializeComponent();
            this.repository = repository;
        }
        private void LoadData()
        {
            List<Product> products = repository.GetProducts().Result;

            dataGridView1.DataSource = products;
        }
        private void DataUserControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
