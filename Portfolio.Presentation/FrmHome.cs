using System;
using System.Collections.Generic;
using Portfolio.Domain.Enum;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Portfolio.Domain;
using User = Portfolio.Domain.User;
using Portfolio.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Portfolio.Presentation
{
    public partial class FrmHome : Form
    {
        private User _loggedUser;
        public Form _loginForm;
        private IUserRepository _userRepository;
        private IPortfolioService _portfolioService;
        private IMovieRepository _movieList;

        public FrmHome(IUserRepository userRepository, IPortfolioService portfolioService, IMovieRepository movieList, User loggedUser, Form loginForm)
        {
            _userRepository = userRepository;
            _portfolioService = portfolioService;
            _movieList = movieList;
            _loggedUser = loggedUser;            
            _loginForm = loginForm;
            

            InitializeComponent();
            CustomizeDesign();
            InitializeUserHomeScreen(loggedUser);
        }

        #region Header

        private void btnLogo_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenu);
        }

        private void CustomizeDesign()
        {
            pnlSubMenu.Visible = false;
        }

        private void HideSubMenu()
        {
            if(pnlSubMenu.Visible == true)
                pnlSubMenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnMyAccount_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmAccount account = new FrmAccount(_loggedUser, this.GetType().ToString(), _loginForm, _portfolioService, _movieList, _userRepository);
            account.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Close();
            _loginForm.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            FrmAbout about = new FrmAbout(this);
            this.Hide();
            about.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var answer = DialogResult;
            answer = MessageBox.Show("Você tem certeza que deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnNewSearch_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmSearch search = new FrmSearch(_userRepository, _portfolioService, _movieList, _loginForm, _loggedUser);
            search.Show();
        }

        private void btnPortfolio_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmPortfolio portfolio = new FrmPortfolio(_userRepository, _portfolioService, _loginForm, _loggedUser, _movieList);
            portfolio.Show();
        }
        #endregion

        private void lklSearchFilter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
            FrmSearch search = new FrmSearch(_userRepository, _portfolioService, _movieList, _loginForm, _loggedUser);
            search.Show();
        }

        private void InitializeUserHomeScreen(User loggedUser)
        {
            int watchedMoviesCount = _portfolioService.CountWatchedMovies(loggedUser);

            if(watchedMoviesCount > 0)
            {
                UserHome(loggedUser);
            }
            else
            {
                EmptyUserHome(loggedUser);
            }
        }

        private void UserHome(User loggedUser)
        {
            pnlHome.Visible = true;
            pnlHome.Enabled = true;

            UserResume(loggedUser);
            UserPortfolioResume(loggedUser);
        }
                
        private void UserResume(User loggedUser)
        {
            string name = loggedUser.Name;
            lblNameOrUsername.Text = name;

            decimal avaiableMoviesCount = _movieList.Count();
            decimal watchedMoviesCount = _portfolioService.CountWatchedMovies(loggedUser);
            decimal percentViewed = (watchedMoviesCount / avaiableMoviesCount) * 100;
            percentViewed = Math.Round(percentViewed, 1);

            var favoriteCategory = _portfolioService.FindMostWatchedCategory(loggedUser);

            int numberCategory = favoriteCategory.count;
            string watchedCategory = favoriteCategory.category;


            decimal percentCategory = (numberCategory / watchedMoviesCount) * 100;
            percentCategory = Math.Round(percentCategory, 1);


            string standartResumeText = $"    Até agora você adicionou {watchedMoviesCount} filmes no seu portfólio. Sua categoria mais assistida foi {watchedCategory} e, UAU, você já assistiu {numberCategory} filme(s) dela. " +
                $"Isso é {percentCategory}% do seu portfólio!";

            string lowerPercentResumeText = $"    {name}, sabia que você já assistiu {percentViewed}% dos nossos filmes cadastrados !? Talvez uma olhadinha na nossa coleção te inspire a conhecer algum novo filme e " +
                $"se encantar. O universo cinematografico está aqui para fazer os mais loucos sonhos se tornarem possíveis e reais.";

            string higherPercentResumeText = $"    Parabéns {name}!!! Você parece conhecer tudo sobre filmes e tem um repertório beeeeeem amplo, já viu {percentViewed}% dos filmes disponíveis aqui.";

            string linkToSearchText = "Vamos completar seu portfólio? Descubra quais filmes você ainda não viu clicando aqui.";

            lblStandartResume.Text = standartResumeText;

            if (percentViewed < 80)
            {
                 lblPercentResume.Text = lowerPercentResumeText;
            }
            else
            {
                lblPercentResume.Text = higherPercentResumeText;
            }

            lklSearchFilter.Text = linkToSearchText;

        }

        private void UserPortfolioResume(User user)
        {

            lblLatestMoviesTitle.Text = ""; //Top 5 ultimos filmes vistos - titulo
            lblLatestMoviesScore.Text = ""; //Top 5 ultimos filmes vistos - score
        }

        private void EmptyUserHome(User loggedUser)
        {
            pnlEmptyUser.Visible = true;
            pnlEmptyUser.Enabled = true;

            lblEmptyUsername.Text = loggedUser.Name;
            int avaiableMoviesCount = _movieList.Count();

            string welcome = $"    Seja bem vindo ao maravilhoso universo que une cinema e organização." + 
                " Aqui você vai conseguir criar e organizar" +
                $" seu próprio portfólio de filmes, atribuindo a eles notas e comentários." +
                $" Atualmente temos em nosso banco de dados {avaiableMoviesCount} filmes dos mais diversos gêneros." +
                $" Sinta-se a vontade para explorar todos os nossos recursos e se divertir.";

            lblEmptyResume.Text = welcome;

            var search = "Vamos começar? Descubra quais filmes estão disponíveis clicando aqui.";
            lklLinkToReview.Text = search;
        }

    }
}
