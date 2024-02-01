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
    public partial class UpdateUserControl : UserControl
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public UpdateUserControl()
        {
            InitializeComponent();
        }
        private void Update()
        {
            try
            {
                if(DateTime.TryParse(TimeOfWritingtxt.Text, out DateTime timeOfWriting))
                {
                    connection.Open();
                    command = new SqlCommand("Update[Table] set Name = @Name, Price = @Price, Author = @Author, TimeOfWriting = @TimeOfWriting WHERE Id = @Id", connection);
                    command.Parameters.AddWithValue("@Id", Idtxt.Text);
                    command.Parameters.AddWithValue("@Name", Nametxt.Text);
                    command.Parameters.AddWithValue("@Price", Pricetxt.Text);
                    command.Parameters.AddWithValue("@Author", Authortxt.Text);
                    command.Parameters.AddWithValue("@TimeOfWriting", timeOfWriting);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Succesfully saved");
                }
                else
                {
                    MessageBox.Show("Convert to error type");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Invalid operation {ex}");
            }
        }
        private void LoadData()
        {
            string readQuery = "SELECT * FROM [Table]";
            adapter = new SqlDataAdapter(readQuery, connection);
            table = new DataTable();
            adapter.Fill(table);
        }
        private void UpdateUserControl_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\dev\Новая папка\Calculator\Library.Desktop\LibraryDB.mdf"";Integrated Security=True");
            LoadData();
            Idtxt.Focus();
        }
        private void Clear()
        {
            Idtxt.Clear();
            Nametxt.Clear();
            Pricetxt.Clear();
            Authortxt.Clear();
            TimeOfWritingtxt.Clear();
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Update();
            Clear();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
