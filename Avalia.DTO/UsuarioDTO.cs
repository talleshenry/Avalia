using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalia.DTO
{
    public class UsuarioDTO
    {
        private int codigo;
        private string nome;
        private string login;
        private string senha;
        private string email;
        private string cpf;
        private char status;
        private int nivelDeAcesso;
        //private DateTime dataCadastro;

        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public char Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public int NivelDeAcesso
        {
            get
            {
                return nivelDeAcesso;
            }

            set
            {
                nivelDeAcesso = value;
            }
        }
        
    }
}
