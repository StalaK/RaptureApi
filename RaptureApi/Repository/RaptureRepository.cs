using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using RaptureApi.Data;
using RaptureApi.DTOs;

namespace RaptureApi.Repository
{
    public class RaptureRepository : IRaptureRepository
    {
        private readonly RaptureContext context;
        private readonly IMapper mapper;

        public RaptureRepository(RaptureContext raptureContext, IMapper autoMapper)
        {
            context = raptureContext;
            mapper = autoMapper;
        }

        public IEnumerable<RaptureDetailsDto> GetAllRaptures()
        {
            var allResults = context.Raptures;

            return mapper.Map<IEnumerable<RaptureDetailsDto>>(allResults);
        }

        public RaptureDetailsDto GetNextRapture()
        {
            var nextRapture = context.Raptures.First(r => r.RaptureStartDate >= DateTime.Now);
            return mapper.Map<RaptureDetailsDto>(nextRapture);
        }

        public IEnumerable<RaptureDetailsDto> GetSurvivedRaptures(DateTime dateOfBirth)
        {
            var survivedRaptures = context.Raptures.Where(r => r.RaptureEndDate >= dateOfBirth && r.RaptureEndDate < DateTime.Now);
            return mapper.Map<IEnumerable<RaptureDetailsDto>>(survivedRaptures);
        }
    }
}
