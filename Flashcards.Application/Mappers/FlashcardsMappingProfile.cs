using AutoMapper;
using Flashcards.Application.DTOs;
using Flashcards.Core.Entities;

namespace Flashcards.Application.Mappers;

public class FlashcardsMappingProfile : Profile
{
    public FlashcardsMappingProfile()
    {
        CreateMap<Category, CategoryDto>().ReverseMap();
        CreateMap<Tag, TagDto>().ReverseMap();
        CreateMap<Deck, DeckDto>().ReverseMap();
        CreateMap<Flashcard, FlashcardDto>()
           .ForMember(dest => dest.TagIds, opt => opt.MapFrom(src => src.Tags.Select(t => t.Id).ToList()))
                .ReverseMap();
        CreateMap<ApplicationUser, ApplicationUserDto>().ReverseMap();
    }
}
