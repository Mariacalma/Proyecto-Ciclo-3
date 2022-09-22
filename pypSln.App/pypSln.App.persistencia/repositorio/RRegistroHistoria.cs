

using System.Collections.Generic;  //libreria donde se definen las interfaces
using pypSln.App.dominio;
using System.Linq;


namespace pypSln.App.persistencia{
    public class RRegistroHistoria : IFRRegistroHistoria  {
        private readonly appContext _appContext;
        public RRegistroHistoria(appContext appContext) {
            _appContext = appContext;
        }
        registroHistoria IFRRegistroHistoria.AddRegistroHistoria(registroHistoria registroHistoria) {
            var registroHistoriaAdicionado = _appContext.registroHistoria.Add(registroHistoria);
            _appContext.SaveChanges();
            return registroHistoriaAdicionado.Entity;
        }
        void IFRRegistroHistoria.DeleteRegistroHistoria(int IdregistroHistoria) {
            var registroHistoriaEncontrado = _appContext.registroHistoria.FirstOrDefault(p => p.Id == IdregistroHistoria);
            _appContext.registroHistoria.Remove(registroHistoriaEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<registroHistoria> IFRRegistroHistoria.GetAllRegistroHistoria() {
            return _appContext.registroHistoria;
        }
        registroHistoria IFRRegistroHistoria.GetRegistroHistoria(int IdregistroHistoria) {
            return _appContext.registroHistoria.FirstOrDefault(p => p.Id == IdregistroHistoria);
        }
        registroHistoria IFRRegistroHistoria.UpdateRegistroHistoria(registroHistoria registroHistoria) {
            var registroHistoriaEncontrado = _appContext.registroHistoria.FirstOrDefault(p => p.Id == registroHistoria.Id);
            if (registroHistoriaEncontrado != null) {
                registroHistoriaEncontrado.Id = registroHistoria.Id;
                registroHistoriaEncontrado.Id_propietario = registroHistoria.Id_propietario;
                registroHistoriaEncontrado.Id_ovino = registroHistoria.Id_ovino;
                registroHistoriaEncontrado.Id_veterinario = registroHistoria.Id_veterinario;
                registroHistoriaEncontrado.Fecha = registroHistoria.Fecha;
                _appContext.SaveChanges();
            }
            return registroHistoriaEncontrado;
        }
    }
}