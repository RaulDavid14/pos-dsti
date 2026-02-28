using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pos_dsti
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void loginText_Enter(object sender, EventArgs e)
        {
            loginText.Text = "";
            loginText.ForeColor = Color.Black;
        }

        private void loginText_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loginText.Text))
            {
                loginText.Text = "Usuario";
                loginText.ForeColor = Color.Gray;
            }
        }

        private void loginPassword_Enter(object sender, EventArgs e)
        {
            loginPassword.Text = "";
            loginPassword.ForeColor = Color.Black;
            loginPassword.UseSystemPasswordChar = true;
        }

        private void loginPassword_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(loginPassword.Text))
            {
                loginPassword.UseSystemPasswordChar = false;
                loginPassword.Text = "Contraseña";
                loginPassword.ForeColor = Color.Gray;
            }
        }
    }
}
