using System.Collections.Generic; 
using pypSln.App.dominio;

namespace pypSln.App.persistencia {
    public interface IFROvino {
        ovino AddOvino(ovino ovino);
        void DeleteOvino(int idOvino);
        IEnumerable<ovino> GetAllOvino();
        ovino GetOvino(int idOvino);
        ovino UpdateOvino(ovino ovino);
    }

}