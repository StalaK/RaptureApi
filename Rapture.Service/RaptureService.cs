using Rapture.Common.Models;
using Rapture.Repository;

namespace Rapture.Service
{
    public class RaptureService : IRaptureService
    {
        private readonly IRaptureRepository _repository;

        public RaptureService(IRaptureRepository raptureRepo)
        {
            _repository = raptureRepo;
        }

        public async Task<IEnumerable<RaptureModel>> GetAllRaptures()
        {
            var raptures = await _repository.GetAllRaptures();
            return raptures.OrderBy(r => r.RaptureStartDate);
        }

        public async Task<RaptureModel> GetNextRapture() => await _repository.GetNextRapture();

        public async Task<IEnumerable<RaptureModel>> GetSurvivedRaptures(DateTime dateOfBirth)
        {
            var raptures = await _repository.GetSurvivedRaptures(dateOfBirth);
            return raptures.OrderBy(r => r.RaptureStartDate);
        }

        public async Task<RaptureModel> GetCurrentRapture() => await _repository.GetCurrentRapture();

        public async Task<IEnumerable<RaptureModel>> GetAllFutureRaptures()
        {
            var raptures = await _repository.GetAllFutureRaptures();
            return raptures.OrderBy(r => r.RaptureStartDate);
        }
    }
}
