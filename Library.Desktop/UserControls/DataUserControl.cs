using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library.Desktop.UserControls
{
    public partial class DataUserControl : UserControl
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public DataUserControl()
        {
            InitializeComponent();
        }
        private void LoadData2()
        {
            string readQuery = "SELECT * FROM [Table]";
            adapter = new SqlDataAdapter(readQuery, connection);
            table = new DataTable();
            adapter.Fill(table);
            BookDataGrid.DataSource = table;
        }
        private void DataUserControl_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\dev\Новая папка\Calculator\Library.Desktop\LibraryDB.mdf"";Integrated Security=True");
            LoadData2();
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
