using AutoMapper;
using BierOpdracht.EntitiesDb;
using BierOpdracht.ViewModels;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        
        CreateMap<Beer, BeerVM>().ReverseMap();
    }
}
