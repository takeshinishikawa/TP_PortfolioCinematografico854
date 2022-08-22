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

namespace Portfolio.Presentation
{
    public partial class FrmHome : Form
    {
        User LoggedUser { get; set; }
        Form login;

        public FrmHome(User loggedUser, Form loginForm)
        {

            LoggedUser = loggedUser;
            login = loginForm;

            InitializeComponent();
            CustomizeDesign();
            CreateResume(loggedUser);
        }

        private void CreateResume(User loggedUser)
        {
            string username = loggedUser.Username;

            decimal filmBank = MovieRegister.MovieList.Count();


            int filmCategory = 0; //filme que a pessoa viu dessa categoria
            decimal filmPort = 2m;
            decimal percentView = (filmPort/filmBank) * 100;

            percentView = Math.Round(percentView, 1);
            string categoryView;
            var categoryName = Category.Romance;
            string t1 = "Olá";

            lblNameOrUsername.Text = username;
            var text1 = $"Até o presente momento você já viu {filmPort} filmes. A categoria mais assistida por você é a {categoryName}. E uau, você já assistiu {filmCategory} filmes dela.";
            //var text2 = $"A categoria de filmes mais assistida por você é a {categoryName}. Uau, você já assistiu {filmCategory} filmes dela.\n";
            var text2 = $"{username}, dentre todos os filmes registrados aqui sabia que você já assistiu {percentView}% deles? Talvez uma olhadinha na nossa coleção te inspire a conhecer algum novo filme e" +
                $" se encantar. O universo cinematografico está aqui para fazer os mais loucos sonhos se tornarem possíveis e reais.";
            var text3 = $"Parabéns {username}!!! Você parece conhecer tudo sobre filmes e ter um repertório bastante amplo, já viu {percentView} dos filmes disponíveis aqui.\n";
            var text4 = " Descubra quais filmes você ainda não viu clicando aqui.";

            if (percentView < 100)
            {
                lblResume.Text = text1 + "\n\n" + text2 + text4;
            } else
            {
                lblResume.Text = text1 + "\n\n" + text3;
            }

        }
        private void CreatePortfolioResume()
        {
            
        }

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
            //this.Hide();
            //FrmAccount account = new FrmAccount(username);
            //account.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Close();
            login.Show();
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
                base.Close();
            }
        }

        private void btnNewSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSearch search = new FrmSearch();
            search.Show();
        }

        private void btnPortfolio_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPortfolio portfolio = new FrmPortfolio();
            portfolio.Show();
        }

    }
}
