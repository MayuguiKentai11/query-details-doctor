using System.Collections;
using RecipesDoctor.API.Medicine.Domain.Model.Aggregates;
using RecipesDoctor.API.Medicine.Domain.Model.Queries;

namespace RecipesDoctor.API.Medicine.Domain.Services;

public interface IDoctorDetailQueryService
{
    Task<IEnumerable<DoctorDetail>> Handle(GetDoctorDetailsByCmpQuery query);

    Task<IEnumerable<DoctorDetail>> Handle(GetDoctorDetailsByNameQuery query);

    Task<IEnumerable<DoctorDetail>> Handle(GetDoctorDetailsBySurnameQuery query);

    Task<IEnumerable<DoctorDetail>> Handle(GetDoctorDetailsByNameAndSurnameQuery query);
}