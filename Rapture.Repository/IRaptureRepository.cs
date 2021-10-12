using Rapture.Common.Models;

namespace Rapture.Repository
{
    public interface IRaptureRepository
    {
        Task<IEnumerable<RaptureModel>> GetAllRaptures();

        Task<IEnumerable<RaptureModel>> GetSurvivedRaptures(DateTime dateOfBirth);

        Task<RaptureModel> GetNextRapture();

        Task<RaptureModel> GetCurrentRapture();

        Task<IEnumerable<RaptureModel>> GetAllFutureRaptures();
    }
}
