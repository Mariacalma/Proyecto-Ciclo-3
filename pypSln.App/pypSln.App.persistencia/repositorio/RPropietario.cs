

using System.Collections.Generic;  //libreria donde se definen las interfaces
using pypSln.App.dominio;
using System.Linq;


namespace pypSln.App.persistencia{
    public class RPropietrario : IFRPropietrario  {
        private readonly AppContext _appContext;
        public RPropietrario(AppContext appContext) {
            _appContext = appContext;
        }
        propietrario IFRPropietrario.Addpropietrario(propietrario propietrario) {
            var propietrarioAdicionado = _appContext.propietrario.Add(propietrario);
            _appContext.SaveChanges();
            return propietrarioAdicionado.Entity;
        }
        void RPropietrario.Deletepropietrario(int Idpropietrario) {
            var propietrarioEncontrado = _appContext.propietrario.FirstOrDefault(p => p.i == idpropietrario);
            if (propietrarioEncontrado = null) {
                return;
            }
            _appContext.propietrario.Remove(propietrarioEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<propietrario> IFRPropietrario.GetAllpropietrario() {
            return _appContext.propietrario;
        }
        propietrario IFRPropietrario.Getpropietrario(int Idpropietrario) {
            return _appContext.propietrario.FirstOrDefault(p => p.Id == Idpropietrario);
        }
        propietrario IFRPropietrario.Updatepropietrario(propietrario propietrario) {
            var propietrarioEncontrado = _appContext.propietrario.FirstOrDefault(p => p.Id == propietrario.Id);
            if (propietrarioEncontrado != null) {
                propietrarioEncontrado.Id = propietrario.Id;
                _appContext.SaveChanges();
            }
            return propietrarioEncontrado;
        }
    }
}