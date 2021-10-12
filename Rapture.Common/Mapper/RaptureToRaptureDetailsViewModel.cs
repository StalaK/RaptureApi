using AutoMapper;
using Rapture.Common.Models;
using Rapture.Common.ViewModels;

namespace Rapture.Common.Mapper
{
    public class RaptureToRaptureDetailsViewModel : Profile
    {
        public RaptureToRaptureDetailsViewModel()
        {
            CreateMap<RaptureModel, RaptureDetailsViewModel>()
                .ForMember(dest => dest.RaptureStartDate, map => map.MapFrom(src => src.RaptureStartDate))
                .ForMember(dest => dest.RaptureEndDate, map => map.MapFrom(src => src.RaptureEndDate))
                .ForMember(dest => dest.Predictor, map => map.MapFrom(src => src.Predictor))
                .ForMember(dest => dest.Details, map => map.MapFrom(src => src.Details))
                .ForMember(dest => dest.WhoGotRaptured, map => map.MapFrom(src => src.WhoGotRaptured))
                .ForMember(dest => dest.MonthOnly, map => map.MapFrom(src => src.MonthOnly))
                .ForMember(dest => dest.YearOnly, map => map.MapFrom(src => src.YearOnly));
        }

        public static RaptureDetailsViewModel Map(RaptureModel rapture)
        {
            var config = new MapperConfiguration(config => config.AddProfile<RaptureToRaptureDetailsViewModel>());
            var mapper = config.CreateMapper();

            return mapper.Map<RaptureDetailsViewModel>(rapture);
        }

        public static List<RaptureDetailsViewModel> Map(IEnumerable<RaptureModel> rapture)
        {
            var config = new MapperConfiguration(config => config.AddProfile<RaptureToRaptureDetailsViewModel>());
            var mapper = config.CreateMapper();

            return mapper.Map<List<RaptureDetailsViewModel>>(rapture);
        }
    }
}
