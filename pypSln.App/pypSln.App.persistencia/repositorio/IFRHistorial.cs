using System.Collections.Generic; 
using pypSln.App.dominio;

namespace pypSln.App.persistencia {
    public interface IFRHistorial {
        historiaClinica AddHistorial(historiaClinica historial);
        void DeleteHistorial(int idHistorial);
        IEnumerable<historiaClinica> GetAllHistorial();
        historiaClinica GetHistorial(int idHistorial);
        historiaClinica UpdateHistorial(historiaClinica historial);
    }

}