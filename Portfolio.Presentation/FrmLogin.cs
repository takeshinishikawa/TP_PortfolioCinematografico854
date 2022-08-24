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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Portfolio.Presentation
{
    public partial class FrmLogin : Form
    {
        private IUserRepository _userRepository;
        private IPortfolioService _portfolioService;
        private IMovieRepository _movieList;

        public FrmLogin(IUserRepository userRepository, IPortfolioService portfolioService, IMovieRepository movieList)
        {
            _userRepository = userRepository;
            _portfolioService = portfolioService;
            _movieList = movieList;
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            string password = txbPassword.Text;

            bool validLogin = _userRepository.ValidateLogin(username, password);

            if (validLogin)
            {
                User loggedUser = _userRepository.GetUser(username);
                await Login_Screen(loggedUser.Username);
                FrmHome formHome = new FrmHome(_userRepository, _portfolioService, _movieList, loggedUser, this);
                Hide();
                CleanLoginScreen();
                formHome.Show();
            }
            else
            {
                MessageBox.Show("Não foi possível realizar seu login. Usuário ou senha inválida.", "Erro no Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lklNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistration formRegistration = new FrmRegistration(_userRepository, this);
            Hide();
            formRegistration.Show();
        }

        private void lklAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAbout formAbout = new FrmAbout(this);
            Hide();
            formAbout.Show();
        }

        private void txbUsername_TextChanged(object sender, EventArgs e)
        {
            txbUsername.Text = txbUsername.Text.Trim();
        }

        private void lklExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult answer = MessageBox.Show("Você tem certeza que deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private async Task Login_Screen(string username)
        {
            lblUsernameGreeting.Text = $"{username}!";
            pnlLogin.Enabled = false;
            pnlLoad.Visible = true;

            int time = RandomLoadTime();
            await Task.Delay(TimeSpan.FromSeconds(time));

            pnlLogin.Enabled = true;
            pnlLoad.Visible = false;
            return;
        }

        private void CleanLoginScreen()
        {
            txbUsername.Text = "";
            txbPassword.Text = "";
        }

        private int RandomLoadTime()
        {
            Random rnd = new Random();
            return rnd.Next(2, 5);
        }

    }
}
