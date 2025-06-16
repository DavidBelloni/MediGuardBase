using Services.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    // clase que representa una familia de permisos, que hereda de Component
    public class Familia : Component
    {
        private readonly List<Component> _hijos = new List<Component>();

        public Familia(string nombre, string descripcion) : base(nombre, descripcion) { }

        public void Agregar(Component componente)
        {
            if (!_hijos.Contains(componente))
                _hijos.Add(componente);
        }

        public void Quitar(Component componente)
        {
            if (_hijos.Contains(componente))
                _hijos.Remove(componente);
        }

        public override List<Patente> ObtenerPatentes()
        {
            var patentes = new List<Patente>();

            foreach (var hijo in _hijos)
            {
                patentes.AddRange(hijo.ObtenerPatentes());
            }
            return patentes;
        }
    }
}
