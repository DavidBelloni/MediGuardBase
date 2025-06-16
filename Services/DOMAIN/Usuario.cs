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
        public Guid Id { get; }
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public string Email { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public DateTime FechaCreacion { get; }


        private readonly List<Component> _permisos = new List<Component>();

        public Usuario(string nombre, string apellido, string email, string username, string password)
        {
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Username = username;
            Password = password;
            FechaCreacion = DateTime.Now;
            Id = Guid.NewGuid();
        }

        public void AsignarPermiso(Component permiso)
        {
            if(!_permisos.Contains(permiso))
                _permisos.Add(permiso);
            throw new InvalidOperationException("El permiso ya está asignado al usuario.");
        }

        public void RemoverPermiso(Component permiso)
        {
            if (!_permisos.Contains(permiso))
                throw new InvalidOperationException("El permiso no está asignado al usuario.");
            _permisos.Remove(permiso);

        }

        // Devuelve todas las patentes (permisos individuales) asignadas directa o indirectamente al usuario, sin duplicados
        public List<Patente> ObtenerPatentes()
        {
            return _permisos
                .SelectMany(p => p.ObtenerPatentes())
                .Distinct()
                .ToList();
        }

    }
}
