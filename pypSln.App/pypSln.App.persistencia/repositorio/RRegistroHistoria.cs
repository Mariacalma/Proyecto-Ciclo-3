

using System.Collections.Generic;  //libreria donde se definen las interfaces
using pypSln.App.dominio;
using System.Linq;


namespace pypSln.App.persistencia{
    public class RRegistroHistoria : IFRRegistroHistoria  {
        private readonly AppContext _appContext;
        public RRegistroHistoria(AppContext appContext) {
            _appContext = appContext;
        }
        registroHistoria IFRRegistroHistoria.AddregistroHistoria(registroHistoria registroHistoria) {
            var registroHistoriaAdicionado = _appContext.registroHistoria.Add(registroHistoria);
            _appContext.SaveChanges();
            return registroHistoriaAdicionado.Entity;
        }
        void RRegistroHistoria.DeleteregistroHistoria(int IdregistroHistoria) {
            var registroHistoriaEncontrado = _appContext.registroHistoria.FirstOrDefault(p => p.i == idregistroHistoria);
            if (registroHistoriaEncontrado = null) {
                return;
            }
            _appContext.registroHistoria.Remove(registroHistoriaEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<registroHistoria> IFRRegistroHistoria.GetAllregistroHistoria() {
            return _appContext.registroHistoria;
        }
        registroHistoria IFRRegistroHistoria.GetregistroHistoria(int IdregistroHistoria) {
            return _appContext.registroHistoria.FirstOrDefault(p => p.Id == IdregistroHistoria);
        }
        registroHistoria IFRRegistroHistoria.UpdateregistroHistoria(registroHistoria registroHistoria) {
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