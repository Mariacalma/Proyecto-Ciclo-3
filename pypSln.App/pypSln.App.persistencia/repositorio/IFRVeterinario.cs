using System.Collections.Generic; 
using pypSln.App.dominio;

namespace pypSln.App.persistencia {
    public interface IFRVeterinario {
        veterinario AddVeterinario(veterinario veterinario);
        void DeleteVeterinario(int idVeterinario);
        IEnumerable<Veterinario> GetAllVeterinario();
        veterinario GetVeterinario(int idVeterinario);
        veterinario UpdateVeterinario(veterinario veterinario);
    }

}