using Microsoft.VisualBasic.Devices;
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
    public partial class FrmMovieDetail : Form
    {
        IPortfolioService _portfolioService;
        User _loggedUser;
        Movie _movie;
        bool alreadyInPortfoilio = false;

        public FrmMovieDetail(IPortfolioService portfolioService, User loggedUser, Movie movie)
        {
            _portfolioService = portfolioService;
            _loggedUser = loggedUser;
            _movie = movie;
            InitializeComponent();
            lblDetailTitle.Text = $"{movie.Title} ({movie.ReleaseYear})";
            lblDetailStudio.Text = Extensions.GetEnumDescription(movie.Studio);
            lblDetailCategory.Text = Extensions.GetEnumDescription(movie.Category);
            if (_loggedUser.Portfolio.Where(r => r.Movie.Title == movie.Title).FirstOrDefault() != null)
            {
                cbbDetailStar.Text = Extensions.GetEnumDescription(_loggedUser.Portfolio.Where(r => r.Movie.Title == movie.Title).FirstOrDefault().Value);
                txbDetailReview.Text = _loggedUser.Portfolio.Where(r => r.Movie.Title == movie.Title).FirstOrDefault().Comments;
            }
            btnDetailSalvar.ForeColor = Color.LightGray;
            btnDetailSalvar.Enabled = false;
        }

        private void btnDetailVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbDetailStar_TextChanged(object sender, EventArgs e)
        {
            ChangeBtnSalvarStatus();
        }
        private void txbDetailReview_TextChanged(object sender, EventArgs e)
        {
            ChangeBtnSalvarStatus();
        }
        private void ChangeBtnSalvarStatus()
        {
            if (cbbDetailStar.Text != "Nota" && 
                _loggedUser.Portfolio.Where(r => r.Movie.Title == _movie.Title).FirstOrDefault() != null &&
                cbbDetailStar.Text != Extensions.GetEnumDescription(_loggedUser.Portfolio.Where(r => r.Movie.Title == _movie.Title).FirstOrDefault().Value))
            {
                alreadyInPortfoilio = true;
                btnDetailSalvar.Enabled = true;
                btnDetailSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
                return;
            }
            else if (_loggedUser.Portfolio.Where(r => r.Movie.Title == _movie.Title).FirstOrDefault() != null &&
                cbbDetailStar.Text != "Nota" &&
                _loggedUser.Portfolio.Where(r => r.Comments != txbDetailReview.Text).FirstOrDefault() != null)
            {
                alreadyInPortfoilio = true;
                btnDetailSalvar.Enabled = true;
                btnDetailSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
                return;
            }
            else if (_loggedUser.Portfolio.Where(r => r.Movie.Title == _movie.Title).FirstOrDefault() == null && 
                cbbDetailStar.Text != "Nota")
            {
                alreadyInPortfoilio = false;
                btnDetailSalvar.Enabled = true;
                btnDetailSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
                return;
            }
            btnDetailSalvar.Enabled = false;
            btnDetailSalvar.ForeColor = Color.LightGray;
        }

        private void btnDetailSalvar_Click(object sender, EventArgs e)
        {
            Review r = new Review(_movie, Extensions.GetValueFromDescription<Star>(cbbDetailStar.Text), txbDetailReview.Text);
            _portfolioService.AddReviewToPortfolio(_loggedUser, r);

            string message;

            if (alreadyInPortfoilio)
                message = $"O filme \"{_movie.Title}\" foi atualizado em seu Portfolio!";
            else
                message = $"O filme \"{_movie.Title}\" foi adicionado ao seu Portfolio!";

            DialogResult answer = MessageBox.Show(message, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (answer == DialogResult.OK)
            {
                this.Close();
                return;
            }
            this.Close();
        }


    }
}
