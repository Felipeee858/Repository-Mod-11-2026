using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace _11T_N06_Etapa3
{
    public class Participante
    {

        public string Nome { get; set; }

        decimal idade;
        public decimal Idade
        {
            get { return idade; }
            set
            {
                if (IsValidIdade(value))
                    idade = value;
                else
                    idade = 0;
            }
        }

        string email = "";
        public string Email
        {
            get { return email; }
            set
            {
                if (IsValidEmail(value))
                    email = value;
                else
                    email = "";
            }
        }

        public Participante(string _nome, decimal _idade, string _email)
        {
            Nome = _nome;
            Idade = _idade;
            Email = _email;
        }

        public Participante(string _nome, string _email) : this(_nome, 16, _email)
        {

        }

        public static bool IsValidEmail(string email)
        {
            bool valido = true;

            try
            {
                MailAddress aux = new MailAddress(email);
            }
            catch (Exception)
            {
                valido = false;
            }

            return valido;
        }

        public static bool IsValidIdade(decimal idade)
        {
            bool valido = true;

            if (idade < 0)
            {
                valido = false;
            }

            return valido;
        }
    }
}

