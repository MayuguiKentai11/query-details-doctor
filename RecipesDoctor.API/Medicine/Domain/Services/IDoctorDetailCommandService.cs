using RecipesDoctor.API.Medicine.Domain.Model.Aggregates;
using RecipesDoctor.API.Medicine.Domain.Model.Commands;

namespace RecipesDoctor.API.Medicine.Domain.Services;

public interface IDoctorDetailCommandService
{
    Task<DoctorDetail> Handle(CreateDoctorDetailCommand command);
}