using AutoMapper;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles
{
  public class FilmeProfile : Profile
  {
    public FilmeProfile()
    {
      CreateMap<CreateFilmesDto, Filme>();
      CreateMap<Filme, ReadFilmesDto>();
      CreateMap<UpdateFilmesDto, Filme>();
    }
  }
}