using System.Collections.Generic; 
using pypSln.App.dominio;

namespace pypSln.App.persistencia {
    public interface IFRPropietario {
        propietario AddPropietario(propietario propietario);
        void DeletePropietario(int idPropietario);
        IEnumerable<propietario> GetAllPropietario();
        propietario GetPropietario(int idPropietario);
        propietario UpdatePropietario(propietario propietario);
    }

}