using RaptureApi.DTOs;
using System;
using System.Collections.Generic;

namespace RaptureApi.Services
{
    public interface IRaptureService
    {
        IEnumerable<RaptureDetailsDto> GetAllRaptures();

        IEnumerable<RaptureDetailsDto> GetSurvivedRaptures(DateTime dateOfBirth);

        RaptureDetailsDto GetNextRapture();

        RaptureDetailsDto GetCurrentRapture();

        IEnumerable<RaptureDetailsDto> GetAllFutureRaptures();
    }
}
