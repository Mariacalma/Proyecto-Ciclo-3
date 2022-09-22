

using System.Collections.Generic;  //libreria donde se definen las interfaces
using pypSln.App.dominio;
using System.Linq;


namespace pypSln.App.persistencia{
    public class RVisitaPYP : IFRVisitaPYP  {
        private readonly appContext _appContext;
        public RVisitaPYP(appContext appContext) {
            _appContext = appContext;
        }
        visitapyp IFRVisitaPYP.AddVisitaPYP(visitapyp visitapyp) {
            var visitapypAdicionado = _appContext.visitapyp.Add(visitapyp);
            _appContext.SaveChanges();
            return visitapypAdicionado.Entity;
        }
        void IFRVisitaPYP.DeleteVisitaPYP(int Idvisitapyp) {
            var visitapypEncontrado = _appContext.visitapyp.FirstOrDefault(p => p.Id == Idvisitapyp);
            _appContext.visitapyp.Remove(visitapypEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<visitapyp> IFRVisitaPYP.GetAllVisitaPYP() {
            return _appContext.visitapyp;
        }
        visitapyp IFRVisitaPYP.GetVisitaPYP(int Idvisitapyp) {
            return _appContext.visitapyp.FirstOrDefault(p => p.Id == Idvisitapyp);
        }
        visitapyp IFRVisitaPYP.UpdateVisitaPYP(visitapyp visitapyp) {
            var visitapypEncontrado = _appContext.visitapyp.FirstOrDefault(p => p.Id == visitapyp.Id);
            if (visitapypEncontrado != null) {
                visitapypEncontrado.Id = visitapyp.Id;
                visitapypEncontrado.Id_ovino = visitapyp.Id_ovino;
                visitapypEncontrado.Id_propietario = visitapyp.Id_propietario;
                visitapypEncontrado.Id_veterinario = visitapyp.Id_veterinario;
                visitapypEncontrado.fecha = visitapyp.fecha;
                visitapypEncontrado.Temperatura = visitapyp.Temperatura;
                visitapypEncontrado.peso = visitapyp.peso;
                visitapypEncontrado.Fre_respiratoria = visitapyp.Fre_respiratoria;
                visitapypEncontrado.Fre_cardiaca = visitapyp.Fre_cardiaca;
                visitapypEncontrado.Estado = visitapyp.Estado;
                visitapypEncontrado.Recomendaciones = visitapyp.Recomendaciones;
                visitapypEncontrado.formula = visitapyp.formula;
                _appContext.SaveChanges();
            }
            return visitapypEncontrado;
        }
    }
}