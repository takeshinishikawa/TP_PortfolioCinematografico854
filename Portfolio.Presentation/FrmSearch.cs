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
    public partial class FrmSearch : Form
    {
        private User _loggedUser;
        public Form _loginForm;
        private IUserRepository _userRepository;
        private IPortfolioService _portfolioService;
        private IMovieRepository _movieList;

        public FrmSearch(IUserRepository userRepository, IPortfolioService portfolioService, IMovieRepository movieList, Form loginForm, User loggedUser)
        {
            _userRepository = userRepository;
            _portfolioService = portfolioService;
            _movieList = movieList;
            _loggedUser = loggedUser;
            _loginForm = loginForm;

            InitializeComponent();
            CustomizeDesign();
            BuscarLista(_movieList);


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
            if (pnlSubMenu.Visible == true)
                pnlSubMenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
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
            //this.Close();
            //FrmAccount account = new FrmAccount(username);
            //account.Show();
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

        private void btnPortfolio_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmPortfolio portfolio = new FrmPortfolio(_userRepository, _portfolioService, _loginForm, _loggedUser, _movieList);
            portfolio.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmHome home = new FrmHome(_userRepository, _portfolioService, _movieList, _loggedUser, _loginForm);
            home.Show();
        }


        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            VerLista(_movieList);
        }

        private void BuscarLista(IMovieRepository _movieList)
        {
            string option = ccbSearchOptions.Text;
            switch (option)
            {
                case "Titulo":
                    if (txbSearchTitle.Visible == false)
                    {
                        txbSearchTitle.Visible = true;
                    }
                    break;
                case "Gênero":
                    cbbCategory.Visible = true;
                    break;
                case "Estúdio":
                    break;

            }
        }

        private void VerLista(IMovieRepository movieList)
        {
            List<Movie> listadefilmes = movieList.GetMovieList();

            foreach (var m in listadefilmes)
            {
                string[] item = new string[4];
                item[0] = m.Title;
                item[1] = m.ReleaseYear.ToString();
                item[2] = m.Category.ToString();
                item[3] = m.Studio.ToString();

                lvwMovieBank.Items.Add(new ListViewItem(item));
            }
   
        }

        private void SearchTitle()
        {

        }

        private void SearchCategory()
        {

        }

        private void SearchStudio()
        {

        }
    }
}
