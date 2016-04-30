using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CafeteriaSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string UserEmail = EmailBox.Text;

            if (ConfirmEmailAddress(UserEmail))
            {
                string UserPassword = PasswordBox.Text;

                if (ConfirmPassword(UserPassword))
                {
                    DataAccess _DataAccess = new DataAccess();

                    if (_DataAccess.ConfirmUser(UserEmail, UserPassword))
                    {
                        int UserID = Convert.ToInt32(_DataAccess.ReturnUserID(UserEmail));

                        Dashboard _Dashboard = new Dashboard(UserID);

                        this.Hide();

                        _Dashboard.Show();
                    }
                    else MessageBox.Show("Incorrect Password. Please try again.");
                }
                else MessageBox.Show("Please Enter Password");
            }
            else MessageBox.Show("Please Enter Correct Email");
        }

        public bool ConfirmEmailAddress(string UserEmail)
        {
            var EmailRegex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
            return EmailRegex.IsMatch(UserEmail);
        }

        public bool ConfirmPassword(string UserPassword)
        {
            UserPassword = UserPassword.Trim();

            if (UserPassword == string.Empty)
            {
                return false;
            }
            else return true;
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            Register _Register = new Register();
            this.Hide();
            _Register.Show();
        }
    }
}
