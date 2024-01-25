using DevExpress.Drawing.Internal.Fonts.CrossPlatform;
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
    public partial class RemoveUserControl : UserControl
    {
        private readonly ProductRepository repository;

        public RemoveUserControl(ProductRepository repository)
        {
            InitializeComponent();
            this.repository = repository;
        }
        private void Delete()
        {
            int productId = Convert.ToInt32(ProductIdTxt.Text);
            repository.RemoveProduct(productId);
            MessageBox.Show($"Successfully deleted! {productId}");
            ProductIdTxt.Clear();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (ProductIdTxt.Text is "")
            {
                MessageBox.Show("Data is incomplete");
                ProductIdLbl.ForeColor = Color.Red;
            }
            else
                Delete();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            ProductIdTxt.Clear();
        }
    }
}
