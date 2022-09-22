using System.Collections.Generic; 
using pypSln.App.dominio;

namespace pypSln.App.persistencia {
    public interface IFRVisitaPYP {
        visitapyp AddVisitaPYP(visitapyp visitaPYP);
        void DeleteVisitaPYP(int idVisitaPYP);
        IEnumerable<visitapyp> GetAllVisitaPYP();
        visitapyp GetVisitaPYP(int idVisitaPYP);
        visitapyp UpdateVisitaPYP(visitapyp visitaPYP);
    }

}