using System.Collections.Generic; 
using pypSln.App.dominio;

namespace pypSln.App.persistencia {
    public interface IFRPersona {
        persona AddPersona(persona persona);
        void DeletePersona(int idPersona);
        IEnumerable<persona> GetAllPersona();
        persona GetPersona(int idPersona);
        persona UpdatePersona(persona persona);
    }

}