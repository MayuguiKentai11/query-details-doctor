using System.Collections;
using RecipesDoctor.API.Medicine.Domain.Model.Aggregates;
using RecipesDoctor.API.Shared.Domain.Repositories;

namespace RecipesDoctor.API.Medicine.Domain.Repositories;

public interface IDoctorDetailRepository : IBaseRepository<DoctorDetail>
{
    Task<IEnumerable<DoctorDetail>> FindDoctorDetailByCmpAsync(string cmp);
    
    Task<IEnumerable<DoctorDetail>> FindDoctorDetailByNameAndSurnameAsync(string name, string surname);

    Task<IEnumerable<DoctorDetail>> FindDoctorDetailByNameAsync(string name);
    
    Task<IEnumerable<DoctorDetail>> FindDoctorDetailBySurnameAsync(string surname);
}