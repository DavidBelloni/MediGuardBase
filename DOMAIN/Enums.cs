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
            ObraSocial,
            Prepaga,
            Particular
        }
        public enum Sexo
        {
            Masculino,
            Femenino,
            Otro
        }
        public enum TipoDocumento
        {
            DNI,
            Pasaporte,
            Cedula
        }
        public enum EstadoVisita
        {
            EsperandoTriage,
            EsperandoConsulta,
            ConsultaFinalizada,
            AtencionInmediata,
            Ausente
        }
        public enum NivelUrgencia
        {
            Rojo,
            Amarillo,
            Verde
        }
        public enum GrupoRiesgo
        {
            Mayor80,
            Inmunosuprimido,
            LactanteMenor30Dias,
            Embarazada,
            NoPertenece
        }

        public enum TipoEspecialidad
        {
            MedicoClinico,
            Pediatria,
            Traumatologia,
            Cardiologia,
            Dermatologia,
            Ginecologia,
            Oftalmologia,
            Otorrinolaringologia,
            Psiquiatria,
            Urologia
        }

    }
}
