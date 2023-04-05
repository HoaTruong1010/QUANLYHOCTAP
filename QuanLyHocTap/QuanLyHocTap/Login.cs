using QuanLyHocTap.ultils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocTap
{
    public partial class Login : Form
    {
        string _username = "admin";
        string _password = "Admin@123";
        bool _authenticated = false;
        ConvertString convertString;

        public Login()
        {
            InitializeComponent();
            convertString = new ConvertString();
        }

        private bool CheckLogin(string username, string password)
        {
            string un = convertString.DeleteSpacing(username);
            string pw = password;

            if(_username == un && _password == pw)
                return true;
            return false;
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                _authenticated = CheckLogin(txtUsername.Text, txtPassword.Text);
                if (_authenticated)
                {
                    Main main = new Main();
                    main.Authenticated = true;
                    main.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _authenticated = CheckLogin(txtUsername.Text, txtPassword.Text);
            if (_authenticated)
            {
                Main main = new Main();
                main.Authenticated = true;
                main.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_authenticated)
            {
                Application.Exit();
            }
        }
    }
}
