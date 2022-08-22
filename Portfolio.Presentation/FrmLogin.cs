using Portfolio.Domain;
using Portfolio.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portfolio.Presentation
{
    public partial class FrmLogin : Form
    {
        private readonly IUserRepository _userRepository;
        public FrmLogin(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            string password = txbPassword.Text;

            bool validLogin = _userRepository.ValidateLogin(username, password);



            if (validLogin)
            {
                User loggedUser = _userRepository.GetUser(username);
                FrmHome formHome = new FrmHome(loggedUser, this);
                Hide();
                formHome.Show();
                
            }
            else 
            { 
                MessageBox.Show("Não foi possível realizar seu login. Usuário ou senha inválidos.", "Erro no Login", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

        }

        private void lklNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistration formRegistration = new FrmRegistration();
            Hide();
            formRegistration.Show();
        }

        private void lklAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAbout formAbout = new FrmAbout(this);
            Hide();
            formAbout.Show();
        }
    }
}
