using Microsoft.VisualBasic.Logging;
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

    public partial class FrmPortfolio : Form
    {
        private User loggedUser;
        private Form loginForm;
        private IPortfolioService _portfolioService;
        private IMovieRepository _movieList;

        public FrmPortfolio(IPortfolioService portfolioService, Form login, User user, IMovieRepository movieList)
        {
            _portfolioService = portfolioService;
            loginForm = login;
            loggedUser = user;
            _movieList = movieList;
       
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
            FrmAccount account = new FrmAccount(loggedUser, this.GetType().ToString(), loginForm, _portfolioService, _movieList);
            account.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Close();
            loginForm.Show();
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
            FrmSearch search = new FrmSearch(_movieList, _portfolioService, loginForm, loggedUser);
            search.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmHome home = new FrmHome(_portfolioService, loggedUser, _movieList, loginForm);
            home.Show();
        }
        #endregion

        //

    }
}
