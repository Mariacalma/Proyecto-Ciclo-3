using System;

namespace pypSln.App.dominio{
	public class visitapyp{
        public int Id { get;set; }
        public int Id_ovino { get;set; }
        public int Id_propietario { get;set; }
        public int Id_veterinario { get;set; }
        public DateTime fecha { get;set; }
        public double Temperatura { get;set; }
        public double peso { get;set; }
        public double Fre_respiratoria { get;set; }
        public double Fre_cardiaca { get;set; }
        public string Estado { get;set; }
        public string Recomendaciones { get;set; }
        public string formula { get;set; }
	}
}