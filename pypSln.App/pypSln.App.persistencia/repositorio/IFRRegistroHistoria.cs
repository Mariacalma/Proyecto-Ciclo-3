using System.Collections.Generic; 
using pypSln.App.dominio;

namespace pypSln.App.persistencia {
    public interface IFRRegistroHistoria {
        registroHistoria AddRegistroHistroria(registroHistoria registroHistoria);
        void DeleteRegistroHistroria(int idRegistroHistroria);
        IEnumerable<registroHistoria> GetAllRegistroHistroria();
        registroHistoria GetRegistroHistroria(int idRegistroHistroria);
        registroHistoria UpdateRegistroHistroria(registroHistoria registroHistoria);
    }

}