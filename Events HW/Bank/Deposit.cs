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
    public partial class Deposit : UserControl
    {
        static User User;
        static string username;
        static float ToBeDeposit;

        public static event LoginDelegate DepositEvent;

        public Deposit(string USERNAME, User U)
        {
            InitializeComponent();
            username = USERNAME;
            UserNameLabel.Text = username;
            User = U;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var control1 = new LoginControl();

            this.Controls.Clear();
            this.Controls.Add(control1);
            control1.Dock = DockStyle.Fill;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            DepositEvent = SimpleMessage;

            if (float.TryParse(DeposittextBox.Text,out ToBeDeposit))
            {
                User.UserAccount.AddMoney(ToBeDeposit);
                DepositEvent($"{ToBeDeposit}₪ Have been deposit in {username} Account! ");
                
            }
            else
            {
                DepositEvent($"Cannot Deposit that");
            }
        }

        public static void SimpleMessage(string Message)
        {
            MessageBox.Show(Message);
        }
    }
}
