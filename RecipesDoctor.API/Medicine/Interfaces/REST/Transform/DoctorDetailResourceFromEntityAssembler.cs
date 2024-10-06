using RecipesDoctor.API.Medicine.Domain.Model.Aggregates;
using RecipesDoctor.API.Medicine.Interfaces.REST.Resources;

namespace RecipesDoctor.API.Medicine.Interfaces.REST.Transform;

public class DoctorDetailResourceFromEntityAssembler
{
    public static DoctorDetailResource ToResourceFromEntity(DoctorDetail entity)
    {
        return new(entity.Id, entity.DescriptionLaboratory, entity.Molecule, entity.Especiality, entity.Cmp,
            entity.Name, entity.Surname, entity.Department, entity.YtdSun23, entity.YtdSun24,entity.QtrSetNov,
            entity.QtrDicFeb, entity.QtrMarMay, entity.QtrJunAgo);
    }
}