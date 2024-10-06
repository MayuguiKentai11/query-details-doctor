using Microsoft.EntityFrameworkCore;
using RecipesDoctor.API.Medicine.Domain.Model.Aggregates;
using RecipesDoctor.API.Medicine.Domain.Repositories;
using RecipesDoctor.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using RecipesDoctor.API.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace RecipesDoctor.API.Medicine.Infrastructure.Persistence.EFC.Repositories;

public class DoctorDetailRepository(AppDbContext context) : BaseRepository<DoctorDetail>(context), IDoctorDetailRepository
{
    public async Task<IEnumerable<DoctorDetail>> FindDoctorDetailByCmpAsync(string cmp)
    {
        return await Context.Set<DoctorDetail>().Where(d => d.Cmp == cmp).ToListAsync();
    }

    public async Task<IEnumerable<DoctorDetail>> FindDoctorDetailByNameAndSurnameAsync(string name, string surname)
    {
        return await Context.Set<DoctorDetail>().Where(d => d.Name == name && d.Surname == surname).ToListAsync();
    }

    public async Task<IEnumerable<DoctorDetail>> FindDoctorDetailByNameAsync(string name)
    {
        return await Context.Set<DoctorDetail>().Where(d => d.Name == name).ToListAsync();
    }

    public async Task<IEnumerable<DoctorDetail>> FindDoctorDetailBySurnameAsync(string surname)
    {
        return await Context.Set<DoctorDetail>().Where(d => d.Surname == surname).ToListAsync();
    }
}