using System;
using System.Collections.Generic;
using System.Linq;
using RaptureApi.DTOs;
using RaptureApi.Repository;

namespace RaptureApi.Services
{
    public class RaptureService : IRaptureService
    {
        private readonly IRaptureRepository repository;

        public RaptureService(IRaptureRepository raptureRepo)
        {
            repository = raptureRepo;
        }

        public IEnumerable<RaptureDetailsDto> GetAllRaptures()
        {
            var raptures = repository.GetAllRaptures();
            return raptures.OrderBy(r => r.RaptureStartDate);
        }

        public RaptureDetailsDto GetNextRapture()
        {
            return repository.GetNextRapture();
        }

        public IEnumerable<RaptureDetailsDto> GetSurvivedRaptures(DateTime dateOfBirth)
        {
            var raptures = repository.GetSurvivedRaptures(dateOfBirth);
            return raptures.OrderBy(r => r.RaptureStartDate);
        }

        public RaptureDetailsDto GetCurrentRapture()
        {
            return repository.GetNextRapture();
        }

        public IEnumerable<RaptureDetailsDto> GetAllFutureRaptures()
        {
            var raptures = repository.GetAllFutureRaptures();
            return raptures.OrderBy(r => r.RaptureStartDate);
        }
    }
}
