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
            CreateResumeNewUser(loggedUser);
            CreatePortfolioResume(loggedUser);
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

        private void CreateResume(User loggedUser)
        {
            string name = loggedUser.Name;
            lblNameOrUsername.Text = name;

            decimal movieBank = _movieList.Count();
            decimal moviePort = _portfolioService.CountWatchedMovies(loggedUser);
            decimal percentView = (moviePort / movieBank) * 100;
            percentView = Math.Round(percentView, 1);

            var favoriteCategory = _portfolioService.FindMostWatchedCategory(loggedUser);

            int numberCategory = favoriteCategory.count; 
            string watchedCategory = Extensions.GetEnumDescription(favoriteCategory.category); 


            decimal percentCategory = (numberCategory / moviePort) * 100; // conferir se tem filme e visto
            percentCategory = Math.Round(percentCategory, 1);


            var text1 = $"Até o presente momento você adicionou {moviePort} filmes no seu portfólio. A categoria mais assistida dentre os filmes é a {watchedCategory}. E uau, você já assistiu {numberCategory} filmes dela." +
                $" Ou seja, {percentCategory}% do seu portfólio.";
           
            var text2 = $"{name}, dentre todos os filmes registrados aqui sabia que você já assistiu {percentView}% deles? Talvez uma olhadinha na nossa coleção te inspire a conhecer algum novo filme e" +
                $" se encantar. O universo cinematografico está aqui para fazer os mais loucos sonhos se tornarem possíveis e reais.";
            
            var text3 = $"Parabéns {name}!!! Você parece conhecer tudo sobre filmes e ter um repertório bastante amplo, já viu {percentView} dos filmes disponíveis aqui.\n";
            
            var text4 = "Descubra quais filmes você ainda não viu clicando aqui.";


            if (percentView < 100)
            {
                lblResume.Text = text1 + "\n\n" + text2;
            }
            else
            {
                lblResume.Text = text1 + "\n\n" + text3;
            }

            lklSearchFilter.Text = text4;

        }

        private void CreateResumeNewUser(User user)
        {
            string name = user.Name;
            lblNameOrUsername.Text = name;

            int numberOfMovies = _movieList.Count();

            string welcome = $"Seja bem vindo ao maravilhoso universo que une cinema e organização. Aqui você vai conseguir criar e organizar" +
                $" seu próprio portfólio de filmes que você já assistiu, atribuindo a eles notas e comentários." +
                $" Atualmente possuimos em nosso banco de dados {numberOfMovies} filmes dos mais diversos gêneros." +
                $" Sinta-se a vontade para explorar todos os nossos recursos e se divertir.";
            lblResume.Text = welcome;

            var search = "Descubra quais filmes você ainda não viu clicando aqui.";
            lklSearchFilter.Text = search;
        }

        private void CreatePortfolioResume(User user)
        {
            List<Review> portfolio = _portfolioService.LastNReviews(_loggedUser, 5);
            foreach (var p in portfolio)
            {
                lblLatestMoviesTitle.Text = p.Movie.Title;
                lblLatestMoviesScore.Text = p.Value.ToString();
            }
        }

        private void CreatePortfolioResumeNewUser(User user)
        {
            lblMovieTitlePor.Text = "Ainda não há filmes adicionados no seu portfólio.";
            lblMovieScorePort.Text = "";
            lblLatestMoviesTitle.Text = ""; 
            lblLatestMoviesScore.Text = "";
        }

        private void lklSearchFilter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            FrmSearch search = new FrmSearch(_userRepository, _portfolioService, _movieList, _loginForm, _loggedUser);
            search.Show();
        }



    }
}
