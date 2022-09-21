

using System.Collections.Generic;  //libreria donde se definen las interfaces
using pypSln.App.dominio;
using System.Linq;


namespace pypSln.App.persistencia{
    public class RVeterinario : IFRVeterinario  {
        private readonly AppContext _appContext;
        public RVeterinario(AppContext appContext) {
            _appContext = appContext;
        }
        veterinario IFRVeterinario.Addveterinario(veterinario veterinario) {
            var veterinarioAdicionado = _appContext.veterinario.Add(veterinario);
            _appContext.SaveChanges();
            return veterinarioAdicionado.Entity;
        }
        void RVeterinario.Deleteveterinario(int Idveterinario) {
            var veterinarioEncontrado = _appContext.veterinario.FirstOrDefault(p => p.i == idveterinario);
            if (veterinarioEncontrado = null) {
                return;
            }
            _appContext.veterinario.Remove(veterinarioEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<veterinario> IFRVeterinario.GetAllveterinario() {
            return _appContext.veterinario;
        }
        veterinario IFRVeterinario.Getveterinario(int Idveterinario) {
            return _appContext.veterinario.FirstOrDefault(p => p.Id == Idveterinario);
        }
        veterinario IFRVeterinario.Updateveterinario(veterinario veterinario) {
            var veterinarioEncontrado = _appContext.veterinario.FirstOrDefault(p => p.Id == veterinario.Id);
            if (veterinarioEncontrado != null) {
                veterinarioEncontrado.Id = veterinario.Id;
                veterinarioEncontrado.TarjetaProfesional = veterinario.TarjetaProfesional;
                _appContext.SaveChanges();
            }
            return veterinarioEncontrado;
        }
    }
}