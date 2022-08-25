using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Portfolio.Domain;
using Portfolio.Services;
using static Portfolio.Services.Extensions;

namespace Portfolio.Presentation
{
    public partial class FrmRegistration : Form
    {
        bool CadastroMostrarSenha = false;
        bool validName = false;
        bool validUserName = false;
        bool validBirthDate = false;
        IUserRepository _userRepository;
        Form previousForm;

        public FrmRegistration(IUserRepository userRepository, Form previousForm)
        {
            _userRepository = userRepository;
            InitializeComponent();
            lblCadastroNameValidation.Text = "";
            lblCadastroBirthDateValidation.Text = "";
            lblCadastroUserNameValidation.Text = "";
            lblCadastroPasswordValidation.Text = "";
            lblCadastroPasswordConfirmValidation.Text = "";
            btnCadastroEnviar.Enabled = false;
            this.previousForm = previousForm;
        }

        private void chbCadastroMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (!CadastroMostrarSenha)
            {
                CadastroMostrarSenha = true;
                txbCadastroTypePassword.UseSystemPasswordChar = false;
                txbCadastroConfirmPassword.UseSystemPasswordChar = false;
                chbCadastroMostrarSenha.Text = "Esconder Senha";
            }
            else
            {
                CadastroMostrarSenha = false;
                txbCadastroTypePassword.UseSystemPasswordChar = true;
                txbCadastroConfirmPassword.UseSystemPasswordChar = true;
                chbCadastroMostrarSenha.Text = "Mostrar Senha";
            }
        }

        private void txbCadastroName_TextChanged(object sender, EventArgs e)
        {
            string input = txbCadastroName.Text;
            lblCadastroNameValidation.Text = "";
            validName = false;
            if (input == string.Empty)
            {
                lblCadastroNameValidation.Text = "";
                txbCadastroName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            }
            else if (input[0] == ' ' || input.Replace(" ", "") == "")
            {
                txbCadastroName.ForeColor = Color.Red;
                lblCadastroNameValidation.Text = "Nome inválido.";
                lblCadastroNameValidation.ForeColor = Color.Red;
                return;
            }
            else
            {
                input = txbCadastroName.Text;
                string[] names = input.Split(' ');
                if (names.Length >= 2 && names[1] != "")
                {
                    lblCadastroNameValidation.Text = "Nome válido";
                    lblCadastroNameValidation.ForeColor = Color.Green;
                    txbCadastroName.ForeColor = Color.Green;
                    validName = true;
                }
            }
            EnableBtnEnviar();
        }

        private void mtxBirthDate_TextChanged(object sender, EventArgs e)
        {
            validBirthDate = false;
            DateTime birthDate;
            string input = mtxBirthDate.Text;
            if (input == string.Empty || input.Length < 10)
            {
                lblCadastroBirthDateValidation.Text = "";
                mtxBirthDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            }
            else
            {
                if (DateTime.TryParse(input, out birthDate))
                {
                    lblCadastroBirthDateValidation.Text = "Data válida.";
                    lblCadastroBirthDateValidation.ForeColor = Color.Green;
                    mtxBirthDate.ForeColor = Color.Green;
                    validBirthDate = true;
                }
                else
                {
                    lblCadastroBirthDateValidation.Text = "Data inválida.";
                    lblCadastroBirthDateValidation.ForeColor = Color.Red;
                    mtxBirthDate.ForeColor = Color.Red;
                }
            }
            EnableBtnEnviar();
        }

