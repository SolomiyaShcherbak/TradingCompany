using System;
using System.Windows.Forms;
using TradingCompany.BLL.Interfaces;
using TradingCompany.DTO;

namespace TradingCompany.WF
{
    public partial class LoginForm : Form
    {
        protected readonly IAuthenticationManager _manager;

        public LoginForm(IAuthenticationManager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginUser();
        }

        private void LoginUser()
        {
            if (_manager.Login(txtLogin.Text, txtPassword.Text))
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Invalid login or password");
        }

        public UserDTO GetCurrentUser()
        {
            return _manager.GetUserByLogin(txtLogin.Text);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                LoginUser();
        }
    }
}
