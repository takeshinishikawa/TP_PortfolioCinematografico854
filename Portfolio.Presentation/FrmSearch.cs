using Portfolio.Domain;
using Portfolio.Domain.Enum;
using Portfolio.Services;
using System;
using System.Collections.Generic;
using System.Reflection;
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
    public partial class FrmSearch : Form
    {
        private User _loggedUser;
        public Form _loginForm;
        public Category _category;
        private IUserRepository _userRepository;
        private IPortfolioService _portfolioService;
        private IMovieRepository _movieList;
        private Dictionary<string, Category> _descriptionCategory;
        private Dictionary<string, Studio> _descriptionStudio;

        public FrmSearch(IUserRepository userRepository, IPortfolioService portfolioService, IMovieRepository movieList, User loggedUser, Form loginForm)
        {
            _userRepository = userRepository;
            _portfolioService = portfolioService;
            _movieList = movieList;
            _loggedUser = loggedUser;
            _loginForm = loginForm;

            InitializeComponent();
            CustomizeDesign();
            _descriptionCategory = GetCategory();
            _descriptionStudio = GetStudio();

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
            this.Close();
            FrmAccount account = new FrmAccount(_portfolioService, _userRepository, _movieList, _loginForm, _loggedUser, this.GetType().ToString());
            account.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Close();
            _loginForm.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAbout about = new FrmAbout(this);            
            about.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Você tem certeza que deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnPortfolio_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmPortfolio portfolio = new FrmPortfolio(_userRepository, _portfolioService, _movieList,  _loggedUser, _loginForm);
            portfolio.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmHome home = new FrmHome(_userRepository, _portfolioService, _movieList, _loggedUser, _loginForm);
            home.Show();
        }


        #endregion


        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (lvwMovieBank.SelectedItems.Count > 0)
            {
                string movieName = lvwMovieBank.SelectedItems[0].SubItems[0].Text;
                string movieYear = lvwMovieBank.SelectedItems[0].SubItems[1].Text;
                FrmMovieDetail f = new FrmMovieDetail(_portfolioService, _loggedUser, _movieList.GetMovie(movieName, movieYear));
                f.Show();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            var option = cbbSearchOptions.Text;
            switch (option)
            {
                case "Título":
                    lvwMovieBank.Items.Clear();
                    SearchTitle();
                    cbbCategory.Text = "";
                    cbbStudio.Text = "";
                    break;

                case "Estúdio":
                    lvwMovieBank.Items.Clear();
                    SearchStudio();
                    cbbCategory.Text = "";
                    txbSearchTitle.Text = "";
                    break;

                case "Gênero":
                    lvwMovieBank.Items.Clear();
                    SearchCategory();
                    cbbStudio.Text = "";
                    txbSearchTitle.Text = "";
                    break;

                default:
                    lvwMovieBank.Items.Clear();
                    SearchAllMovies(_movieList);
                    break;
            }
        }

        private void SearchAllMovies(IMovieRepository movieList)
        {
            List<Movie> listadefilmes = movieList.GetMovieList();

            foreach (var m in listadefilmes)
            {
                string[] item = new string[2];
                item[0] = m.Title;
                item[1] = m.ReleaseYear.ToString();

                lvwMovieBank.Items.Add(new ListViewItem(item));
            }

        }

        private void SearchTitle()
        {
            var title = txbSearchTitle.Text;
            title = title.Trim();
            List<Movie> listByTitle = _movieList.SearchMovieByTitle(title);

            foreach (var t in listByTitle)
            {
                string[] item = new string[2];
                item[0] = t.Title;
                item[1] = t.ReleaseYear.ToString();
                lvwMovieBank.Items.Add(new ListViewItem(item));
            }

        }

        private void SearchCategory()
        {
            var nameCategory = cbbCategory.Text;
            Category category = _descriptionCategory[nameCategory];
            List<Movie> listByCategory = _movieList.SearchMovieByCategory(category);

            foreach (var c in listByCategory)
            {
                string[] item = new string[2];
                item[0] = c.Title;
                item[1] = c.ReleaseYear.ToString();
                lvwMovieBank.Items.Add(new ListViewItem(item));
            }
        }

        private void SearchStudio()
        {
            var nameStudio = cbbStudio.Text;
            Studio studio = _descriptionStudio[nameStudio];
            List<Movie> listByStudio = _movieList.SearchMovieByStudio(studio);

            foreach (var s in listByStudio)
            {
                string[] item = new string[2];
                item[0] = s.Title;
                item[1] = s.ReleaseYear.ToString();
                lvwMovieBank.Items.Add(new ListViewItem(item));
            }

        }

        private Dictionary<string, Studio> GetStudio()
        {
            var studios = Enum.GetValues(typeof(Studio)).Cast<Studio>().ToList();
            Dictionary<string, Studio> descriptionStudio = new();

            foreach (var s in studios)
            {
                string description = Extensions.GetEnumDescription(s);
                descriptionStudio.Add(description, s);
                cbbStudio.Items.Add(description);
            }
            return descriptionStudio;

        }

        private Dictionary<string, Category> GetCategory()
        {
            var categories = Enum.GetValues(typeof(Category)).Cast<Category>().ToList();
            Dictionary<string, Category> descriptionCategory = new();

            foreach (var c in categories)
            {
                string description = Extensions.GetEnumDescription(c);
                descriptionCategory.Add(description, c);
                cbbCategory.Items.Add(description);
            }
            return descriptionCategory;

        }

        private void cbbSearchOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            string option = cbbSearchOptions.Text;

            if (option == "Título")
            {
                cbbCategory.Visible = false;
                cbbStudio.Visible = false;
                txbSearchTitle.Visible = true;
            }
            else if (option == "Gênero")
            {
                txbSearchTitle.Visible = false;
                cbbStudio.Visible = false;
                cbbCategory.Visible = true;
            }
            else if (option == "Estúdio")
            {
                txbSearchTitle.Visible = false;
                cbbCategory.Visible = false;
                cbbStudio.Visible = true;
            }
        }

    }

}
