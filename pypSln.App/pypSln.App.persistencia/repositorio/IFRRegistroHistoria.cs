using System.Collections.Generic; 
using pypSln.App.dominio;

namespace pypSln.App.persistencia {
    public interface IFRRegistroHistoria {
        registroHistoria AddRegistroHistoria(registroHistoria registroHistoria);
        void DeleteRegistroHistoria(int idRegistroHistoria);
        IEnumerable<registroHistoria> GetAllRegistroHistoria();
        registroHistoria GetRegistroHistoria(int idRegistroHistoria);
        registroHistoria UpdateRegistroHistoria(registroHistoria registroHistoria);
    }

}