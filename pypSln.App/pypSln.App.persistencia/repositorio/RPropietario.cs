

using System.Collections.Generic;  //libreria donde se definen las interfaces
using pypSln.App.dominio;
using System.Linq;


namespace pypSln.App.persistencia{
    public class RPropietario : IFRPropietario  {
        private readonly appContext _appContext;
        public RPropietario(appContext appContext) {
            _appContext = appContext;
        }
        propietario IFRPropietario.AddPropietario(propietario propietario) {
            var propietarioAdicionado = _appContext.propietario.Add(propietario);
            _appContext.SaveChanges();
            return propietarioAdicionado.Entity;
        }
        void IFRPropietario.DeletePropietario(int Idpropietario) {
            var propietarioEncontrado = _appContext.propietario.FirstOrDefault(p => p.Id == Idpropietario);

            _appContext.propietario.Remove(propietarioEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<propietario> IFRPropietario.GetAllPropietario() {
            return _appContext.propietario;
        }
        propietario IFRPropietario.GetPropietario(int Idpropietario) {
            return _appContext.propietario.FirstOrDefault(p => p.Id == Idpropietario);
        }
        propietario IFRPropietario.UpdatePropietario(propietario propietario) {
            var propietarioEncontrado = _appContext.propietario.FirstOrDefault(p => p.Id == propietario.Id);
            if (propietarioEncontrado != null) {
                propietarioEncontrado.Id = propietario.Id;
                _appContext.SaveChanges();
            }
            return propietarioEncontrado;
        }
    }
}