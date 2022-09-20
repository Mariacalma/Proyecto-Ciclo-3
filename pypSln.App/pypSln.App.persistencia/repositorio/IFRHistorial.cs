using System.Collections.Generic; 
using pypSln.App.dominio;

namespace pypSln.App.persistencia {
    public interface IFRHistorial {
        historial AddHistorial(historial historial);
        void DeleteHistorial(int idHistorial);
        IEnumerable<historial> GetAllHistorial();
        historial GetHistorial(int idHistorial);
        historial UpdateHistorial(historial historial);
    }

}