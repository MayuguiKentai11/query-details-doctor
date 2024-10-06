using RecipesDoctor.API.Medicine.Domain.Model.Aggregates;
using RecipesDoctor.API.Medicine.Domain.Model.Queries;
using RecipesDoctor.API.Medicine.Domain.Repositories;
using RecipesDoctor.API.Medicine.Domain.Services;

namespace RecipesDoctor.API.Medicine.Application.Internal.QueryServices;

public class DoctorDetailQueryService(IDoctorDetailRepository doctorDetailRepository) : IDoctorDetailQueryService
{
    public async Task<IEnumerable<DoctorDetail>> Handle(GetDoctorDetailsByCmpQuery query)
    {
        if(string.IsNullOrEmpty(query.Cmp))
            throw new Exception("CMP is required");
        
        return await doctorDetailRepository.FindDoctorDetailByCmpAsync(query.Cmp.ToUpper());
    }

    public async Task<IEnumerable<DoctorDetail>> Handle(GetDoctorDetailsByNameQuery query)
    {
        if (string.IsNullOrEmpty(query.Name))
            throw new Exception("Name is required");
        
        return await doctorDetailRepository.FindDoctorDetailByNameAsync(query.Name.ToUpper());
    }

    public async Task<IEnumerable<DoctorDetail>> Handle(GetDoctorDetailsBySurnameQuery query)
    {
        if (string.IsNullOrEmpty(query.Surname))
            throw new Exception("Surname is required");
        
        return await doctorDetailRepository.FindDoctorDetailBySurnameAsync(query.Surname.ToUpper());
    }

    public async Task<IEnumerable<DoctorDetail>> Handle(GetDoctorDetailsByNameAndSurnameQuery query)
    {
        if(string.IsNullOrEmpty(query.Name) || string.IsNullOrEmpty(query.Surname))
            throw new Exception("Name and Surname are required");
        
        return await doctorDetailRepository.FindDoctorDetailByNameAndSurnameAsync(query.Name.ToUpper(), query.Surname.ToUpper());
    }
}