

using System.Collections.Generic;  //libreria donde se definen las interfaces
using pypSln.App.dominio;
using System.Linq;


namespace pypSln.App.persistencia{
    public class RPersona : IFRPersona  {
        private readonly appContext _appContext;
        public RPersona(appContext appContext) {
            _appContext = appContext;
        }
        persona IFRPersona.AddPersona(persona persona) {
            var personaAdicionado = _appContext.persona.Add(persona);
            _appContext.SaveChanges();
            return personaAdicionado.Entity;
        }
        void IFRPersona.DeletePersona(int Idpersona) {
            var personaEncontrado = _appContext.persona.FirstOrDefault(p => p.Id == Idpersona);

            _appContext.persona.Remove(personaEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<persona> IFRPersona.GetAllPersona() {
            return _appContext.persona;
        }
        persona IFRPersona.GetPersona(int Idpersona) {
            return _appContext.persona.FirstOrDefault(p => p.Id == Idpersona);
        }
        persona IFRPersona.UpdatePersona(persona persona) {
            var personaEncontrado = _appContext.persona.FirstOrDefault(p => p.Id == persona.Id);
            if (personaEncontrado != null) {
                personaEncontrado.Id = persona.Id;
                personaEncontrado.Nombre = persona.Nombre;
                personaEncontrado.Apellidos = persona.Apellidos;
                personaEncontrado.Direccion = persona.Direccion;
                personaEncontrado.Email = persona.Email;
                personaEncontrado.Telefono = persona.Telefono;
                _appContext.SaveChanges();
            }
            return personaEncontrado;
        }
    }
}