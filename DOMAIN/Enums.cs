using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Enums
    {
        public enum TipoCobertura
        {
            NoDefinido,
            ObraSocial,
            Prepaga,
            Particular
        }
        public enum Sexo
        {
            NoDefinido,
            Masculino,
            Femenino,
            Otro
        }
        public enum TipoDocumento
        {
            NoDefinido,
            DNI,
            Pasaporte,
            Cedula
        }
        public enum EstadoVisita
        {
            NoDefinido,
            EsperandoTriage,
            EsperandoConsulta,
            ConsultaFinalizada,
            AtencionInmediata,
            Ausente
        }
        public enum NivelUrgencia
        {
            NoDefinido,
            Rojo,
            Amarillo,
            Verde
        }
        public enum GrupoRiesgo
        {
            NoDefinido,
            Mayor80,
            Inmunosuprimido,
            LactanteMenor30Dias,
            Embarazada,
            NoPertenece
        }

    }
}
