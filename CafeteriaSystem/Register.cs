using System;
using System.Windows.Forms;

namespace CafeteriaSystem
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string UserName = NameBox.Text;
            string UserEmail = EmailBox.Text;
            string UserPassword = PasswordBox.Text;

            //we have to register a user
            DataAccess _DataAccess = new DataAccess();

            if (_DataAccess.RegisterUser(UserName, UserEmail, UserPassword))
            {
                int UserID = Convert.ToInt32(_DataAccess.ReturnUserID(UserEmail));

                Dashboard _Dashboard = new Dashboard(UserID);

                this.Hide();

                _Dashboard.Show();
            }
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
