using AutoMapper;
using RaptureApi.DTOs;
using RaptureApi.Models;
using RaptureApi.ViewModels;

namespace RaptureApi.Data
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Rapture, RaptureDetailsDto>();
            CreateMap<RaptureDetailsDto, RaptureDetailsViewModel>();
        }
    }
}
