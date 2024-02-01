using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Desktop.UserControls
{
    public partial class CreateUserControl : UserControl
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public CreateUserControl()
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
        private void Clear()
        {
            Nametxt.Clear();
            Pricetxt.Clear();
            Authortxt.Clear();
            TimeOfWritingtxt.Clear();
        }
        private void Create()
        {
            try
            {
                if(DateTime.TryParse(TimeOfWritingtxt.Text, out DateTime timeOfWriting))
                {
                    connection.Open();
                    string createQuery = $"INSERT INTO [Table](Name, Price, Author, TimeOfWriting, Created) VALUES (@Name, @Price, @Author, @TimeOfWriting, @Created)";
                    command = new SqlCommand(createQuery, connection);
                    command.Parameters.AddWithValue("@Name", Nametxt.Text);
                    command.Parameters.AddWithValue("@Price", Pricetxt.Text);
                    command.Parameters.AddWithValue("@Author", Authortxt.Text);
                    command.Parameters.AddWithValue("@TimeOfWriting", timeOfWriting);
                    command.Parameters.AddWithValue("@Created", DateTime.UtcNow.AddHours(5));
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Convert to TimeOfWriting error");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Invalid operation {ex}");
            }
        }
        private void CreateUserControl_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\dev\Новая папка\Calculator\Library.Desktop\LibraryDB.mdf"";Integrated Security=True");
            LoadData();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if(Nametxt.Text == ""
                || Pricetxt.Text == ""
                || Authortxt.Text == ""
                || TimeOfWritingtxt.Text == "")
            {
                MessageBox.Show($"Data is not complete");
            }
            else
            {
                Create();
                MessageBox.Show("Successfully saved!");
                Clear();
            }
        }
    }
}
