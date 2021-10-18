using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class LoginControl : UserControl
    {
        public static event LoginDelegate LogInEvent;


        public static User CurrentUser;

        public LoginControl()
        {
            InitializeComponent();
        }

        private void SignUpbutton_Click(object sender, EventArgs e) // Adding User
        {
            if (!UserList.CheackForUser(NametextBox.Text, PasswordtextBox.Text))
            {
                UserList.Add(new User(NametextBox.Text, PasswordtextBox.Text));
                MessageBox.Show($"User {NametextBox.Text} signed up");
            }
            else
            {
                MessageBox.Show("User Already Exist");
            }
        }

       

        public static void SimpleMessage(string Message)
        {
            MessageBox.Show(Message);
        }

        private void SignInbutton_Click_1(object sender, EventArgs e)
        {
            LogInEvent = SimpleMessage;

            LogInEvent((UserList.CheackForIdentification(new User(NametextBox.Text, PasswordtextBox.Text))));

            if ("Log In Successful" == UserList.CheackForIdentification(new User(NametextBox.Text, PasswordtextBox.Text)))
            {
                var control1 = new Deposit(NametextBox.Text, CurrentUser);
                this.Controls.Clear();
                this.Controls.Add(control1);
                control1.Dock = DockStyle.Fill;

            }
            else
            {
                NametextBox.Text = "";
                PasswordtextBox.Text = "";
            }
        }
    }
}
