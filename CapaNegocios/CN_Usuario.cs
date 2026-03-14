using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class CN_Usuario
    {
        private CD_Usuario _cd = new CD_Usuario();

        // ── PROPIEDAD ESTÁTICA: usuario logueado disponible en toda la app
        public static Usuario UsuarioActual { get; private set; }

        // ── MÉTODO FUNCIÓN: intenta hacer login y retorna true/false
        public bool Login(string nombreUsuario, string clave)
        {
            // Validación básica antes de ir a la BD
            if (string.IsNullOrWhiteSpace(nombreUsuario) ||
                string.IsNullOrWhiteSpace(clave))
                return false;

            DataTable resultado = _cd.Login(nombreUsuario.Trim(), clave.Trim());

            if (resultado.Rows.Count == 0)
                return false;

            // Cargar el usuario en sesión usando el constructor con parámetros
            DataRow fila = resultado.Rows[0];
            UsuarioActual = new Usuario(
                id: Convert.ToInt32(fila["IdUsuario"]),
                nombre: fila["Nombre"].ToString(),
                apellido: "",
                nombreUsuario: fila["Usuario"].ToString(),
                clave: "",
                rol: fila["Rol"].ToString()
            );

            return true;
        }

        // ── MÉTODO NORMAL: cierra la sesión
        public void CerrarSesion()
        {
            UsuarioActual = null;
        }

        // ── MÉTODO FUNCIÓN: dice si hay alguien logueado
        public static bool HaySesionActiva()
        {
            return UsuarioActual != null;
        }
    }
}
