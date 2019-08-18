using RaptureApi.DTOs;
using System;
using System.Collections.Generic;

namespace RaptureApi.Repository
{
    public interface IRaptureRepository
    {
        IEnumerable<RaptureDetailsDto> GetAllRaptures();

        IEnumerable<RaptureDetailsDto> GetSurvivedRaptures(DateTime dateOfBirth);

        RaptureDetailsDto GetNextRapture();
    }
}
