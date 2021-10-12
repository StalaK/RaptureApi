using Rapture.Common.Models;

namespace Rapture.Repository
{
    public class RaptureRepository : IRaptureRepository
    {
        private readonly RaptureContext _context;

        public RaptureRepository(RaptureContext raptureContext)
        {
            _context = raptureContext;
        }

        public async Task<IEnumerable<RaptureModel>> GetAllRaptures() => _context.Raptures;

        public async Task<RaptureModel> GetNextRapture() => _context.Raptures.FirstOrDefault(r => r.RaptureStartDate >= DateTime.Now);

        public async Task<IEnumerable<RaptureModel>> GetSurvivedRaptures(DateTime dateOfBirth) => _context.Raptures.Where(r => r.RaptureEndDate >= dateOfBirth && r.RaptureEndDate < DateTime.Now);

        public async Task<RaptureModel> GetCurrentRapture() => _context.Raptures.FirstOrDefault(r => r.RaptureStartDate <= DateTime.Now && r.RaptureEndDate >= DateTime.Now);

        public async Task<IEnumerable<RaptureModel>> GetAllFutureRaptures() => _context.Raptures.Where(r => r.RaptureEndDate >= DateTime.Now);
    }
}
