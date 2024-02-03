using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace Library.Desktop.UserControls
{
    public partial class DeleteUserControl : UserControl
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();
        public DeleteUserControl()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string readQuery = "SELECT * FROM [Table]";
            adapter = new SqlDataAdapter(readQuery, connection);
            table = new DataTable();
            adapter.Fill(table);
        }
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Idtxt.Clear();
            Idtxt.Focus();
        }
        private void Delete()
        {
            try
            {
                connection.Open();
                command = new SqlCommand("DELETE [Table] WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", Convert.ToInt32(Idtxt.Text));
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show($"Successfully deleted {Idtxt.Text}");
                Idtxt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Invalid operation {ex}");
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void DeleteUserControl_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\dev\Новая папка\Calculator\Library.Desktop\LibraryDB.mdf"";Integrated Security=True");
            LoadData();
            Idtxt.Focus();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
