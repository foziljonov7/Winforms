using Library.Desktop.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Desktop
{
    public partial class DashboardWindow : Form
    {
        public DashboardWindow()
        {
            InitializeComponent();
        }

        private void Closebtn_Click(object sender, EventArgs e)
            => Application.Exit();

        private void AddUserControl(UserControl userControl)
        {
            ControlPanel.Controls.Clear();
            ControlPanel.Controls.Add(userControl);
        }
        private void Databtn_Click(object sender, EventArgs e)
        {
            DataUserControl userControl = new DataUserControl();
            AddUserControl(userControl);
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            DataUserControl userControl = new DataUserControl();
            AddUserControl(userControl);
        }

        private void ControlPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashboardWindow_Load(object sender, EventArgs e)
        {
            DataUserControl userControl = new DataUserControl();
            AddUserControl(userControl);
        }

        private void Createbtn_Click(object sender, EventArgs e)
        {
            CreateUserControl userControl = new CreateUserControl();
            AddUserControl(userControl);
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            UpdateUserControl userControl = new UpdateUserControl();
            AddUserControl(userControl);
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            DeleteUserControl userControl = new DeleteUserControl();
            AddUserControl(userControl);
        }
    }
}
