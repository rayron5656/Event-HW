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
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            var control2 = new LoginControl();
            Loginpanel.Controls.Add(control2);
            control2.Dock = DockStyle.Fill;
            
        }

       
    }
}
