using Repository.Models;
using Repository.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trial
{
    public partial class LoginForm : Form
    {
        HrAccountService HrAccountService;
        public LoginForm()
        {
            HrAccountService = new HrAccountService();
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            var username=txtUsername.Text;
            var password=txtPassword.Text;
            var login=HrAccountService.GetAll().Where(p=>p.Email.Equals(username) && p.Password.Equals(password)&&p.MemberRole==3).FirstOrDefault();
            if (login != null)
            {
                //mo form moi
                Management obj = new Management();
                obj.ShowDialog();
                this.Hide();

            }
            else
            {
                MessageBox.Show("You are not allowed to access this function!");
            }

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
