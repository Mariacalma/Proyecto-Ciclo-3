using System;

namespace pypSln.App.dominio{
	public class registroHistoria{
        public int Id { get;set; }
        public int Id_propietario { get;set; }
        public int Id_ovino { get;set; }
        public int Id_veterinario { get;set; }
        public DateTime Fecha { get;set; }
	}
}