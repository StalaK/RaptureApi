using Rapture.Common.Mapper;
using Rapture.Service;

namespace Rapture.Api;

internal static class Endpoints
{
    internal static void LoadEndpoints(this WebApplication app)
    {
        app.MapGet("/GetAllRaptures", async (IRaptureService service) =>
            RaptureToRaptureDetailsViewModel.Map(await service.GetAllRaptures()));

        app.MapGet("/GetSurvivedRaptures", async (IRaptureService service, DateTime dateOfBirth) =>
            RaptureToRaptureDetailsViewModel.Map(await service.GetSurvivedRaptures(dateOfBirth)));

        app.MapGet("/GetNextRapture", async (IRaptureService service) =>
            RaptureToRaptureDetailsViewModel.Map(await service.GetNextRapture()));

        app.MapGet("/GetCurrentRapture", async (IRaptureService service) =>
            RaptureToRaptureDetailsViewModel.Map(await service.GetCurrentRapture()));

        app.MapGet("/GetAllFutureRaptures", async (IRaptureService service) =>
            RaptureToRaptureDetailsViewModel.Map(await service.GetAllFutureRaptures()));
    }
}
