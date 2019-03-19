using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Processor;


namespace TellerB1
{
    public partial class LogIn1 : Form
    {
        public LogIn1()
        {
            InitializeComponent();
        }   
            
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            int user=int.Parse(tbUser.Text);
            string password=tbPassword.Text;
            string tipo=cmbTipoUser.Text;

            bool Login;

            ClsProcessor processor = new ClsProcessor();
            Login = processor.VerifyPassword(user, password, tipo);
            MessageBox.Show(processor.Message);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogIn1_Load(object sender, EventArgs e)
        {

        }
    }
}
