using Portfolio.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Portfolio.Services
{
    public static class Extensions
    {
        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (attributes != null && attributes.Any())
            {
                return attributes.First().Description;
            }

            return value.ToString();
        }
    }
    public class CheckPasswordStrenght
    {

        public enum PasswordStrenght
        {
            [Description("Inaceitável")] Inaceitavel,
            [Description("Fraca")] Fraca,
            [Description("Aceitável")] Aceitavel,
            [Description("Forte")] Forte,
            [Description("Segura")] Segura
        }

        public int generatePasswordPoints(string senha)
        {
            if (senha == null) return 0;
            int pontosPorTamanho = GetPointsByLenght(senha);
            int pontosPorMinusculas = GetPointsByLower(senha);
            int pontosPorMaiusculas = GetPointsByUpper(senha);
            int pontosPorDigitos = GetPointsByDigits(senha);
            int pontosPorSimbolos = GetPointsBySymbols(senha);
            int pontosPorRepeticao = GetPointsByRepetition(senha);
            return pontosPorTamanho + pontosPorMinusculas + pontosPorMaiusculas + pontosPorDigitos + pontosPorSimbolos - pontosPorRepeticao;
        }

        private int GetPointsByLenght(string senha)
        {
            return Math.Min(10, senha.Length) * 7;
        }

        private int GetPointsByLower(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[a-z]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private int GetPointsByUpper(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[A-Z]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private int GetPointsByDigits(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[0-9]", "").Length;
            return Math.Min(2, rawplacar) * 6;
        }

        private int GetPointsBySymbols(string senha)
        {
            int rawplacar = Regex.Replace(senha, "[a-zA-Z0-9]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private int GetPointsByRepetition(string senha)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"(\w)*.*\1");
            bool repete = regex.IsMatch(senha);
            if (repete)
            {
                return 30;
            }
            else
            {
                return 0;
            }
        }


        public PasswordStrenght GetPasswordStrenght(string senha)
        {
            int placar = generatePasswordPoints(senha);

            if (placar < 50)
                return PasswordStrenght.Inaceitavel;
            else if (placar < 60)
                return PasswordStrenght.Fraca;
            else if (placar < 80)
                return PasswordStrenght.Aceitavel;
            else if (placar < 100)
                return PasswordStrenght.Forte;
            else
                return PasswordStrenght.Segura;
        }
    }

    public static class InitBD
    {
        public static void NewUsers(IUserRepository userRepository)
        {           
            User newUser1 = new("Luiza Campello", "luizacampello", DateTime.Parse("19/04/1996"), "123");
            userRepository.AddNewUser(newUser1);
            
            User newUser2 = new("Severo Snape", "halfBloodPrince", DateTime.Parse("09/01/1960"), "LilianEvans");
            userRepository.AddNewUser(newUser2);

        }
    }
}
