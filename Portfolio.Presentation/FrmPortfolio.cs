using Microsoft.VisualBasic.Logging;
using Portfolio.Domain;
using Portfolio.Domain.Enum;
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

    public partial class FrmPortfolio : Form
    {
        private User _loggedUser;
        private Form _loginForm;
        private IUserRepository _userRepository;
        private IPortfolioService _portfolioService;
        private IMovieRepository _movieList;
        private List<Review> _portfolio;

        public FrmPortfolio(IUserRepository userRepository, IPortfolioService portfolioService, Form loginForm, User loggedUser, IMovieRepository movieList)
        {
            _userRepository = userRepository;
            _portfolioService = portfolioService;
            _loginForm = loginForm;
            _loggedUser = loggedUser;
            _movieList = movieList;
            List<Review> portfólio = _loggedUser.Portfolio;

            InitializeComponent();
            CustomizeDesign();
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmHome home = new FrmHome(_userRepository, _portfolioService, _movieList, _loggedUser, _loginForm);
            home.Show();
        }

        #endregion

        private void btnAZ_Click(object sender, EventArgs e)
        {
            lvwPortfolio.Items.Clear();
            var portfolio = _loggedUser.Portfolio.OrderBy(m => m.Movie.Title);
            foreach (var m in portfolio)
            {
                string description = Extensions.GetEnumDescription(m.Value);
                string[] item = new string[3];
                item[0] = m.Movie.Title;
                item[1] = description;
                item[2] = m.Comments;
                lvwPortfolio.Items.Add(new ListViewItem(item));
            }

        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            lvwPortfolio.Items.Clear();
            var portfolio = _loggedUser.Portfolio.OrderByDescending(m => m.Value)
                .ThenBy(m => m.Movie.Title);
            foreach(var m in portfolio)
            {
                string description = Extensions.GetEnumDescription(m.Value);
                string[] item = new string[3];
                item[0] = m.Movie.Title;
                item[1] = description;
                item[2] = m.Comments;
                lvwPortfolio.Items.Add(new ListViewItem(item));
            }
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            lvwPortfolio.Items.Clear();
            var portfolio = _loggedUser.Portfolio.OrderBy(m => m.Movie.Category)
                .ThenBy(m => m.Movie.Title);
            foreach (var m in portfolio)
            {
                string description = Extensions.GetEnumDescription(m.Value);
                string[] item = new string[3];
                item[0] = m.Movie.Title;
                item[1] = description;
                item[2] = m.Comments;
                lvwPortfolio.Items.Add(new ListViewItem(item));
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var answer = DialogResult;
            answer = MessageBox.Show("Você tem certeza que deseja excluir esse filme do seu portfólio?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                var movie = lvwPortfolio.SelectedItems[0].SubItems[0].Text;
                //var review = (Review)_portfolio.Where(P => P.Movie.Title == movie);
                //_portfolio.Remove(review);
                lvwPortfolio.Items.RemoveAt(lvwPortfolio.SelectedIndices[0]);
            }
            
        }

    }
}
