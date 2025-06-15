using Services.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Usuario
    {
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public string Email { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }


        private readonly List<Componente> _permisos = new List<Componente>();

        public Usuario(string nombre, string apellido, string email, string username, string password)
        {
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Username = username;
            Password = password;
        }

        public void AsignarPermiso(Componente permiso)
        {
            _permisos.Add(permiso);
        }

        public void RemoverPermiso(Componente permiso)
        {   
            _permisos.Remove(permiso);
        }

        // Devuelve todas las patentes (permisos individuales) asignadas directa o indirectamente al usuario, sin duplicados
        public List<Patente> ObtenerTodosLosPermisos()
        {
            return _permisos
                .SelectMany(p => p.ObtenerPatentes())
                .Distinct()
                .ToList();
        }

    }
}
