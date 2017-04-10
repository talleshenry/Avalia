using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalia.DAO;
using Avalia.DTO;

namespace Avalia.Model
{
    public class UsuarioModel
    {

        static UsuarioDTO usuarioAutenticado;

        public int IncluirUsuario(UsuarioDTO objUsuarioDTO)
        {
            return new UsuarioDAO().IncluirUsuario(objUsuarioDTO);
        }

        public IList<UsuarioDTO> CarregarUsuario()
        {

            return new UsuarioDAO().CarregarUsuario();
        }

        public UsuarioDTO AutenticacaoUsuario(UsuarioDTO objUsuario)
        {
            usuarioAutenticado  =  new UsuarioDAO().Autentica(objUsuario);
            UsuarioLogado.setUsuarioLogado(usuarioAutenticado);

            return usuarioAutenticado;
        }

    }
}
