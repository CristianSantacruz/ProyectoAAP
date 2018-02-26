using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Negocio
{
    public class NegocioUsuario
    {
        public static string insertarUsuario(string nombreUsuario, string loginUsuario, string passwordUsuario, string cargoUsuario)
        {
            DatosUsuario usuario = new DatosUsuario();
            usuario.NombreUsuario = nombreUsuario;
            usuario.LoginUsuario = loginUsuario;
            usuario.PasswordUsuario = passwordUsuario;
            usuario.CargoUsuario = cargoUsuario;

            return usuario.insertarUsuario(usuario);
        }

        public static DataTable mostrarUsuario()
        {
            return new DatosUsuario().mostrarUsuarios();
        }

        public static DataTable cargarCajeros()
        {
            return new DatosUsuario().cargarCajeros();
        }

        public static DataTable consultarUsuarioTabla(string nombreusuario)
        {
            DatosUsuario usuario = new DatosUsuario();
            usuario.NombreUsuario = nombreusuario;

            return usuario.consultarUsuarioTabla(usuario);
        }

        public static string buscarUsuario(string nombreusuario)
        {
            DatosUsuario usuario = new DatosUsuario();
            usuario.NombreUsuario = nombreusuario;

            return usuario.buscarUsuario(usuario);
        }

        public static string actualizarUsuario(string nombreUsuario, string passwordUsuario)
        {
            DatosUsuario usuario = new DatosUsuario();
            usuario.NombreUsuario = nombreUsuario;
            usuario.PasswordUsuario = passwordUsuario;

            return usuario.actualizarUsuario(usuario);
        }

        public static string eliminarUsuario(string nombreUsuario)
        {
            DatosUsuario usuario = new DatosUsuario();
            usuario.NombreUsuario = nombreUsuario;

            return usuario.eliminarUsuario(usuario);
        }

        public static DataTable loginUsuario(string login, string contraseña, string cargo)
        {
            DatosUsuario usuario = new DatosUsuario();
            usuario.LoginUsuario = login;
            usuario.PasswordUsuario = contraseña;
            usuario.CargoUsuario = cargo;
            return new DatosUsuario().login(usuario);
        }
    }
}
