using System;

namespace pypSln.App.dominio
{
    public class historiaClinica
    {
        public int Id { get; set; }
        public int Id_registro { get; set; }
        public int Id_propietario { get; set; }
        public int Id_ovino { get; set; }
        public int Id_veterinario { get; set; }
        public DateTime Fecha_registro { get; set; }
        public string Recomendaciones { get; set; }
        public string Formula { get; set; }
    }
}