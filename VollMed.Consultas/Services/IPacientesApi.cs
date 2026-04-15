using Refit;

namespace VollMed.Consultas.Services
{
    public record PacientesApiResponse(long Id, string Nome);
    public interface IPacientesApi
    {
        [Get("/api/pacientes/{id}")]
        Task<PacientesApiResponse> GetByIdAsync(long id);
    }
}
