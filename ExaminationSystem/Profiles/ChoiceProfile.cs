using AutoMapper;
using ExaminationSystem.DTOs.ChoiceDTOs;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.ChoicesVMs;

namespace ExaminationSystem.Profiles
{
    public class ChoiceProfile:Profile
    {
        public ChoiceProfile()
        {
            CreateMap<ChoiceRequestVM, ChoiceRequestDTO>();
            CreateMap<ChoiceRequestDTO, Choice>();
            CreateMap<ChoiceUpdateVM, ChoiceResponseDTO>();
            CreateMap<ChoiceResponseDTO, Choice>().ReverseMap();
            
        }
    }
}
