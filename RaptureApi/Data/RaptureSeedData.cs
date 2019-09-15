using Microsoft.EntityFrameworkCore;
using RaptureApi.Models;
using System;

namespace RaptureApi.Data
{
    public class RaptureSeedData
    {
        public RaptureSeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rapture>().HasData(
                new Rapture
                {
                    Id = 1,
                    RaptureStartDate = new DateTime(2019, 6, 9),
                    RaptureEndDate = new DateTime(2019, 6, 9),
                    Predictor = "Ronald Weinland",
                    Details = "Jesus will return",
                    WhoGotRaptured = "Nobody",
                },
                new Rapture
                {
                    Id = 2,
                    RaptureStartDate = new DateTime(2020, 12, 31),
                    RaptureEndDate = new DateTime(2020, 12, 31),
                    Predictor = "Jeane Dixon",
                    Details = "Armageddon",
                    YearOnly = true
                });
        }
    }
}
