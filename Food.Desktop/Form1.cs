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
    public partial class Dashboard : Form
    {
        private readonly ProductRepository repository;

        public Dashboard(ProductRepository repository)
        {
            InitializeComponent();
            this.repository = repository;            
        }
        private void AddUserControl(UserControl userControl)
        {
            UserControlPanel.Controls.Clear();
            UserControlPanel.Controls.Add(userControl);
        }
        private void Createbtn_Click(object sender, EventArgs e)
        {
            CreateUserControl userControl = new CreateUserControl(repository);
            AddUserControl(userControl);
        }

        private void Removebtn_Click(object sender, EventArgs e)
        {
            RemoveUserControl userControl = new RemoveUserControl(repository);
            AddUserControl(userControl);
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            UpdateUserControl userControl = new UpdateUserControl(repository);
            AddUserControl(userControl);
        }

        private void Closebtn_Click(object sender, EventArgs e)
            => Application.Exit();

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            DataUserControl userControl = new DataUserControl(repository);
            AddUserControl(userControl);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            DataUserControl userControl = new DataUserControl(repository);
            AddUserControl(userControl);
        }
    }
}
