using Microsoft.VisualBasic.ApplicationServices;
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
using User = Portfolio.Domain.User;

namespace Portfolio.Presentation
{
    public partial class FrmAccount : Form
    {
        bool CadastroMostrarSenha = false;
        bool validName = false;
        bool validPassword = false;
        User user;
        //public FrmAccount(User user)
        public FrmAccount(User user)
        {
            this.user = user;
            InitializeComponent();
            lblContaNameValidation.Text = "";
            lblContaPasswordValidation.Text = "";
            lblContaTitle.Text = $"Bem vindo, {user.Name}!";
            lblContaSubtitle.Text = "Gerencie aqui as informações da sua conta.";
            txbContaName.Text = user.Name;
            mtxContaBirthDate.Text = user.BirthDate.ToString();
            txbContaUserName.Text = user.Username;
            btnContaSalvar.Enabled = false;
        }

        private void txbContaName_TextChanged(object sender, EventArgs e)
        {
            string input = txbContaName.Text;
            lblContaNameValidation.Text = "";
            validName = false;
            if (input == string.Empty)
            {
                lblContaNameValidation.Text = "";
                txbContaName.ForeColor = Color.Black;
            }
            else if (input[0] == ' ' || input.Replace(" ", "") == "")
            {
                txbContaName.ForeColor = Color.Red;
                lblContaNameValidation.Text = "Nome inválido.";
                lblContaNameValidation.ForeColor = Color.Red;
                return;
            }
            else
            {
                input = txbContaName.Text;
                string[] names = input.Split(' ');
                if (names.Length >= 2 && names[1] != "")
                {
                    lblContaNameValidation.Text = "Nome válido";
                    lblContaNameValidation.ForeColor = Color.Green;
                    txbContaName.ForeColor = Color.Green;
                    validName = true;
                }
            }
            EnableBtnSalvar();
        }

        private void txbContaName_Leave(object sender, EventArgs e)
        {
            string input = txbContaName.Text;
            lblContaNameValidation.Text = "";
            validName = false;
            if (input == string.Empty || input.Replace(" ", "") == "")
                return;
            else if (input.Replace(" ", "") == "")
            {
                lblContaNameValidation.Text = "Informe um nome válido";
                lblContaNameValidation.ForeColor = Color.Red;
                return;
            }
            else
            {
                input = txbContaName.Text;
                if (input != string.Empty && (input[0] == ' ' || input[^1] == ' '))
                {
                    lblContaNameValidation.Text = "Nome inválido. Existe um espaço no início ou no final do nome.";
                    lblContaNameValidation.ForeColor = Color.Red;
                    txbContaName.ForeColor = Color.Red;
                    return;
                }
                string[] names = input.Split(' ');
                if (names.Length < 2)
                {
                    lblContaNameValidation.Text = "Nome inválido.";
                    lblContaNameValidation.ForeColor = Color.Red;
                    txbContaName.ForeColor = Color.Red;
                }
                else
                {
                    if (names[1] != "")
                    {
                        lblContaNameValidation.Text = "Nome válido";
                        lblContaNameValidation.ForeColor = Color.Green;
                        txbContaName.ForeColor = Color.Green;
                        validName = true;
                    }
                }
            }
            EnableBtnSalvar();
        }
        private void txbContaCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            lblContaPasswordValidation.Text = "";
            EnableBtnSalvar();
        }

        private void txbContaNewPassword_TextChanged(object sender, EventArgs e)
        {
            string input = txbContaNewPassword.Text;
            lblContaNewPasswordValidation.Text = "";
            if (input == string.Empty)
            {
                lblContaNewPasswordValidation.Text = "";
                return;
            }
            CheckPasswordStrenght verifica = new CheckPasswordStrenght();
            CheckPasswordStrenght.PasswordStrenght forca;
            forca = verifica.GetPasswordStrenght(txbContaNewPassword.Text);
            lblContaNewPasswordValidation.Text = Extensions.GetEnumDescription(forca);

            if (lblContaNewPasswordValidation.Text == "Inaceitável" || lblContaNewPasswordValidation.Text == "Fraca")
                lblContaNewPasswordValidation.ForeColor = Color.Red;
            else if (lblContaNewPasswordValidation.Text == "Aceitável")
                lblContaNewPasswordValidation.ForeColor = Color.Blue;
            else if (lblContaNewPasswordValidation.Text == "Forte" || lblContaNewPasswordValidation.Text == "Segura")
                lblContaNewPasswordValidation.ForeColor = Color.Green;
            if (txbContaCurrentPassword.Text != string.Empty)
            {
                if (!txbContaCurrentPassword.Text.Equals(txbContaNewPassword.Text))
                    validPassword = true;
                else
                {
                    lblContaNewPasswordValidation.Text = "Sua nova senha deve ser diferente da senha atual.";
                    lblContaNewPasswordValidation.ForeColor = Color.Red;
                }
            }

            EnableBtnSalvar();
        }
        private void EnableBtnSalvar()
        {
            if (validName && validPassword &&
                (lblContaNewPasswordValidation.Text == "Aceitável" ||
                lblContaNewPasswordValidation.Text == "Forte" ||
                    lblContaNewPasswordValidation.Text == "Segura"))
                btnContaSalvar.Enabled = true;
            else
                btnContaSalvar.Enabled = false;
            if (txbContaCurrentPassword.Text != String.Empty && !user.CheckPassword(txbContaCurrentPassword.Text))
            {
                lblContaPasswordValidation.Text = "Senha incorreta.";
                lblContaPasswordValidation.ForeColor = Color.Red;
            }
        }

        private void chbContaMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (!CadastroMostrarSenha)
            {
                CadastroMostrarSenha = true;
                txbContaCurrentPassword.UseSystemPasswordChar = false;
                txbContaNewPassword.UseSystemPasswordChar = false;
                chbContaMostrarSenha.Text = "Esconder Senha";
            }
            else
            {
                CadastroMostrarSenha = false;
                txbContaCurrentPassword.UseSystemPasswordChar = true;
                txbContaNewPassword.UseSystemPasswordChar = true;
                chbContaMostrarSenha.Text = "Mostrar Senha";
            }
        }

        private void btnContaVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContaSalvar_Click(object sender, EventArgs e)
        {
            //alterar o objeto na lista
            if (user.Name != txbContaName.Text)
                user.ChangeName(txbContaName.Text);
            if (!user.CheckPassword(txbContaNewPassword.Text))
                user.ChangePassword(txbContaNewPassword.Text);
            txbContaCurrentPassword.Text = "";
            txbContaNewPassword.Text = "";
        }
    }
}
