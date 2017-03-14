using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devart.Data.PostgreSql;
using Avalia.DTO;


namespace Avalia.DAO
{
    public class UsuarioDAO
    {
        public int IncluirUsuario(UsuarioDTO objUsuarioDTO)
        {

            PgSqlConnection conn = new PgSqlConnection("User Id=postgres;Password=1254;host=localhost;database=Cadastro;");
            PgSqlCommand cmd = new PgSqlCommand();
            cmd.CommandText = string.Format("INSERT INTO public.\"tbUsuario\"(\"cpf_usu\", \"senha_usu\", \"nome_usu\",\"login_usu\", \"email_usu\", \"nivelAcesso_usu\") " +
                "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", objUsuarioDTO.Cpf, objUsuarioDTO.Senha, objUsuarioDTO.Nome, objUsuarioDTO.Login, objUsuarioDTO.Email, objUsuarioDTO.NivelDeAcesso);

            cmd.Connection = conn;
            conn.Open();

            int aff = cmd.ExecuteNonQuery();


            conn.Close();


            return aff;
        }

        public UsuarioDTO Autentica(UsuarioDTO objUsuario)
        {
            PgSqlConnection conn = new PgSqlConnection("User Id=postgres;Password=root;host=localhost;database=NIVEL_ACESSO;");
            PgSqlCommand cmd = new PgSqlCommand();
            cmd.CommandText = string.Format("SELECT * FROM public.\"TRABALHADORES\" WHERE \"LOGIN\" ='{0}' AND \"SENHA\" = '{1}';", objUsuario.Login, objUsuario.Senha);
            cmd.Connection = conn;
            conn.Open();

            int aff = cmd.ExecuteNonQuery();

            PgSqlDataReader ER;

            UsuarioDTO usuario = new UsuarioDTO();

            ER = cmd.ExecuteReader();

            if (ER.Read())
            {
                usuario.Cpf = Convert.ToString(ER["cpf_usu"]);
                usuario.Nome = Convert.ToString(ER["nome_usu"]);
                usuario.Email = Convert.ToString(ER["email_usu"]);
                usuario.Login = Convert.ToString(ER["login_usu"]);
                usuario.Senha = Convert.ToString(ER["senha_usu"]);
                usuario.NivelDeAcesso = Convert.ToInt16(ER["nivelAcesso_usu"]);
            }

            

            conn.Close();

            return usuario;
        }

        public IList<UsuarioDTO> CarregarUsuario()
        {

            PgSqlConnection conn = new PgSqlConnection("User Id=postgres;Password=root;host=localhost;database=NIVEL_ACESSO;");
            PgSqlCommand cmd = new PgSqlCommand();
            cmd.CommandText = "SELECT * FROM public.\"TRABALHADORES\"";
            cmd.Connection = conn;
            conn.Open();

            int aff = cmd.ExecuteNonQuery();




            PgSqlDataReader ER;

            IList<UsuarioDTO> listaUsuarioDTO = new List<UsuarioDTO>();

            ER = cmd.ExecuteReader();

            if (ER.HasRows)
            {
                while (ER.Read())
                {

                    UsuarioDTO usuario = new UsuarioDTO();

                    usuario.Cpf = Convert.ToString(ER["CPF"]);
                    usuario.Nome = Convert.ToString(ER["NOME"]);
                    usuario.Email = Convert.ToString(ER["EMAIL"]);
                    usuario.Login = Convert.ToString(ER["LOGIN"]);
                    usuario.Status = Convert.ToChar(ER["STATUS"]);
                    usuario.Senha = Convert.ToString(ER["SENHA"]);
                    usuario.NivelDeAcesso = Convert.ToInt16(ER["NIVEL_DE_ACESSO"]);

                    listaUsuarioDTO.Add(usuario);
                }
            }

            conn.Close();

            return listaUsuarioDTO;

        }
    }
}
