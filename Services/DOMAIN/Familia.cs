using Services.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Familia : Componente
    {
        private readonly List<Componente> _hijos = new List<Componente>();

        public Familia(string nombre) : base(nombre) { }

        public void Agregar(Componente componente)
        {
            _hijos.Add(componente);
        }

        public void Quitar(Componente componente)
        {
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
