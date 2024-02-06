using SalesWindow.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWindow.UserControls
{
    public partial class DeleteUserControl : UserControl
    {
        private readonly ProductService _service;

        public DeleteUserControl(ProductService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void DeleteUserControl_Load(object sender, EventArgs e)
        {

        }

        private async void Purchasebtn_Click(object sender, EventArgs e)
        {
            if(ProductIdtxt.Text != "")
            {
                try
                {
                    int id = Convert.ToInt32(ProductIdtxt.Text);
                    await _service.DeleteProduct(id);
                    MessageBox.Show("Successfully deleted!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Invalid operation {ex}");
                }
            }
            else
            {
                MessageBox.Show($"Data incompleted!");
                ProductIdtxt.ForeColor = Color.Red;
                ProductIdtxt.Focus();
            }    
        }
    }
}