        private void txbCadastroUserName_TextChanged(object sender, EventArgs e)
        {
            string input = txbCadastroUserName.Text;
            lblCadastroUserNameValidation.Text = "";
            validUserName = false;
            if (input == string.Empty)
                lblCadastroUserNameValidation.Text = "";
            else if (input.Replace(" ", "") == "")
            {
                lblCadastroUserNameValidation.Text = "Nome de usuário inválido.";
                lblCadastroUserNameValidation.ForeColor = Color.Red;
                txbCadastroUserName.ForeColor = Color.Red;
            }
            else
            {
                input = txbCadastroUserName.Text;

                if (input != string.Empty && input[^1] == ' ')
                    return;
                string[] names = input.Split(' ');
                if (names.Length > 1)
                {
                    lblCadastroUserNameValidation.Text = "Seu nome de usuário não pode conter mais que uma palavra ou iniciar com espaço.";
                    lblCadastroUserNameValidation.ForeColor = Color.Red;
                    txbCadastroUserName.ForeColor = Color.Red;
                }
                else if (input.Length > 35)
                {
                    lblCadastroUserNameValidation.Text = "Um nome de usuário válido deve contar no máximo 35 caracteres.";
                    lblCadastroUserNameValidation.ForeColor = Color.Red;
                    txbCadastroUserName.ForeColor = Color.Red;
                }
                else if (!_userRepository.LookForUsername(input))
                {
                    lblCadastroUserNameValidation.Text = "Nome válido";
                    lblCadastroUserNameValidation.ForeColor = Color.Green;
                    txbCadastroUserName.ForeColor = Color.Green;
                    validUserName = true;
                }
                else
                {
                    lblCadastroUserNameValidation.Text = "Este usuário já está cadastrado.";
                    lblCadastroUserNameValidation.ForeColor = Color.Red;
                    txbCadastroUserName.ForeColor = Color.Red;
                }
            }
            EnableBtnEnviar();
        }
        private void txbCadastroTypePassword_TextChanged(object sender, EventArgs e)
        {
            string input = txbCadastroTypePassword.Text;
            lblCadastroPasswordValidation.Text = "";
            if (input == string.Empty)
            {
                lblCadastroPasswordValidation.Text = "";
                return;
            }
            CheckPasswordStrenght verifica = new CheckPasswordStrenght();
            CheckPasswordStrenght.PasswordStrenght forca;
            forca = verifica.GetPasswordStrenght(txbCadastroTypePassword.Text);
            lblCadastroPasswordValidation.Text = Extensions.GetEnumDescription(forca);

            if (lblCadastroPasswordValidation.Text == "Inaceitável" || lblCadastroPasswordValidation.Text == "Fraca")
                lblCadastroPasswordValidation.ForeColor = Color.Red;
            else if (lblCadastroPasswordValidation.Text == "Aceitável")
                lblCadastroPasswordValidation.ForeColor = Color.Blue;
            else if (lblCadastroPasswordValidation.Text == "Forte" || lblCadastroPasswordValidation.Text == "Segura")
                lblCadastroPasswordValidation.ForeColor = Color.Green;
            EnableBtnEnviar();
        }
        private void txbCadastroConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            lblCadastroPasswordConfirmValidation.Text = "";
            EnableBtnEnviar();
        }

        private void EnableBtnEnviar()
        {
            if (validName && validUserName && validBirthDate &&
                (lblCadastroPasswordValidation.Text == "Aceitável" ||
                lblCadastroPasswordValidation.Text == "Forte" ||
                    lblCadastroPasswordValidation.Text == "Segura")
                && txbCadastroConfirmPassword.Text != "")
                btnCadastroEnviar.Enabled = true;
            else
                btnCadastroEnviar.Enabled = false;
        }

        private void txbCadastroName_Leave(object sender, EventArgs e)
        {
            string input = txbCadastroName.Text;
            lblCadastroNameValidation.Text = "";
            validName = false;
            if (input == string.Empty || input.Replace(" ", "") == "")
                return;
            else if (input.Replace(" ", "") == "")
            {
                lblCadastroNameValidation.Text = "Informe um nome válido";
                lblCadastroNameValidation.ForeColor = Color.Red;
                return;
            }
            else
            {
                input = txbCadastroName.Text;
                if (input != string.Empty && (input[0] == ' ' || input[^1] == ' '))
                {
                    lblCadastroNameValidation.Text = "Nome inválido. Existe um espaço no início ou no final do nome.";
                    lblCadastroNameValidation.ForeColor = Color.Red;
                    txbCadastroName.ForeColor = Color.Red;
                    return;
                }
                string[] names = input.Split(' ');
                if (names.Length < 2)
                {
                    lblCadastroNameValidation.Text = "Nome inválido.";
                    lblCadastroNameValidation.ForeColor = Color.Red;
                    txbCadastroName.ForeColor = Color.Red;
                }
                else
                {
                    if (names[1] != "")
                    {
                        lblCadastroNameValidation.Text = "Nome válido";
                        lblCadastroNameValidation.ForeColor = Color.Green;
                        txbCadastroName.ForeColor = Color.Green;
                        validName = true;
                    }
                }
            }
        }

        private void mtxBirthDate_Leave(object sender, EventArgs e)
        {
            DateTime birthDate;
            string input = mtxBirthDate.Text.Replace("/", "").Replace(" ", "");
            if (input != string.Empty && input.Length < 8)
            {
                lblCadastroBirthDateValidation.Text = "Informe uma data válida";
                lblCadastroBirthDateValidation.ForeColor = Color.Red;
                mtxBirthDate.ForeColor = Color.Red;
                validBirthDate = false;
            }
        }
        private void btnCadastroEnviar_Click(object sender, EventArgs e)
        {
            if (txbCadastroConfirmPassword.Text != txbCadastroTypePassword.Text)
            {
                txbCadastroConfirmPassword.Text = "";
                txbCadastroConfirmPassword.Focus();
                lblCadastroPasswordConfirmValidation.Text = "As senhas não são iguais. Tente novamente.";
                lblCadastroPasswordConfirmValidation.ForeColor = Color.Red;
                btnCadastroEnviar.Enabled = false;
            }
            else
            {
                DateTime birthDate = DateTime.Parse(mtxBirthDate.Text);

                User newUser = new User(txbCadastroName.Text,
                                        txbCadastroUserName.Text,
                                        DateTime.Parse(mtxBirthDate.Text),
                                        txbCadastroTypePassword.Text);
                _userRepository.AddNewUser(newUser);
                Close();
                previousForm.Show();
            }

        }

        private void btnCadastroVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }
    }
}
