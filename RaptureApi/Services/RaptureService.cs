using System;
using System.Collections.Generic;
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
            return repository.GetAllRaptures();
        }

        public RaptureDetailsDto GetNextRapture()
        {
            return repository.GetNextRapture();
        }

        public IEnumerable<RaptureDetailsDto> GetSurvivedRaptures(DateTime dateOfBirth)
        {
            return repository.GetSurvivedRaptures(dateOfBirth);
        }
    }
}
