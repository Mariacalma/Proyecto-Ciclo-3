

using System.Collections.Generic;  //libreria donde se definen las interfaces
using pypSln.App.dominio;
using System.Linq;


namespace pypSln.App.persistencia{
    public class ROvino : IFROvino  {
        private readonly AppContext _appContext;
        public ROvino(AppContext appContext) {
            _appContext = appContext;
        }
        ovino IFROvino.Addovino(ovino ovino) {
            var ovinoAdicionado = _appContext.ovino.Add(ovino);
            _appContext.SaveChanges();
            return ovinoAdicionado.Entity;
        }
        void ROvino.Deleteovino(int Idovino) {
            var ovinoEncontrado = _appContext.ovino.FirstOrDefault(p => p.i == idovino);
            if (ovinoEncontrado = null) {
                return;
            }
            _appContext.ovino.Remove(ovinoEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<ovino> IFROvino.GetAllovino() {
            return _appContext.ovino;
        }
        ovino IFROvino.Getovino(int Idovino) {
            return _appContext.ovino.FirstOrDefault(p => p.Id == Idovino);
        }
        ovino IFROvino.Updateovino(ovino ovino) {
            var ovinoEncontrado = _appContext.ovino.FirstOrDefault(p => p.Id == ovino.Id);
            if (ovinoEncontrado != null) {
                ovinoEncontrado.Id = ovino.Id;
                ovinoEncontrado.Nombre = ovino.Nombre;
                ovinoEncontrado.color = ovino.color;
                ovinoEncontrado.especie = ovino.especie;
                ovinoEncontrado.raza = ovino.raza;
                ovinoEncontrado.sexo = ovino.sexo;
                _appContext.SaveChanges();
            }
            return ovinoEncontrado;
        }
    }
}