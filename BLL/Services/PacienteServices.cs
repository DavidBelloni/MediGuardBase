﻿using DAL.Contracts;
using DAL.Factory;
using DAL.Implementation.Memory;
using DAL.Implementation.SqlServer;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DOMAIN.Enums;

namespace BLL.Services
{
    public class PacienteServices
    {
        private readonly IPacienteRepository pacienteRepository;

        public PacienteServices()
        {
            // Devuelve una instancia de la clase Paciente
            pacienteRepository = FactoryDao.PacienteRepository;
        }

        public Paciente RegistrarPaciente(Paciente paciente)
        { 
            var pacienteRegistrado = pacienteRepository.Add(paciente);
            return pacienteRegistrado;
        }

        public bool ValidarDni(string dniTexto, out int dni)
        {
            dni = 0;
            if (string.IsNullOrWhiteSpace(dniTexto) || !int.TryParse(dniTexto, out dni))
            {
                return false;
            }
            return true;
        }

        public bool ValidarDatosPaciente(Paciente paciente, string grupoRiesgo)
        {
            // Validar que todos los campos obligatorios estén completos
            if (string.IsNullOrWhiteSpace(paciente.Nombre) ||
                string.IsNullOrWhiteSpace(paciente.Apellido) ||
                string.IsNullOrWhiteSpace(paciente.Celular) ||
                string.IsNullOrWhiteSpace(paciente.Email) ||
                string.IsNullOrWhiteSpace(paciente.CoberturaMedica) ||
                string.IsNullOrWhiteSpace(grupoRiesgo) ||
                paciente.Sexo < 0 || // Comprobación si sexo no está definido
                paciente.TipoCobertura < 0 ||  // Comprobación si cobertura no está definida
                paciente.TipoDocumento < 0) // Comprobación si tipo de documento no está definido
            {
                return false;
            }

            return true;
        }

        public Paciente GetPacienteByDni(int dni, TipoDocumento? tipoDocumento)
        {
            // Validar que el número de documento sea válido
            if (dni <= 0)
            {
                throw new ArgumentException("El número de documento debe ser un valor positivo.");
            }

            // Validar que el tipo de documento sea válido
            if (tipoDocumento == null || !Enum.IsDefined(typeof(TipoDocumento), tipoDocumento))
            {
                throw new ArgumentException("Debe seleccionar un tipo de documento válido.");
            }

            // Buscar el paciente por DNI y tipo de documento
            return pacienteRepository.GetByDni(dni, tipoDocumento.Value);
        }

    }
}
