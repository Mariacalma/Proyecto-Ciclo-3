using System.Collections.Generic; 
using pypSln.App.dominio;

namespace pypSln.App.persistencia {
    public interface IFRVisitaPYP {
        visitaPYP AddVisitaPYP(visitaPYP visitaPYP);
        void DeleteVisitaPYP(int idVisitaPYP);
        IEnumerable<visitaPYP> GetAllVisitaPYP();
        visitaPYP GetVisitaPYP(int idVisitaPYP);
        visitaPYP UpdateVisitaPYP(visitaPYP visitaPYP);
    }

}