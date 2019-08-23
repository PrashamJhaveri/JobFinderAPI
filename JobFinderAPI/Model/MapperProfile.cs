using AutoMapper;

namespace JobfFinderAPI.Model
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Jobs, JobsDTO>();
            CreateMap<JobsDTO, Jobs>();
        }
    }
}
