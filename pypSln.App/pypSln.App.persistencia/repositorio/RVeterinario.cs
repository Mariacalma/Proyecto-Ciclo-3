

using System.Collections.Generic;  //libreria donde se definen las interfaces
using pypSln.App.dominio;
using System.Linq;


namespace pypSln.App.persistencia{
    public class RVeterinario : IFRVeterinario  {
        private readonly appContext _appContext;
        public RVeterinario(appContext appContext) {
            _appContext = appContext;
        }
        veterinario IFRVeterinario.AddVeterinario(veterinario veterinario) {
            var veterinarioAdicionado = _appContext.veterinario.Add(veterinario);
            _appContext.SaveChanges();
            return veterinarioAdicionado.Entity;
        }
        void IFRVeterinario.DeleteVeterinario(int Idveterinario) {
            var veterinarioEncontrado = _appContext.veterinario.FirstOrDefault(p => p.Id == Idveterinario);
            _appContext.veterinario.Remove(veterinarioEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<veterinario> IFRVeterinario.GetAllVeterinario() {
            return _appContext.veterinario;
        }
        veterinario IFRVeterinario.GetVeterinario(int Idveterinario) {
            return _appContext.veterinario.FirstOrDefault(p => p.Id == Idveterinario);
        }
        veterinario IFRVeterinario.UpdateVeterinario(veterinario veterinario) {
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