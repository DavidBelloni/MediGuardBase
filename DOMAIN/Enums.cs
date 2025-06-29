﻿using System;
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

        //Se podria eliminar y que sea tipo boolean
        public enum GrupoRiesgo
        {
            Mayor80,
            Inmunosuprimido,
            LactanteMenor30Dias,
            Embarazada,
            NoPertenece
        }

    }
}
