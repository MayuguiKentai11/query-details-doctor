using RecipesDoctor.API.Medicine.Domain.Model.Commands;

namespace RecipesDoctor.API.Medicine.Interfaces.REST.Transform;

public class CreateDoctorDetailCommandFromResourceAssembler
{
    public static CreateDoctorDetailCommand ToCommandFromResource(CreateDoctorDetailCommand command)
    {
        return new(command.DescriptionLaboratory, command.Molecule, command.Especiality, command.Cmp, command.Name,
            command.Surname, command.Region, command.Department,
            command.RepresentativeMan, command.Address, command.Status, command.MatMay);
    }
}