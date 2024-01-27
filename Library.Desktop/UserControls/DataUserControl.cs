using Library.Desktop.Models;
using Library.Desktop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Desktop.UserControls
{
    public partial class DataUserControl : UserControl
    {
        private readonly BookService service;

        public DataUserControl(BookService service)
        {
            InitializeComponent();
            this.service = service;
        }
        private async void LoadData()
        {
            List<Book> books = await service.GetBooks();
            BookDataGrid.DataSource = books;
        }
        private void DataUserControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
