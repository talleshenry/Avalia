using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalia.DTO
{
    public class UsuarioDTO
    {
       
        private string nome;        
        private string senha;
        private string email;
        private string cpf;   //Este campo é not null e a chave primária no banco    
        private int nivelDeAcesso;
        private string telefone;

        //private DateTime dataCadastro;
        // private char status;
        //private int codigo;
        //private string login;


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

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }
    }
}
