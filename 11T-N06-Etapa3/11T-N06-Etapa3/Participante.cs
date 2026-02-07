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

        public DateTime Data;

        

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
        public DateTime Data_Adicionado
        {
            get { return Data; }
            set { Data = DateTime.Today; }
        }

        public Participante(string _nome, decimal _idade, string _email, DateTime _data)
        {
            Nome = _nome;
            Idade = _idade;
            Email = _email;
            Data_Adicionado = _data;
        }

        public Participante(string _nome, string _email, DateTime _data) : this(_nome, 16, _email,_data)
        {

        }

        public Participante()
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

