using System;

namespace GimnasioClientes
{
    [Serializable]
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public DateTime FechaInscripcion { get; set; } = DateTime.Now;
        public string Membresia { get; set; } = "Básica";
        public bool Activo { get; set; } = true;

        public override string ToString()
        {
            return $"{Nombre} {Apellido} - {Membresia} {(Activo ? "(Activo)" : "(Inactivo)")}";
        }
    }
}