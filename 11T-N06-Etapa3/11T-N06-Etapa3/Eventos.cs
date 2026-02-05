using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11T_N06_Etapa3
{
    public class Eventos
    {
        private static int autoID;

        protected int IDD;
        public BindingList<Participante> Part { get; set; } = new BindingList<Participante>();

        public const int CAPACIDADE_MIN = 16;

        public const int Idade_MIN = 16;
        public string Nome { get; set; }
        public DateTime Data { get; set; }

        decimal idade;

        public decimal capacidadeMax; //Limite Participantes

        public int ID
        {
            get { return IDD; }
        }

        public decimal CapacidadeMax
        {
            get { return capacidadeMax; }
            set
            {
                if (IsValidCapacidadeMaxl(value))
                    capacidadeMax = value;
                else
                    capacidadeMax = CAPACIDADE_MIN;
            }
        }

        public decimal IdadeMin
        {
            get { return idade; }
            set
            {
                if (IsValidIdade(value))
                    idade = value;
                else
                    idade = Idade_MIN;

            }
        }


        public Eventos() { }
        public Eventos(string _nome, DateTime _data, decimal _capacidadeMax,decimal _idade)
        {
            IDD = ++autoID;
            Nome = _nome;
            Data = _data;
            IdadeMin = _idade;
            CapacidadeMax = _capacidadeMax;
        }

        public static bool IsValidCapacidadeMaxl(decimal capacidade)
        {
            bool valido = true;

            if (capacidade < 1)
            {
                valido = false;
            }

            return valido;
        }

        public static bool IsValidIdade(decimal idade)
        {
            bool valido = true;
            if ( idade <= 0)
            {
                valido = false;
            }
            return valido;
        }
    }
}


