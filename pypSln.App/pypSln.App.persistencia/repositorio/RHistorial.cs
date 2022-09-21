

using System.Collections.Generic;  //libreria donde se definen las interfaces
using pypSln.App.dominio;
using System.Linq;


namespace pypSln.App.persistencia{
    public class RHistorial : IFRHistorial  {
        private readonly AppContext _appContext;
        public RHistoria(AppContext appContext) {
            _appContext = appContext;
        }
        historial IFRHistorial.Addhistorial(historial historial) {
            var historialAdicionado = _appContext.historial.Add(historial);
            _appContext.SaveChanges();
            return historialAdicionado.Entity;
        }
        void RHistoria.Deletehistorial(int Idhistorial) {
            var historialEncontrado = _appContext.historial.FirstOrDefault(p => p.i == idhistorial);
            if (historialEncontrado = null) {
                return;
            }
            _appContext.historial.Remove(historialEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<historial> IFRHistorial.GetAllhistorial() {
            return _appContext.historial;
        }
        historial IFRHistorial.Gethistorial(int Idhistorial) {
            return _appContext.historial.FirstOrDefault(p => p.Id == Idhistorial);
        }
        historial IFRHistorial.Updatehistorial(historial historial) {
            var historialEncontrado = _appContext.historial.FirstOrDefault(p => p.Id == historial.Id);
            if (historialEncontrado != null) {
                historialEncontrado.Id = historial.Id;
                historialEncontrado.Id_registro = historial.Id_registro;
                historialEncontrado.Id_propietario = historial.Id_propietario;
                historialEncontrado.Id_ovino = historial.Id_ovino;
                historialEncontrado.Id_veterinario = historial.Id_veterinario;
                historialEncontrado.Fecha_registro = historial.Fecha_registro;
                historialEncontrado.Recomendaciones = historial.Recomendaciones;
                historialEncontrado.Formula = historial.Formula;
                historialEncontrado.Id = historial.Id;
                historialEncontrado.Id = historial.Id;
                _appContext.SaveChanges();
            }
            return historialEncontrado;
        }
    }
}