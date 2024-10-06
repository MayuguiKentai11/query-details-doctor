using RecipesDoctor.API.Medicine.Domain.Model.Aggregates;
using RecipesDoctor.API.Medicine.Domain.Model.Commands;
using RecipesDoctor.API.Medicine.Domain.Repositories;
using RecipesDoctor.API.Medicine.Domain.Services;

namespace RecipesDoctor.API.Medicine.Application.Internal.CommandServices;

public class DoctorDetailCommandService(IDoctorDetailRepository doctorDetailRepository) : IDoctorDetailCommandService
{
    public Task<DoctorDetail> Handle(CreateDoctorDetailCommand command)
    {
        throw new NotImplementedException();
    }
}